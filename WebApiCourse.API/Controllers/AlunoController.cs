using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiCourse.API.Data;
using WebApiCourse.API.Data.Repositories;
using WebApiCourse.Domain.Models;

namespace WebApiCourse.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoRepository _repository;

        public AlunoController(IAlunoRepository repository)
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
            var aluno = _repository.GetById(id);

            if (aluno == null) return NotFound();

            return Ok(aluno);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpPost]
        public IActionResult Post([FromBody] Aluno model)
        {
            _repository.Add(model);
            _repository.SaveChanges();
            return Created(nameof(GetById), model);
        }

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpPut("{id:int}")]
        public IActionResult Put([FromRoute] int id, [FromBody] Aluno model)
        {
            var aluno = _repository.GetById(id);

            if (aluno == null) return NotFound();

            _repository.Update(model);
            _repository.SaveChanges();
            
            return NoContent();
        }

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpPatch("{id:int}")]
        public IActionResult Patch([FromRoute] int id, [FromBody] Aluno model)
        {
            var aluno = _repository.GetById(id);

            if (aluno == null) return NotFound();

            _repository.Update(model);
            _repository.SaveChanges();

            return NoContent();
        }
        
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpDelete("{id}:int")]
        public IActionResult Delete([FromRoute] int id)
        {
            var aluno = _repository.GetById(id);
            
            if (aluno == null) return NotFound();
            
            _repository.Remove(aluno);
            _repository.SaveChanges();
            
            return NoContent();
        }

    }
}