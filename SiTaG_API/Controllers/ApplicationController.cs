using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SiTaG_API.Data;
using SiTaG_API.DTOs;

namespace SiTaG_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public ApplicationController(DataContext context, IMapper mapper)
        {
               _context = context;
                _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReadApplicationDto>>> GetAllApplications()
        {
            var applications = await _context.ApplicationMethods.ToListAsync();
            var applicationsDto = _mapper.Map<List<ReadApplicationDto>>(applications);
            return Ok(applicationsDto);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ReadApplicationDto>> GetApplicationById(int id)
        {
            var application = await _context.ApplicationMethods.FindAsync(id);
            if (application == null)
            {
                return NotFound();
            }
            var applicationDto = _mapper.Map<ReadApplicationDto>(application);
            return Ok(applicationDto);
        }

    }
}
