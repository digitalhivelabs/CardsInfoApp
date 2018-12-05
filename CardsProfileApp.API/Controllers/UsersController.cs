using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using CardsProfileApp.API.Data;
using CardsProfileApp.API.DTOs;
using CardsProfileApp.API.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using CardsProfileApp.API.Models;

namespace CardsProfileApp.API.Controllers
{
    [ServiceFilter(typeof(LogUserActivity))]
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
   public class UsersController: ControllerBase
    {
        private readonly IProfilesRepository _repo;
        private readonly IMapper _mapper;

        public UsersController(IProfilesRepository repo, IMapper mapper)
        {
            this._repo = repo;
            this._mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetProfiles([FromQuery]UserParams userParams)
        {
            var currentUserId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            
            var userFromRepo = await this._repo.GetUser(currentUserId);

            userParams.UserId = currentUserId;

            if (string.IsNullOrEmpty(userParams.Gender))
            {
                userParams.Gender = userFromRepo.Gender == "male" ? "female" : "male";
            }

            var profiles = await this._repo.GetUsers(userParams);

            var result = this._mapper.Map<IEnumerable<ProfileForListDTO>>(profiles);

            Response.AddPagination(profiles.CurrentPage, profiles.PageSize, profiles.TotalCount, profiles.TotalPages);



            return Ok(result);
        }

        [HttpGet("{id}", Name="GetUser")]
        public async Task<IActionResult> GetProfile(int id)
        {
            var profile = await this._repo.GetUser(id);

            var result = this._mapper.Map<ProfileForDetailDTO>(profile);

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id, UserForUpdateDTO userForUpdateDto)
        {
            if (id != int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value))
                return Unauthorized();

            var userFromRepo = await this._repo.GetUser(id);

            this._mapper.Map(userForUpdateDto, userFromRepo);

            if (await _repo.SaveAll())
                return NoContent();

            throw new Exception($"Updating user {id} failed in save");
        }

        [HttpPost("{id}/like/{recipientId}")]
        public async Task<ActionResult> LikeUser(int id, int recipientId)
        {
            if (id != int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value))
                return Unauthorized();

            var like = await this._repo.GetLike(id, recipientId);

            if (like != null)
                return BadRequest("You already like this user");

            if (await this._repo.GetUser(recipientId) == null)
                return NotFound();

            like = new Like 
            {
                LikerId = id,
                LikeeId = recipientId
            };

            this._repo.Add<Like>(like);

            if (await this._repo.SaveAll())
                return Ok();

            return BadRequest("Failes to like user");
        }
    }
}