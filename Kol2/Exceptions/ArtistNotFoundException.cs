using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kol2.Exceptions
{
    public class ArtistNotFoundException : Exception
    {
        public ArtistNotFoundException(string message) : base(message)
        {
        }

        public ArtistNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public ArtistNotFoundException()
        {
        }


    }
}
