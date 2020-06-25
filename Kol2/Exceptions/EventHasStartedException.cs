using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kol2.Exceptions
{
    public class EventHasStartedException : Exception
    {
        public EventHasStartedException()
        {
        }

        public EventHasStartedException(string message) : base(message)
        {
        }

        public EventHasStartedException(string message, Exception exception) : base(message, exception)
        {
        }
    }
}
