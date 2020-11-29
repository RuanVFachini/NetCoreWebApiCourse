using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiCourse.Domain.Models;

namespace WebApiCourse.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DisciplinaController : ControllerBase
    {
        public DisciplinaController()
        {
            
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet("{id:int}")]
        public IActionResult Get([FromRoute] int id)
        {
            return Ok();
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpPost]
        public IActionResult Post([FromBody] Disciplina model)
        {
            return Created("", model);
        }

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpPut("{id:int}")]
        public IActionResult Post([FromRoute] int id, [FromBody] Disciplina model)
        {
            return NoContent();
        }

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpPut("{id:int}")]
        public IActionResult Patch([FromRoute] int id, [FromBody] Disciplina model)
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