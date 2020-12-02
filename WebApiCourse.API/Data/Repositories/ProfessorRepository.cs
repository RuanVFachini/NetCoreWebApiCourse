using WebApiCourse.Domain.Models;

namespace WebApiCourse.API.Data.Repositories
{
    public class ProfessorRepository : Repository<Professor>, IProfessorRepository
    {
        public ProfessorRepository(ApplicationContext context) : base(context)
        {
        }
    }
}