using Microsoft.Azure.Cosmos;
using VisitorSecurityClearanceSystem.Common;

namespace VisitorSecurityClearanceSystem.CosmosDB
{
    public class CosmosDBService:ICosmosDBService
    {
        public CosmosClient _cosmosClient;

        private readonly Container _container;

        public CosmosDBService(CosmosClient cosmosClient)
        {
            _container= cosmosClient.GetContainer(Credentials.databaseName, Credentials.containerName);
            
        }
    }
}
