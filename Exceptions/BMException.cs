using System;

namespace BattlemetricsWrapper.Exceptions
{
    public class BmException : Exception
    {
        internal BmException()
        {
        }

        internal BmException(string message) : base(message)
        {
        }

        internal BmException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}