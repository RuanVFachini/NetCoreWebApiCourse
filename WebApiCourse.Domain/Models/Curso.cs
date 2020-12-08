using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiCourse.Domain.Models
{
    public class Curso : BaseEntity
    {
        public Curso() {}

        public Curso(int id, string nome, IEnumerable<Disciplina> disciplinas)
        {
            Id = id;
            Nome = nome;
            Disciplinas = disciplinas;
        }

        public string Nome { get; set; }
        public IEnumerable<Disciplina> Disciplinas { get; set; }

    }
}
