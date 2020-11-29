using Microsoft.EntityFrameworkCore;
using WebApiCourse.Domain.Models;

namespace WebApiCourse.API.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Professor> Professor { get; set; }
        public DbSet<Disciplina> Disciplina { get; set; }
        public DbSet<AlunoDisciplina> AlunoDisciplina { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AlunoDisciplina>()
                .HasKey(ad => new { ad.AlunoId, ad.DisciplinaId });

            builder.SeedingDatabase();
        }
    }
}