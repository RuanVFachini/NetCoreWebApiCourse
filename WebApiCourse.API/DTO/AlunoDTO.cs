using System;
using System.Collections.Generic;
using WebApiCourse.Domain.Models;

namespace WebApiCourse.API.DTO
{
    public class AlunoDTO
    {
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public string Telefone { get; set; }
        public int Idade {get; set;}
        public DateTime DataNasc { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public bool IsActive { get; set; }
        public IEnumerable<AlunoDisciplina> AlunoDisciplinas { get; set; }
    }
}