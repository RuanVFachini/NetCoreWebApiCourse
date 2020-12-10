using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiCourse.API.Config;
using WebApiCourse.API.Helpers;
using WebApiCourse.Domain.Models;

namespace WebApiCourse.API.Data.Repositories
{
    public interface IAlunoRepository : IRepository<Aluno>
    {
        Aluno GetByDisciplina(int disciplinaId, bool incluirProfessor);
        ICollection<Aluno> FindAll();
        Task<PageList<Aluno>> FindAllAsync(PageParams pageParams);
    }
}