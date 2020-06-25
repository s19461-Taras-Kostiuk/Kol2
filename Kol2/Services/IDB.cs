
using Kol2.DTO;
using Kol2.DTO.Response;
using Kol2.Models;
using System.Threading.Tasks;

namespace Kol2.Services
{
    public interface IDB
    {
        public GetArtistResponse GetArtists(int id);

        public void PutEvents(int artistId, int eventId, PutArtistRequest request);
        
       
    }
}
