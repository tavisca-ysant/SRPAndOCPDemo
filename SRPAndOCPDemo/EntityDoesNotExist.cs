using System;

namespace SRPAndOCPDemo
{
    internal class EntityDoesNotExist : Exception
    {
        public EntityDoesNotExist()
        {
        }

        public EntityDoesNotExist(string message) : base(message)
        {
        }

        public EntityDoesNotExist(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}