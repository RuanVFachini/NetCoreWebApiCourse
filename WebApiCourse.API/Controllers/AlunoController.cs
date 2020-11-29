using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiCourse.API.Data;
using WebApiCourse.Domain.Models;

namespace WebApiCourse.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public AlunoController(ApplicationContext context)
        {
            _context = context;
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Aluno.ToList());
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet("{id:int}")]
        public IActionResult Get([FromRoute] int id)
        {
            var aluno = _context.Aluno.FirstOrDefault(x => x.Id == id);

            if (aluno == null) return NotFound();

            return Ok(aluno);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpPost]
        public IActionResult Post([FromBody] Aluno model)
        {
            return Created("", model);
        }

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpPut("{id:int}")]
        public IActionResult Post([FromRoute] int id, [FromBody] Aluno model)
        {
            return NoContent();
        }

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpPatch("{id:int}")]
        public IActionResult Patch([FromRoute] int id, [FromBody] Aluno model)
        {
            return NoContent();
        }
        
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpDelete("{id}:int")]
        public IActionResult Delete([FromRoute] int id)
        {
            return NoContent();
        }

    }
}