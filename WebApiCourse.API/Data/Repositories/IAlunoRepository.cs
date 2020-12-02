using WebApiCourse.Domain.Models;

namespace WebApiCourse.API.Data.Repositories
{
    public interface IAlunoRepository : IRepository<Aluno>
    {
        Aluno GetByDisciplina(int disciplinaId, bool incluirProfessor);
    }
}