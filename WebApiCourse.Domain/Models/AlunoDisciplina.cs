
using System;

namespace WebApiCourse.Domain.Models
{
    public class AlunoDisciplina
    {
        public AlunoDisciplina() { }

        public AlunoDisciplina(int disciplinaId, int alunoId)
        {
            DisciplinaId = disciplinaId;
            AlunoId = alunoId;
        }

        public DateTime DataIni { get; set; } = DateTime.Now;
        public DateTime? DataFim { get; set; } = null;
        public int DisciplinaId { get; set; }
        public Disciplina Disciplina { get; set; }
        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }
        public decimal? Nota { get; set; } = null;
    }
}
