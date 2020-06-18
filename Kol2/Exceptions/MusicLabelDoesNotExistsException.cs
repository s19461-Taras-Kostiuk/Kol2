using System;

namespace PrzykladKolokwium2.Exceptions
{
    public class MusicLabelDoesNotExistsException : Exception
    {
        public MusicLabelDoesNotExistsException(string message) : base(message)
        {
        }

        public MusicLabelDoesNotExistsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public MusicLabelDoesNotExistsException()
        {
        }
    }
}
