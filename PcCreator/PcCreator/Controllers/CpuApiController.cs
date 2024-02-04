using Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace PcCreator.Controllers
{
    [Route("api/cpus")]
    [ApiController]
    public class CpuApiController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CpuApiController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetFiltered(string filterCpu)
        {
            return Ok(_context.Cpus
                .Where(g => g.Name.Contains(filterCpu))
                .Select(g => new { g.Id, g.Name })
                .ToList());
        }
    }
}
