using System;
using System.Collections.Generic;

namespace WebApiCourse.Domain.Models
{
    public class Professor : BaseEntity
    {
        public Professor() { }

        public Professor(int id, string nome, string sobrenome, string telefone, string registro)
        {
            this.Id = id;
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Registro = registro;
            this.Telefone = telefone;
        }
        
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public string Registro { get; set; }
        public DateTime DataInicio { get; set; } = DateTime.Now;
        public DateTime? DataFim { get; set; } = null;
        public bool IsActive { get; set; } = true;
        public IEnumerable<Disciplina> Disciplinas { get; set; }
    }
}
