using System;

namespace PrzykladKolokwium2.Exceptions
{
    public class MusicianReleasedAnAlbumException : Exception
    {
        public MusicianReleasedAnAlbumException(string message) : base(message)
        {
        }

        public MusicianReleasedAnAlbumException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public MusicianReleasedAnAlbumException()
        {
        }
    }
}
