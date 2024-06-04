using VisitorSecurityClearanceSystem.CosmosDB;
using VisitorSecurityClearanceSystem.Interface;

namespace VisitorSecurityClearanceSystem.Services
{
    public class VisitorService:IVisitorService
    {
        public readonly ICosmosDBService _cosmosDBService;

        public VisitorService(ICosmosDBService cosmosDBService)
        {
            _cosmosDBService = cosmosDBService;
            
        }
    }
}
