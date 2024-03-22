using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SiTaG_API.Data;
using SiTaG_API.DTOs;
using AutoMapper;
namespace SiTaG_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthStatusController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        
        public HealthStatusController(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReadHealthStatusDto>>> GetAllHealthStatus()
        {
            var healthStatus = await _context.HealthStatuses.ToListAsync();
            var healthStatusDto = _mapper.Map<List<ReadHealthStatusDto>>(healthStatus);
            return Ok(healthStatusDto);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ReadHealthStatusDto>> GetHealthStatusById(int id)
        {
            var healthStatus = await _context.HealthStatuses.FindAsync(id);
            if (healthStatus == null)
            {
                return NotFound();
            }
            var healthStatusDto = _mapper.Map<ReadHealthStatusDto>(healthStatus);
            return Ok(healthStatusDto);
        }
    }
}
