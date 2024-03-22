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
    public class DivisionsXLotsController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public DivisionsXLotsController(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReadDivisionsXLotsDto>>> GetAllDivisionsXLots()
        {
            var divisionsXLots = await _context.DivisionxLots.ToListAsync();
            var divisionsXLotsDto = _mapper.Map<List<ReadDivisionsXLotsDto>>(divisionsXLots);
            return Ok(divisionsXLotsDto);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ReadDivisionsXLotsDto>> GetDivisionXLotById(int id)
        {
            var divisionXLot = await _context.DivisionxLots.FindAsync(id);
            if (divisionXLot == null)
            {
                return NotFound();
            }
            var divisionXLotDto = _mapper.Map<ReadDivisionsXLotsDto>(divisionXLot);
            return Ok(divisionXLotDto);
        }
        [HttpPost]
        public async Task<ActionResult> AddDivisionXLot(CreateDivisionsXLotsDto createDivisionXLotDto)
        {
            var divisionXLot = _mapper.Map<DivisionxLots>(createDivisionXLotDto);
            _context.DivisionxLots.Add(divisionXLot); 
            await _context.SaveChangesAsync();
            var divisionXLotDto = _mapper.Map<ReadDivisionsXLotsDto>(divisionXLot);

            return CreatedAtAction(nameof(GetDivisionXLotById), new { id = divisionXLotDto.Id }, divisionXLotDto);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDivisionXLot(int id, UpdateDivisionsXLotsDto updateDivisionXLotDto)
        {
            var divisionXLot = await _context.DivisionxLots.FindAsync(id);
            if (divisionXLot == null)
            {
                return NotFound();
            }
            _mapper.Map(updateDivisionXLotDto, divisionXLot);
            await _context.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDivisionXLot(int id)
        {
            var divisionXLot = await _context.DivisionxLots.FindAsync(id);
            if (divisionXLot == null)
            {
                return NotFound();
            }
            _context.DivisionxLots.Remove(divisionXLot);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
