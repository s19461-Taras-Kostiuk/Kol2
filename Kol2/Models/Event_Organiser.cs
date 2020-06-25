using System;
using System.Collections.Generic;

namespace Kol2.Models
{

    
    public class Event_Organiser
    {
        public int IdEvent { get; set; }
        public int IdOrganiser { get; set; }
        public Event Event {get; set; }
        public Organiser Organiser {get; set; }
    }
    

}