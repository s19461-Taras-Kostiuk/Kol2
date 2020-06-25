using System.Collections.Generic;

namespace Kol2.Models
{    
    public class Organiser
    {
        public int IdOrganiser {get; set; }
        public string  Name {get; set;}
        public ICollection <Event_Organiser> EventOrganiser {get; set;}

    }
    
}

