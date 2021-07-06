using System;

namespace BattlemetricsWrapper.Exceptions
{
    public class BmInvalidBanIdException : Exception
    {
        internal BmInvalidBanIdException()
        {
        }

        internal BmInvalidBanIdException(string message) : base(message)
        {
        }

        internal BmInvalidBanIdException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}