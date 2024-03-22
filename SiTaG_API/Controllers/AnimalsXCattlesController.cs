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
    public class AnimalsXCattlesController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public AnimalsXCattlesController(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReadAnimalsXCattlesDto>>> GetAllAnimalsXCattles()
        {
            var animalsXCattles = await _context.AnimalsxCattles.ToListAsync();
            var animalsXCattlesDto = _mapper.Map<List<ReadAnimalsXCattlesDto>>(animalsXCattles);
            return Ok(animalsXCattlesDto);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ReadAnimalsXCattlesDto>> GetAnimalsXCattlesById(int id)
        {
            var animalsXCattles = await _context.AnimalsxCattles.FindAsync(id);
            if (animalsXCattles == null)
            {
                return NotFound();
            }
            var animalsXCattlesDto = _mapper.Map<ReadAnimalsXCattlesDto>(animalsXCattles);
            return Ok(animalsXCattlesDto);
        }
        [HttpPost]
        public async Task<ActionResult> AddAnimalsXCattles(CreateAnimalsXCattlesDto animalsXCattlesCreateDto)
        {
            var animalsXCattles = _mapper.Map<AnimalsxCattles>(animalsXCattlesCreateDto);
            _context.AnimalsxCattles.Add(animalsXCattles); 
            await _context.SaveChangesAsync();
            var animalsXCattlesDto = _mapper.Map<ReadAnimalsXCattlesDto>(animalsXCattles);

            return CreatedAtAction(nameof(GetAnimalsXCattlesById), new { id = animalsXCattlesDto.Id }, animalsXCattlesDto);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAnimalsXCattles(int id, UpdateAnimalsXCattlesDto animalsXCattlesUpdateDto)
        {
            var animalsXCattles = await _context.AnimalsxCattles.FindAsync(id);
            if (animalsXCattles == null)
            {
                return NotFound();
            }
            _mapper.Map(animalsXCattlesUpdateDto, animalsXCattles);
            await _context.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAnimalsXCattles(int id)
        {
            var animalsXCattles = await _context.AnimalsxCattles.FindAsync(id);
            if (animalsXCattles == null)
            {
                return NotFound();
            }
            _context.AnimalsxCattles.Remove(animalsXCattles);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
