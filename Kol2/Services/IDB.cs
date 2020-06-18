using PrzykladKolokwium2.Models;
using System.Threading.Tasks;

namespace PrzykladKolokwium2.Services
{
    public interface IDB
    {
        public Artist  GetArtists(int id);
        
        
    }
}
