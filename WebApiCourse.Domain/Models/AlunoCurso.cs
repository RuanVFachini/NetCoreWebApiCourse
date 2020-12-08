using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiCourse.Domain.Models
{
    public class AlunoCurso : BaseEntity
    {
        public AlunoCurso() { }

        public AlunoCurso(int cursoId, int alunoId)
        {
            this.CursoId = cursoId;
            this.AlunoId = alunoId;
        }

        public DateTime DataIni { get; set; } = DateTime.Now;
        public DateTime? DataFim { get; set; } = null;
        public int CursoId { get; set; }
        public Curso Curso { get; set; }
        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }
    }
}
