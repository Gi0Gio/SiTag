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
    public class DivisionsController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public DivisionsController(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReadDivisionDto>>> GetAllDivisions()
        {
            var divisions = await _context.Divisions.ToListAsync();
            var divisionsDto = _mapper.Map<List<ReadDivisionDto>>(divisions);
            return Ok(divisionsDto);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ReadDivisionDto>> GetDivisionById(int id)
        {
            var division = await _context.Divisions.FindAsync(id);
            if (division == null)
            {
                return NotFound();
            }
            var divisionDto = _mapper.Map<ReadDivisionDto>(division);
            return Ok(divisionDto);
        }
        [HttpPost]
        public async Task<ActionResult> AddDivision(CreateDivisionDto createDivisionDto)
        {
            var division = _mapper.Map<Divisions>(createDivisionDto);
            _context.Divisions.Add(division); 
            await _context.SaveChangesAsync();
            var divisionDto = _mapper.Map<ReadDivisionDto>(division);

            return CreatedAtAction(nameof(GetDivisionById), new { id = divisionDto.Id }, divisionDto);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDivision(int id, UpdateDivisionDto updateDivisionDto)
        {
            var division = await _context.Divisions.FindAsync(id);
            if (division == null)
            {
                return NotFound();
            }
            _mapper.Map(updateDivisionDto, division);
            await _context.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDivision(int id)
        {
            var division = await _context.Divisions.FindAsync(id);
            if (division == null)
            {
                return NotFound();
            }
            _context.Divisions.Remove(division);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
