using Microsoft.EntityFrameworkCore;
using PrzykladKolokwium2.Exceptions;
using PrzykladKolokwium2.Models;
using System.Linq;
using System.Threading.Tasks;

namespace PrzykladKolokwium2.Services
{
    public class SqlServerEventDbService : IDB
    {

        private readonly EventDbContext _context;
        public SqlServerEventDbService(EventDbContext context)
        {
            _context = context;
        }

        public Artist GetArtists(int id)
        {
            var artist = _context.Artists
                  .Single(x => x.IdArtist.Equals(id));

            var events = _context.Artist_Events.Where(x =>
            x.IdArtist.Equals(id)).ToList();


             foreach (var eventss in  events ){
            var res =  _context.Events.Single(x => x.IdEvent.Equals(eventss.IdEvent));
            }
            
           

            artist.ArtistEvent=artist.ArtistEvent.OrderByDescending(p=>p.PerfomanceDate).ToList();

            return artist;
        }
    }
}
