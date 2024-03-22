using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SiTaG_API.Data;
using SiTaG_API.DTOs;
using AutoMapper;
namespace SiTaG_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceTypeController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public ServiceTypeController(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReadServiceTypeDto>>> GetAllServiceTypes()
        {
            var serviceTypes = await _context.ServiceTypes.ToListAsync();
            var serviceTypesDto = _mapper.Map<List<ReadServiceTypeDto>>(serviceTypes);
            return Ok(serviceTypesDto);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ReadServiceTypeDto>> GetServiceTypeById(int id)
        {
            var serviceType = await _context.ServiceTypes.FindAsync(id);
            if (serviceType == null)
            {
                return NotFound();
            }
            var serviceTypeDto = _mapper.Map<ReadServiceTypeDto>(serviceType);
            return Ok(serviceTypeDto);
        }
    }
}
