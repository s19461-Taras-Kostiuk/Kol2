using System;
using System.Collections.Generic;

namespace Kol2.Models
{

     public class Event
     {

     public int IdEvent {get; set; }
     public string Name {get; set; }
     public DateTime StartDate {get; set; }
     public DateTime EndDate {get; set; }
     public ICollection <Artist_Event> ArtistEvent { get; set; }
     public ICollection <Event_Organiser> EventOrganiser {get; set; }

     }
}