using System;

namespace BattlemetricsWrapper
{
    public class BMException : Exception
    {
        internal BMException()
        {
        }

        internal BMException(string message) : base(message)
        {
        }

        internal BMException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}