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
    public class AnimalsController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public AnimalsController(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReadAnimalDto>>> GetAllAnimals()
        {
            var animals = await _context.Animals.ToListAsync();
            var animalsDto = _mapper.Map<List<ReadAnimalDto>>(animals);
            return Ok(animalsDto);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ReadAnimalDto>> GetAnimalById(int id)
        {
            var animal = await _context.Animals.FindAsync(id);
            if (animal == null)
            {
                return NotFound();
            }
            var animalDto = _mapper.Map<ReadAnimalDto>(animal);
            return Ok(animalDto);
        }   
        [HttpPost]
        public async Task<ActionResult> AddAnimal(AnimalCreateDto animalCreateDto)
        {
            var animal = _mapper.Map<Animals>(animalCreateDto);
            _context.Animals.Add(animal); 
            await _context.SaveChangesAsync();
            var animalDto = _mapper.Map<ReadAnimalDto>(animal);

            return CreatedAtAction(nameof(GetAnimalById), new { id = animalDto.Id }, animalDto);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAnimal(int id, AnimalUpdateDto animalUpdateDto)
        {
            var animal = await _context.Animals.FindAsync(id);
            if (animal == null)
            {
                return NotFound();
            }
            _mapper.Map(animalUpdateDto, animal);
            await _context.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAnimal(int id)
        {
            var animal = await _context.Animals.FindAsync(id);
            if (animal == null)
            {
                return NotFound();
            }
            _context.Animals.Remove(animal);
            await _context.SaveChangesAsync();
            return NoContent();
        }   

    }
}
