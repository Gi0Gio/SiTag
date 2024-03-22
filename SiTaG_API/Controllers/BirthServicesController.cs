using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SiTaG_API.Data;
using SiTaG_API.Entities;
using SiTaG_API.DTOs;
using AutoMapper;

namespace SiTaG_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BirthServicesController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public BirthServicesController(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReadBirthServicesDto>>> GetAllBirthServices()
        {
            var birthServices = await _context.BirthServices.ToListAsync();
            var birthServicesDto = _mapper.Map<List<ReadBirthServicesDto>>(birthServices);
            return Ok(birthServicesDto);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ReadBirthServicesDto>> GetBirthServiceById(int id)
        {
            var birthService = await _context.BirthServices.FindAsync(id);
            if (birthService == null)
            {
                return NotFound();
            }
            var birthServiceDto = _mapper.Map<ReadBirthServicesDto>(birthService);
            return Ok(birthServiceDto);
        }
    }
}