using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APIBarberGenuine.Data;
using APIBarberGenuine.Models;
using APIBarberGenuine.Models.Dto;
using AutoMapper;
using APIBarberGenuine.Repository.IRepository;

namespace APIBarberGenuine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly IClientRepository _clientRepo;
        private readonly ILogger<ClientsController> _logger;
        private readonly IMapper _mapper;

        public ClientsController(IClientRepository clientRepo, ILogger<ClientsController> logger, IMapper mapper)
        {
            _clientRepo=clientRepo;
            _logger = logger;
            _mapper = mapper;
        }

        // GET: api/Clients
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<ClientDto>>> GetClients()
        {
            _logger.LogInformation("Obtener los clientes");

            var clientList = await _clientRepo.GetAll();

            //Usar esto en la vista Papu -|
            //                            |
            //clientList.Last(); <--------|

            return Ok(_mapper.Map<IEnumerable<ClientDto>>(clientList));
        }

        // GET: api/Clients/5
        [HttpGet("{id:int}",Name="GetClient")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ClientDto>> GetClient(int id)
        {
            if (id == 0)
            {
                _logger.LogError($"Error al traer Estudiante con Id {id}");
                return BadRequest();
            }

            var client = await _clientRepo.Get(s=>s.Id== id);

            if (client == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<ClientDto>(client));
        }

        // PUT: api/Clients/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PutClient(int id, [FromBody] ClientUpdateDto clientUpdateDto)
        {
            if (clientUpdateDto==null||id!=clientUpdateDto.Id)
            {
                return BadRequest();
            }
            Client modelo = _mapper.Map<Client>(clientUpdateDto);
            await _clientRepo.Update(modelo);
            return NoContent();

            //_db.Entry(client).State = EntityState.Modified;

            //try
            //{
            //    await _db.SaveChangesAsync();
            //}
            //catch (DbUpdateConcurrencyException)
            //{
            //    if (!ClientExists(id))
            //    {
            //        return NotFound();
            //    }
            //    else
            //    {
            //        throw;
            //    }
            //}

        }

        // POST: api/Clients
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ClientDto>> AddClient([FromBody]ClientCreateDto clientCreateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (await _clientRepo.Get(s=>s.Name.ToLower()==clientCreateDto.Name.ToLower())!=null)
            {
                ModelState.AddModelError("Nombre ya Existe","El Cliente con ese nombre ya existe");
                return BadRequest(ModelState);
            }
            if (clientCreateDto==null)
            {
                return BadRequest(clientCreateDto);

            }

            Client modelo = _mapper.Map<Client>(clientCreateDto);

           await _clientRepo.Add(modelo);
            return CreatedAtRoute("GetClient", new { id = modelo.Id }, modelo);
        }

        // DELETE: api/Clients/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteClient(int id)
        {
            if (id==0)
            {
                return BadRequest();
            }
            var client = await _clientRepo.Get(s=>s.Id==id);
            if (client == null)
            {
                return NotFound();
            }

            await _clientRepo.Remove(client);

            return NoContent();
        }

        //private bool ClientExists(int id)
        //{
        //    return (_db.Clients?.Any(e => e.Id == id)).GetValueOrDefault();
        //}
    }
}
