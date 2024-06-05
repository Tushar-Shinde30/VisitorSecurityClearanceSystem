namespace VisitorSecurityClearanceSystem.Common
{
    public class Credentials
    {
        public static readonly string databaseName = Environment.GetEnvironmentVariable("dataBaseName");
        public static readonly string containerName = Environment.GetEnvironmentVariable("containerName");

        public static readonly string cosmosEndPoint = Environment.GetEnvironmentVariable("cosmosUrl");

        public static readonly string primaryKey = Environment.GetEnvironmentVariable("primaryKey");

    }
}



