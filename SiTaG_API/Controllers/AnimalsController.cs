using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SiTaG_API.Data;
using SiTaG_API.Entities;

namespace SiTaG_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private readonly DataContext _context;

        public AnimalsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAnimals()
        {
            var animals = await _context.Animals.ToListAsync();
            return Ok(animals);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAnimalById(int id)
        {
            var animal = await _context.Animals.FindAsync(id);

            if (animal == null)
            {
                return NotFound("Animal not found");
            }
            return Ok(animal);
        }
        [HttpPost]
        public async Task<ActionResult<List<Animals>>> AddAnimal(Animals animal)
        {
            _context.Animals.Add(animal);
            await _context.SaveChangesAsync();

            return Ok(await _context.Animals.ToListAsync());
        }
        [HttpPut]
        public async Task<ActionResult<List<Animals>>> UpdateAnimal(Animals updatedAnimal)
        {
            var animalToUpdate = await _context.Animals.FindAsync(updatedAnimal.Id);
            if (animalToUpdate == null)
            {
                return NotFound("Animal not found");
            }
            animalToUpdate.Identifier = updatedAnimal.Identifier;
            animalToUpdate.Name = updatedAnimal.Name;
            animalToUpdate.Description = updatedAnimal.Description;

            await _context.SaveChangesAsync();

            return Ok(await _context.Animals.ToListAsync());
        }
        [HttpDelete]
        public async Task<ActionResult<List<Animals>>> DeleteAnimal(int id)
        {
            var animalToDelete = await _context.Animals.FindAsync(id);
            if (animalToDelete == null)
            {
                return NotFound("Animal not found");
            }
            _context.Animals.Remove(animalToDelete);
            await _context.SaveChangesAsync();

            return Ok(await _context.Animals.ToListAsync());
        }

    }
}
