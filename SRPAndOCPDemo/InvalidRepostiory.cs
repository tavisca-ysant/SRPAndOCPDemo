using System;

namespace SRPAndOCPDemo
{
    internal class InvalidRepostiory : Exception
    {
        public InvalidRepostiory()
        {
        }

        public InvalidRepostiory(string message) : base(message)
        {
        }

        public InvalidRepostiory(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}