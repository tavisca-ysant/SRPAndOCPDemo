using System;

namespace SRPAndOCPDemo
{
    public class RepositoryFactory
    {
        public static IRepository GetRepository(string repositoryType)
        {
            switch (repositoryType)
            {
                case "Database": return new Database();
                default: throw new InvalidRepostiory();
            }
        }
    }
}