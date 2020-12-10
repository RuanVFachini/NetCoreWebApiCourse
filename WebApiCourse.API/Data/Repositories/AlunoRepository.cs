using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiCourse.API.Config;
using WebApiCourse.API.Helpers;
using WebApiCourse.Domain.Models;

namespace WebApiCourse.API.Data.Repositories
{
    public class AlunoRepository : Repository<Aluno>, IAlunoRepository
    {
        public AlunoRepository(ApplicationContext context) : base(context)
        {
        }

        public ICollection<Aluno> FindAll()
        {
            return _context.Set<Aluno>().Include(x => x.AlunoDisciplinas).ToList();
        }

        public async Task<PageList<Aluno>> FindAllAsync(PageParams pageParams)
        {
            var query = _context.Set<Aluno>().Include(x => x.AlunoDisciplinas).AsQueryable<Aluno>();
            return await PageList<Aluno>.CreateAsync(query, pageParams.PageNumber, pageParams.PageSize);
        }

        public Aluno GetByDisciplina(int disciplinaId, bool incluirProfessor)
        {
            var query = _context.Aluno.AsQueryable();

            if (incluirProfessor)
            {
                query = query.Include(a => a.AlunoDisciplinas)
                .ThenInclude(ad => ad.Disciplina)
                .ThenInclude(d => d.Professor);
            }

            query = query.OrderBy(a => a.Id)
                        .Where(aluno => aluno.AlunoDisciplinas.Any(ad => ad.DisciplinaId == disciplinaId));

            return query.FirstOrDefault();
        }

        public override Aluno GetById(int id)
        {
            return _context.Aluno.AsQueryable().Include(x => x.AlunoDisciplinas).FirstOrDefault();
        }
    }
}