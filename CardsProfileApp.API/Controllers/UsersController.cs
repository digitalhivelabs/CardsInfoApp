using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using CardsProfileApp.API.Data;
using CardsProfileApp.API.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CardsProfileApp.API.Controllers
{
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
        public async Task<IActionResult> GetProfiles()
        {
            var profiles = await this._repo.GetUsers();

            var result = this._mapper.Map<IEnumerable<ProfileForListDTO>>(profiles);

            return Ok(result);
        }

        [HttpGet("{id}")]
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
    }
}