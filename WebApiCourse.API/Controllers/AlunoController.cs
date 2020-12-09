using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Annotations;
using WebApiCourse.API.Data;
using WebApiCourse.API.Data.Repositories;
using WebApiCourse.API.DTO;
using WebApiCourse.Domain.Models;

namespace WebApiCourse.API.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoRepository _repository;
        private readonly IMapper _mapper;

        public AlunoController(IAlunoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [SwaggerOperation(Summary = "Get a list of all Alunos")]
        [ProducesResponseType(typeof(IEnumerable<AlunoDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_mapper.Map<IEnumerable<AlunoDTO>>(_repository.ToList()));
        }

        [SwaggerOperation(Summary = "Get a specifique Aluno")]
        [ProducesResponseType(typeof(AlunoDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet("{id:int}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var aluno = _repository.GetById(id);

            if (aluno == null) return NotFound();

            return Ok(_mapper.Map<AlunoDTO>(aluno));
        }

        [SwaggerOperation(Summary = "Create a new Aluno record")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpPost]
        public IActionResult Post([FromBody] AlunoRequestDTO model)
        {
            var aluno = _mapper.Map<Aluno>(model);
            _repository.Add(aluno);
            _repository.SaveChanges();
            return Created(nameof(GetById), model);
        }

        [SwaggerOperation(Summary = "Full Update for specific Aluno record")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpPut("{id:int}")]
        public IActionResult Put([FromRoute] int id, [FromBody] AlunoRequestDTO model)
        {

            var aluno = _repository.GetById(id);

            if (aluno == null) return NotFound();

            _mapper.Map(model, aluno);

            _repository.Update(aluno);
            _repository.SaveChanges();
            
            return NoContent();
        }

        [SwaggerOperation(Summary = "Partial Update for specific Aluno record")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpPatch("{id:int}")]
        public IActionResult Patch([FromRoute] int id, [FromBody] AlunoRequestDTO model)
        {
            var aluno = _repository.GetById(id);

            if (aluno == null) return NotFound();

            _mapper.Map(model, aluno);

            _repository.Update(aluno);
            _repository.SaveChanges();

            return NoContent();
        }
        
        [SwaggerOperation(Summary = "Delete a specific Aluno record")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpDelete("{id:int}")]
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