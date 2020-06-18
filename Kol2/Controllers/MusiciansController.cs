//using Microsoft.AspNetCore.Mvc;
//using PrzykladKolokwium2.Exceptions;
//using PrzykladKolokwium2.Services;
//using System.Threading.Tasks;

//namespace PrzykladKolokwium2.Controllers
//{
//    [Route("api/musician")]
//    [ApiController]
//    public class MusiciansController : ControllerBase
//    {
//        private readonly IMusicDbService _dbService;
//        public MusiciansController(IMusicDbService dbService)
//        {
//            _dbService = dbService;
//        }


//        [HttpDelete("{id:int}")]
//        public async Task<IActionResult> RemoveMusician(int id)
//        {
//            try
//            {
//                await _dbService.RemoveMusician(id);
//                return NoContent();
//            }
//            catch (MusicianDoesNotExistsException exc)
//            {
//                return NotFound(exc.Message);
//            }
//            catch (MusicianReleasedAnAlbumException exc)
//            {
//                return BadRequest(exc.Message);
//            }
//        }

//    }
//}
