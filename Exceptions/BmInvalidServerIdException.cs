using System;

namespace BattlemetricsWrapper.Exceptions
{
    public class BmInvalidServerIdException : Exception
    {
        internal BmInvalidServerIdException()
        {
        }

        internal BmInvalidServerIdException(string message) : base(message)
        {
        }

        internal BmInvalidServerIdException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}