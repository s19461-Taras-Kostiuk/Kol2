using Kol2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kol2.DTO.Response
{
    public class GetArtistResponse
    {
        public Artist Artist { get; set; }

        public List<Event> Events { get; set; }
    }
}
