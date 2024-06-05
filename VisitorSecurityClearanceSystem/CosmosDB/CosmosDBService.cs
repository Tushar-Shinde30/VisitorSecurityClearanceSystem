using Microsoft.Azure.Cosmos;
using VisitorSecurityClearanceSystem.Common;
using VisitorSecurityClearanceSystem.Model;

namespace VisitorSecurityClearanceSystem.CosmosDB
{
    public class CosmosDBService : ICosmosDBService
    {
        public CosmosClient _cosmosClient;

        private readonly Container _container;

        public CosmosDBService()
        {
            _cosmosClient = new CosmosClient(Credentials.cosmosEndPoint, Credentials.primaryKey);
            _container = _cosmosClient.GetContainer(Credentials.databaseName, Credentials.containerName);
        }

        public async Task<VisitorEntity> AddVisitor(VisitorEntity visitor)
        {
            var response = await _container.CreateItemAsync(visitor);
            return response;
        }
    }
}



