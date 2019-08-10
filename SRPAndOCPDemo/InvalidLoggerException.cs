using System;

namespace SRPAndOCPDemo
{
    internal class InvalidLoggerException : Exception
    {
        public InvalidLoggerException()
        {
        }

        public InvalidLoggerException(string message) : base(message)
        {
        }

        public InvalidLoggerException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}