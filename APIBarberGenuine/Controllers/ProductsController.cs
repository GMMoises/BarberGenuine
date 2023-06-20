using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APIBarberGenuine.Data;
using APIBarberGenuine.Models;
using APIBarberGenuine.Repository.IRepository;
using AutoMapper;
using APIBarberGenuine.Models.Dto;

namespace APIBarberGenuine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<BarberGenuineContext> _logger;
        private readonly IProductRepository _productRepo;
        private readonly IMapper _mapper;

        public ProductsController(IProductRepository productRepo, ILogger<BarberGenuineContext> logger,IMapper mapper)
        {
            _productRepo = productRepo;
            _logger = logger;
            _mapper = mapper;
        }

        // GET: api/Products
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetProducts()
        {
            _logger.LogInformation("Obtener los Productos");

            var productList=await _productRepo.GetAll();

            return Ok(_mapper.Map<IEnumerable<ProductDto>>(productList));
        }

        // GET: api/Products/5
        [HttpGet("{id:int}", Name = "GetProduct")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ProductDto>> GetProduct(int id)
        {
            if (id==0)
            {
                _logger.LogError($"Error al traer producto con id {id}");
                return BadRequest();
            }
            var product = await _productRepo.Get(s => s.Id == id);

            if (product==null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<ProductDto>(product));
        }

        // POST: api/Products
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ProductDto>> PostProduct([FromBody]ProductCreateDto productCreateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (productCreateDto==null)
            {
                return BadRequest(productCreateDto);
            }

            Product modelo = _mapper.Map<Product>(productCreateDto);
            await _productRepo.Add(modelo);
            return CreatedAtRoute("GetProduct", new { id = modelo.Id },modelo);
        }

        // DELETE: api/Products/5
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var product = await _productRepo.Get(s=>s.Id==id);

            if (product==null)
            {
                return NotFound();
            }

            await _productRepo.Remove(product);
            return NoContent();
        }

        // PUT: api/Products/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateProduct(int id, [FromBody]ProductUpdateDto productUpdateDto)
        {
            if (productUpdateDto==null||id!=productUpdateDto.Id)
            {
                return BadRequest();
            }

            Product modelo = _mapper.Map<Product>(productUpdateDto);
            await _productRepo.Update(modelo);
            return NoContent();

        }

        

        //private bool ProductExists(int id)
        //{
        //    return (_context.Products?.Any(e => e.Id == id)).GetValueOrDefault();
        //}
    }
}
