using System;

namespace BattlemetricsWrapper.Exceptions
{
    public class BmUnknownGameException : Exception
    {
        internal BmUnknownGameException()
        {
        }

        internal BmUnknownGameException(string message) : base(message)
        {
        }

        internal BmUnknownGameException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}