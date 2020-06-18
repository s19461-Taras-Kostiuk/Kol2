using Microsoft.AspNetCore.Mvc;
using PrzykladKolokwium2.Exceptions;
using PrzykladKolokwium2.Services;
using System;
using System.Threading.Tasks;

namespace PrzykladKolokwium2.Controllers
{
    [Route("api/artists")]
    [ApiController]
    public class ArtistsController : ControllerBase
    {
        private readonly IDB _dbService;
        public ArtistsController(IDB dbService)
        {
            _dbService = dbService;
        }

        [HttpGet("{id:int}")]
        public IActionResult GetArtists(int id)
        {
            try
            {
                var result =  _dbService.GetArtists(id);
                return Ok(result);
            }
            catch (Exception exc)
            {
                return NotFound(exc.Message);
            }
        }
    }
}
