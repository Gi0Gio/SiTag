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
    public class ProductsController : Controller
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public ProductsController(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReadProductDto>>> GetAllProducts()
        {
            var products = await _context.Products.ToListAsync();
            var productsDto = _mapper.Map<List<ReadProductDto>>(products);
            return Ok(productsDto);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ReadProductDto>> GetProductById(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if(product == null)
            {
                return NotFound();
            }
            var productDto = _mapper.Map<ReadProductDto>(product);
            return Ok(productDto);
        }
        [HttpPost]
        public async Task<ActionResult> AddProduct(CreateProductDto createProductDto)
        {
            var product = _mapper.Map<Products>(createProductDto);
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            var productDto = _mapper.Map<ReadProductDto>(product);

            return CreatedAtAction(nameof(GetProductById), new { id = productDto.Id }, productDto);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, UpdateProductDto updateProductDto)
        {
            var product = await _context.Products.FindAsync(id);
            if(product == null)
            {
                return NotFound();
            }
            _mapper.Map(updateProductDto, product);
            await _context.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if(product == null)
            {
                return NotFound();
            }
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return NoContent();
        }

    }
}
