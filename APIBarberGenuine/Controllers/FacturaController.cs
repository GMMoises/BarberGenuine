using APIBarberGenuine.Models;
using APIBarberGenuine.Models.Dto;
using APIBarberGenuine.Repository.IRepository;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIBarberGenuine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturaController : ControllerBase
    {
        private readonly IFacturaRepository _facturaRepo;
        private readonly ILogger<FacturaController> _logger;
        private readonly IMapper _mapper;

        public FacturaController(IFacturaRepository facturaRepo, ILogger<FacturaController> logger, IMapper mapper)
        {
            _facturaRepo = facturaRepo;
            _logger = logger;
            _mapper = mapper;
        }

        //Get
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<FacturaDto>>> GetFacturas()
        {
            _logger.LogInformation("Obtener las facturas");

            var clientList = await _facturaRepo.GetAll();

            return Ok(_mapper.Map<IEnumerable<FacturaDto>>(clientList));
        }

        //Get
        [HttpGet("{id:int}", Name = "GetFactura")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<FacturaDto>> GetFactura(int id)
        {
            if (id == 0)
            {
                _logger.LogError($"Error al traer Factura con Id {id}");
                return BadRequest();
            }

            var client = await _facturaRepo.Get(s => s.Id == id);

            if (client == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<FacturaDto>(client));
        }

        //Put
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PutFatura(int id, [FromBody] FacturaUpdateDto facturaUpdateDto)
        {
            if (facturaUpdateDto == null || id != facturaUpdateDto.Id)
            {
                return BadRequest();
            }
            Factura modelo = _mapper.Map<Factura>(facturaUpdateDto);
            await _facturaRepo.Update(modelo);
            return NoContent();
        }

        //Post
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<FacturaDto>> AddFactura([FromBody] FacturaCreateDto facturaCreateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (facturaCreateDto == null)
            {
                return BadRequest(facturaCreateDto);

            }

            Factura modelo = _mapper.Map<Factura>(facturaCreateDto);

            await _facturaRepo.Add(modelo);
            return CreatedAtRoute("GetFactura", new { id = modelo.Id }, modelo);
        }

        //Deleted
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteFactura(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var factura = await _facturaRepo.Get(s => s.Id == id);
            if (factura == null)
            {
                return NotFound();
            }

            await _facturaRepo.Remove(factura);

            return NoContent();
        }

    }
}
