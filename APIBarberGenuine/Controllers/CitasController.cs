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
using Microsoft.AspNetCore.JsonPatch;

namespace APIBarberGenuine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitasController : ControllerBase
    {
        private readonly ICitaRepository _citaRepo;
        private readonly ILogger<CitasController> _logger;
        private readonly IMapper _mapper;

        public CitasController(ICitaRepository citaRepo, ILogger<CitasController> logger, IMapper mapper)
        {
            _citaRepo=citaRepo;
            _logger = logger;
            _mapper = mapper;
        }

        // GET: api/Citas
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<CitaDto>>> GetCitas()
        {
            _logger.LogInformation("Obtener las citas");

            var citaList = await _citaRepo.GetAll();
          
            return Ok(_mapper.Map<IEnumerable<CitaDto>>(citaList));
        }

        // GET: api/Citas/5
        [HttpGet("{id:int}", Name = "GetCita")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<CitaDto>> GetCita(int id)
        {
          if (id==0)
          {
                _logger.LogError($"Error al traer cita con Id {id}");
                return BadRequest();
          }
            //var cita = await _db.Citas.Where(a => a.Id == id).Include(a => a.Client).
            //    ThenInclude(x=>x.Citas).FirstOrDefaultAsync();

            var cita = await _citaRepo.Get(s=>s.Id==id);


            if (cita == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<CitaDto>(cita));
        }

        // POST: api/Citas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<CitaDto>> AddCita([FromBody]CitaCreateDto citaCreateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (await _citaRepo.Get(s=>s.Dates.ToString().ToLower()==citaCreateDto.Dates.ToString().ToLower())!=null)
            {
                ModelState.AddModelError("Fecha ya existente", "¡Esa fecha ya esta oucupada!");
                return BadRequest(ModelState);
            }
            
            if (citaCreateDto==null)
            {
                return BadRequest(citaCreateDto);
            }

            Cita modelo = _mapper.Map<Cita>(citaCreateDto);

            await _citaRepo.Add(modelo);
            return CreatedAtRoute("GetCita", new { id = modelo.Id }, modelo);

            //  if (await _db.Citas.FirstOrDefaultAsync(s=>s.) != null)
            //{
            //    return Problem("Entity set 'BarberGenuineContext.Citas'  is null.");
            //}

        }

        // PUT: api/Citas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateCita(int id, [FromBody] CitaUpdateDto citaUpdateDto)
        {
            if (citaUpdateDto == null || id!=citaUpdateDto.Id)
            {
                return BadRequest();
            }

            Cita modelo = _mapper.Map<Cita>(citaUpdateDto);

            await _citaRepo.Update(modelo);
            return NoContent();
        }

        // PATCH: api/Citas/5
        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialCita(int id, JsonPatchDocument<CitaUpdateDto> patchDto)
        {
            if (patchDto == null || id == 0)
            {
                return BadRequest();
            }

            var cita = await _citaRepo.Get(s=>s.Id==id,tracked:false);

            CitaUpdateDto citaUpdateDto = _mapper.Map<CitaUpdateDto>(cita);

            if (cita==null)
            {
                return BadRequest();
            }

            patchDto.ApplyTo(citaUpdateDto, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Cita modelo = _mapper.Map<Cita>(citaUpdateDto);
           await _citaRepo.Update(modelo);
            return NoContent();

        }

        // DELETE: api/Citas/5
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteCita(int id)
        {
            if (id==0)
            {
                return BadRequest();
            }
            var cita = await _citaRepo.Get(s=>s.Id ==id);

            if (cita == null)
            {
                return NotFound();
            }

            await _citaRepo.Remove(cita);
            return NoContent();
        }

        //private bool CitaExists(int id)
        //{
        //    return (_db.Citas?.Any(e => e.Id == id)).GetValueOrDefault();
        //}
    }
}
