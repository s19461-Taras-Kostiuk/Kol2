using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kol2.Exceptions
{
    public class ArtistOrEventNotExistingException : Exception
    {
        public ArtistOrEventNotExistingException()
        {
        }

        public ArtistOrEventNotExistingException(string message) : base(message)
        {
        }

        public ArtistOrEventNotExistingException(string message, Exception exception) : base(message, exception)
        {
        }
    }
}
