using VisitorSecurityClearanceSystem.Model;

namespace VisitorSecurityClearanceSystem.CosmosDB
{
    public interface ICosmosDBService
    {
        Task<VisitorEntity> AddVisitor(VisitorEntity visitor);
    }
}

