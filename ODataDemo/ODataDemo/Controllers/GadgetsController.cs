using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using ODataDemo.Models;

namespace ODataDemo.Controllers
{
    [Route("api/gadget")]
    [ApiController]
    public class GadgetsController : ControllerBase
    {
        private readonly Prn231_Slot10_ODataContext _context;
        public GadgetsController(Prn231_Slot10_ODataContext context)
        {
            _context = context;
        }

        [EnableQuery]
        [HttpGet("Get")]
        public IActionResult GetGadgets()
        {
            return Ok(_context.Gadgets.AsQueryable());
        }
    }
}
