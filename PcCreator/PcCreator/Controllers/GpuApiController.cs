using Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace PcCreator.Controllers
{
    [Route("api/gpus")]
    [ApiController]
    public class GpuApiController : ControllerBase
    {
        private readonly AppDbContext _context;

        public GpuApiController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetFiltered(string filter)
        {
            return Ok(_context.Gpus
                .Where(g => g.FullName.Contains(filter))
                .Select(g => new { g.Id, g.FullName, g.VRam })
                .ToList());
        }
    }
}
