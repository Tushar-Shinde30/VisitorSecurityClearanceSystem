using Microsoft.AspNetCore.Mvc;
using VisitorSecurityClearanceSystem.Interface;

namespace VisitorSecurityClearanceSystem.Controllers
{
    public class VisitorController : Controller
    {
        public readonly IVisitorService _visitorService;

        public VisitorController(IVisitorService visitorService)
        {
            _visitorService = visitorService;
            
        }
    }
}
