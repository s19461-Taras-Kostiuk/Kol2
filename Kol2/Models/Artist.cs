using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Kol2.Models
{
    
     public class Artist
     {
        [JsonIgnore]
        public int IdArtist { get; set; }
        [JsonIgnore]
        public string Nickname { get; set; }
        [JsonIgnore]
        public ICollection <Artist_Event> ArtistEvent {get; set; }

     }
    
}