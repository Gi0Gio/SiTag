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
    public class CattleController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public CattleController(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReadCattleDto>>> GetAllCattles()
        {
            var cattles = await _context.Cattles.ToListAsync();
            var cattlesDto = _mapper.Map<List<ReadCattleDto>>(cattles);
            return Ok(cattlesDto);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ReadCattleDto>> GetCattleById(int id)
        {
            var cattle = await _context.Cattles.FindAsync(id);
            if (cattle == null)
            {
                return NotFound();
            }
            var cattleDto = _mapper.Map<ReadCattleDto>(cattle);
            return Ok(cattleDto);
        }
        [HttpPost]
        public async Task<ActionResult> AddCattle(CreateCattleDto cattleCreateDto)
        {
            var cattle = _mapper.Map<Cattles>(cattleCreateDto);
            _context.Cattles.Add(cattle); 
            await _context.SaveChangesAsync();
            var cattleDto = _mapper.Map<ReadCattleDto>(cattle);

            return CreatedAtAction(nameof(GetCattleById), new { id = cattleDto.Id }, cattleDto);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCattle(int id, UpdateCattleDto cattleUpdateDto)
        {
            var cattle = await _context.Cattles.FindAsync(id);
            if (cattle == null)
            {
                return NotFound();
            }
            _mapper.Map(cattleUpdateDto, cattle);
            await _context.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCattle(int id)
        {
            var cattle = await _context.Cattles.FindAsync(id);
            if (cattle == null)
            {
                return NotFound();
            }
            _context.Cattles.Remove(cattle);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
