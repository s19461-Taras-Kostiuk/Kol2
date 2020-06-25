using System;

namespace Kol2.Models
{
 
     public class Artist_Event
     {
        public int IdEvent{get; set; }
        public int IdArtist {get; set; }
        public DateTime PerfomanceDate {get; set; }
        public Artist Artist { get; set; }
        public Event Event { get; set; }


    }
 
}