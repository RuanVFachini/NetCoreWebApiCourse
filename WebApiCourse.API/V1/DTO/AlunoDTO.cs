using System;
using System.Collections.Generic;
using Swashbuckle.AspNetCore.Annotations;
using WebApiCourse.Domain.Models;

namespace WebApiCourse.API.V1.DTO
{
    public class AlunoDTO
    {
        [SwaggerSchemaAttribute("Aluno name")]
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public string Telefone { get; set; }
        public int Idade {get; set;}
        public DateTime DataNasc { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public bool IsActive { get; set; }
        public IEnumerable<AlunoDisciplinaDTO> AlunoDisciplinas { get; set; }
    }
}