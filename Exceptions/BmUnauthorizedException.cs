using System;

namespace BattlemetricsWrapper.Exceptions
{
    public class BmUnauthorizedException : Exception
    {
        internal BmUnauthorizedException()
        {
        }

        internal BmUnauthorizedException(string message) : base(message)
        {
        }

        internal BmUnauthorizedException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}