using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SiTaG_API.Data;
using SiTaG_API.Entities;

namespace SiTaG_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationController : ControllerBase
    {
        private readonly DataContext _context;
        public ApplicationController(DataContext context)
        {
               _context = context;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAnimalById(int id)
        {
            var animal = await _context.ApplicationMethods.FindAsync(id);

            if (animal == null)
            {
                return NotFound("Aplication not found");
            }
            return Ok(animal);
        }

    }
}
