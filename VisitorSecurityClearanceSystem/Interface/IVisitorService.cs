using VisitorSecurityClearanceSystem.DTO;

namespace VisitorSecurityClearanceSystem.Interface
{
    public interface IVisitorService
    {
        Task<VisitorModel> AddVisitor(VisitorModel visitorModel);
    }
}

