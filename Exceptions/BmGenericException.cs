using System;

namespace BattlemetricsWrapper.Exceptions
{
    public class BmGenericException : Exception
    {
        internal BmGenericException()
        {
        }

        internal BmGenericException(string message) : base(message)
        {
        }

        internal BmGenericException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}