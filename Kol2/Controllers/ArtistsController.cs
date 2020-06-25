using Kol2.DTO;
using Kol2.Exceptions;
using Kol2.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Kol2.Controllers
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
            catch (ArtistNotFoundException exc)
            {
                return NotFound(exc.Message);
            }
        }

        [HttpPut("{artistId}/events/{eventId}")]
        public IActionResult PutEvents(int artistId, int eventId, PutArtistRequest request)
        {
            try
            {
                _dbService.PutEvents(artistId, eventId, request);
                return Ok();
            }
            catch (ArtistOrEventNotExistingException exc)
            {
                return NotFound(exc.Message);
            }
            catch (EventHasStartedException exc)
            {
                return Conflict(exc.Message);
            }
            catch (DateNotInRangeException exc)
            {
                return BadRequest(exc.Message);
            }
            catch (Exception exc)
            {
                return NotFound(exc.Message);
            }
        }




    }

  
}
