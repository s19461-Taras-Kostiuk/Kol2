using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kol2.Exceptions
{
    public class DateNotInRangeException : Exception
    {
        public DateNotInRangeException()
        {
        }

        public DateNotInRangeException(string message) : base(message)
        {
        }

        public DateNotInRangeException(string message, Exception exception) : base(message, exception)
        {
        }
    }
}
