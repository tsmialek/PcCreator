using Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace PcCreator.Controllers
{
    [Route("api/cpus")]
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
            return Ok(_context.Cpus
                .Where(c => c.Name.Contains(filter))
                .Select(c => new { c.Name, c.Id })
                .ToList());
        }
    }
}
