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
    public class BirthsController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public BirthsController(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReadBirthDto>>> GetAllBirths()
        {
            var births = await _context.Births.ToListAsync();
            var birthsDto = _mapper.Map<List<ReadBirthDto>>(births);
            return Ok(birthsDto);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ReadBirthDto>> GetBirthById(int id)
        {
            var birth = await _context.Births.FindAsync(id);
            if (birth == null)
            {
                return NotFound();
            }
            var birthDto = _mapper.Map<ReadBirthDto>(birth);
            return Ok(birthDto);
        }
        [HttpPost]
        public async Task<ActionResult> AddBirth(CreateBirthDto birthCreateDto)
        {
            var birth = _mapper.Map<Births>(birthCreateDto);
            _context.Births.Add(birth); 
            await _context.SaveChangesAsync();
            var birthDto = _mapper.Map<ReadBirthDto>(birth);

            return CreatedAtAction(nameof(GetBirthById), new { id = birthDto.Id }, birthDto);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBirth(int id, UpdateBirthDto birthUpdateDto)
        {
            var birth = await _context.Births.FindAsync(id);
            if (birth == null)
            {
                return NotFound();
            }
            _mapper.Map(birthUpdateDto, birth);
            await _context.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBirth(int id)
        {
            var birth = await _context.Births.FindAsync(id);
            if (birth == null)
            {
                return NotFound();
            }
            _context.Births.Remove(birth);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
