using System.Threading.Tasks;
using AutoMapper;
using CardsProfileApp.API.Data;
using CardsProfileApp.API.DTOs.PSProfile;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CardsProfileApp.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PSProfilesController : ControllerBase
    {
        private readonly IPSRepository _repo;
        private readonly IMapper _mapper;

        public PSProfilesController(IPSRepository repo, IMapper mapper)
        {
            this._repo = repo;
            this._mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProfile(int id)
        {

            var profile = await this._repo.GetProfile(id);

            var result = this._mapper.Map<PSProfileForDetailDTO>(profile);

            return Ok(result);
        }
    }
}
