using System.Linq;
using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiCourse.API.Data;
using WebApiCourse.API.Data.Repositories;
using WebApiCourse.Domain.Models;

namespace WebApiCourse.API.V2.Controllers
{
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class DisciplinaController : ControllerBase
    {
        private readonly IDisciplinaRepository _repository;

        public DisciplinaController(IDisciplinaRepository repository)
        {
            _repository = repository;
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.ToList());
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet("{id:int}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var disciplina = _repository.GetById(id);

            if (disciplina == null) return NotFound();

            return Ok(disciplina);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpPost]
        public IActionResult Post([FromBody] Disciplina model)
        {
            _repository.Add(model);
            _repository.SaveChanges();
            return Created(nameof(GetById), model);
        }

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpPut("{id:int}")]
        public IActionResult Put([FromRoute] int id, [FromBody] Disciplina model)
        {
            var disciplina = _repository.GetById(id);

            if (disciplina == null) return NotFound();

            _repository.Update(model);
            _repository.SaveChanges();
            
            return NoContent();
        }

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpPatch("{id:int}")]
        public IActionResult Patch([FromRoute] int id, [FromBody] Disciplina model)
        {
            var disciplina = _repository.GetById(id);

            if (disciplina == null) return NotFound();

            _repository.Update(model);
            _repository.SaveChanges();
            
            return NoContent();
        }
        
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpDelete("{id:int}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var disciplina = _repository.GetById(id);
            
            if (disciplina == null) return NotFound();
            
            _repository.Remove(disciplina);
            _repository.SaveChanges();
            
            return NoContent();
        }
    }
    
}