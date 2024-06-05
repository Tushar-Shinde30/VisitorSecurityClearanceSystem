using Microsoft.AspNetCore.Mvc;
using VisitorSecurityClearanceSystem.DTO;
using VisitorSecurityClearanceSystem.Interface;

namespace VisitorSecurityClearanceSystem.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class VisitorController : Controller
    {
        public readonly IVisitorService _visitorService;

        public VisitorController(IVisitorService visitorService)
        {
            _visitorService = visitorService;

        }

        [HttpPost]
        public async Task<VisitorModel> AddVisitor(VisitorModel visitorModel)
        {
            var response = await _visitorService.AddVisitor(visitorModel);
            return response;

        }
    }
}

