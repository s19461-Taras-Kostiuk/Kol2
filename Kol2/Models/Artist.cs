using System.Collections.Generic;

namespace PrzykladKolokwium2.Models
{
    
     public class Artist
     {
       public int IdArtist { get; set; }
       public string Nickname { get; set; }
       public ICollection <Artist_Event> ArtistEvent {get; set; }

     }
    
}