using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiCourse.Domain.Models;

namespace WebApiCourse.API.Data.Repositories
{
    public interface IAlunoRepository : IRepository<Aluno>
    {
        Aluno GetByDisciplina(int disciplinaId, bool incluirProfessor);
        IEnumerable<Aluno> FindAll();
        Task<IEnumerable<Aluno>> FindAllAsync();
    }
}