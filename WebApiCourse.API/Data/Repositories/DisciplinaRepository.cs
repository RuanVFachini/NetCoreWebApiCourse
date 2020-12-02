using WebApiCourse.Domain.Models;

namespace WebApiCourse.API.Data.Repositories
{
    public class DisciplinaRepository : Repository<Disciplina>, IDisciplinaRepository
    {
        public DisciplinaRepository(ApplicationContext context) : base(context)
        {
        }
    }
}