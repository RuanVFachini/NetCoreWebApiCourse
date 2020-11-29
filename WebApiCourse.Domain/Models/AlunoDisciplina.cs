
namespace WebApiCourse.Domain.Models
{
    public class AlunoDisciplina
    {
        public AlunoDisciplina() { }

        public AlunoDisciplina(int disciplinaId, int alunoId)
        {
            this.DisciplinaId = disciplinaId;
            this.AlunoId = alunoId;
        }

        public int DisciplinaId { get; set; }
        public Disciplina Disciplina { get; set; }
        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }
    }
}
