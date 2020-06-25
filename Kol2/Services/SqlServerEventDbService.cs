using Kol2.DTO;
using Kol2.DTO.Response;
using Kol2.Exceptions;
using Kol2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kol2.Services
{

    public class SqlServerEventDbService : IDB
    {

        private readonly EventDbContext _context;
        public SqlServerEventDbService(EventDbContext context)
        {
            _context = context;
        }

        public GetArtistResponse GetArtists(int id)
        {
            var artistExists = _context.Artists.Any(x => x.IdArtist.Equals(id));
            if (!artistExists)
            {
                throw new ArtistNotFoundException();
            }

            var artist = _context.Artists
                  .Single(x => x.IdArtist.Equals(id));

            var artistEvents = _context.Artist_Events
                .Where(x => x.IdArtist.Equals(id))
                .OrderByDescending(x => x.PerfomanceDate)
                .ToList();

            var events = new List<Event>();
            foreach (var artistEvent in artistEvents)
            {
                events.Add(_context.Events.Single(x => x.IdEvent.Equals(artistEvent.IdEvent)));
            }

            var result = new GetArtistResponse
            {
                Artist = artist,
                Events = events
            };
            return result;
        }




        public void PutEvents(int artistId, int eventId, PutArtistRequest request)
        {
            var artistExists = _context.Artists.Any(x => x.IdArtist.Equals(artistId));
            var eventExists = _context.Events.Any(x => x.IdEvent.Equals(eventId));

            if (!artistExists || !eventExists)
            {
                throw new ArtistOrEventNotExistingException($"Artist {artistId} or {eventId} doesnt exist");
            }

            var eventToUpdate = _context.Events.Single(x => x.IdEvent.Equals(eventId));

            var eventHasStarted = eventToUpdate.StartDate <= DateTime.Now;
            if (eventHasStarted)
            {
                throw new EventHasStartedException($"The event {eventId} has started");
            }

            var newDateInRange = request.PerfomanceDate >= eventToUpdate.StartDate
                                 && request.PerfomanceDate <= eventToUpdate.EndDate;
            if (!newDateInRange)
            {
                throw new DateNotInRangeException("The passed date is not in range");
            }

            eventToUpdate.StartDate = request.PerfomanceDate;
            _context.SaveChanges();
        }

       
    }
}
