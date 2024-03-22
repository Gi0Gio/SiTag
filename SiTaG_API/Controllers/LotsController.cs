using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SiTaG_API.Data;
using SiTaG_API.DTOs;
using SiTaG_API.Entities;
using AutoMapper;

namespace SiTaG_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LotsController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public LotsController(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReadLotsDto>>> GetAllLots()
        {
            var lots = await _context.Lots.ToListAsync();
            var lotsDto = _mapper.Map<List<ReadLotsDto>>(lots);
            return Ok(lotsDto);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ReadLotsDto>> GetLotById(int id)
        {
            var lot = await _context.Lots.FindAsync(id);
            if (lot == null)
            {
                return NotFound();
            }
            var lotDto = _mapper.Map<ReadLotsDto>(lot);
            return Ok(lotDto);
        }
        [HttpPost]
        public async Task<ActionResult> AddLot(CreateLotsDto createLotsDto)
        {
            var lot = _mapper.Map<Lots>(createLotsDto);
            _context.Lots.Add(lot);
            await _context.SaveChangesAsync();
            var lotDto = _mapper.Map<ReadLotsDto>(lot);

            return CreatedAtAction(nameof(GetLotById), new { id = lotDto.Id }, lotDto);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateLot(int id, UpdateLotsDto updateLotsDto)
        {
            var lot = await _context.Lots.FindAsync(id);
            if (lot == null)
            {
                return NotFound();
            }
            _mapper.Map(updateLotsDto, lot);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
