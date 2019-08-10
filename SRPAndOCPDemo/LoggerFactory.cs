using System;

namespace SRPAndOCPDemo
{
    internal class LoggerFactory
    {
        public static ILogger GetLogger(string loggerType)
        {
            switch (loggerType)
            {
                case "Database": return new DatabaseLogger();
                default:
                    throw new InvalidLoggerException();
            }
        }
    }
}