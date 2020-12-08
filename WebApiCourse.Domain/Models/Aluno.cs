using System;
using System.Collections.Generic;

namespace WebApiCourse.Domain.Models
{
    public class Aluno : BaseEntity
    {
        public Aluno() { }

        public Aluno(int id, string nome, string sobrenome, string telefone, 
                     string matricula, DateTime dataNasc)
        {
            this.Id = id;
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Telefone = telefone;
            this.Matricula = matricula;
            this.DataNasc = dataNasc;

        }

        public string Nome { get; set; }
        public string Matricula { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNasc { get; set; }
        public DateTime DataInicio { get; set; } = DateTime.Now;
        public DateTime? DataFim { get; set; } = null;
        public bool IsActive { get; set; } = true;

        public IEnumerable<AlunoDisciplina> AlunoDisciplinas { get; set; }
    }
}
