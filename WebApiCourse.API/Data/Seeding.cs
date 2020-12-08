using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WebApiCourse.Domain.Models;

namespace WebApiCourse.API.Data
{
    public static class Seeding
    {
        public static ModelBuilder SeedingDatabase(this ModelBuilder builder)
        {
            builder.Entity<Professor>()
                .HasData(new List<Professor>(){
                    new Professor(1, "Lauro", "Oliveira", "", ""),
                    new Professor(2, "Roberto", "Soares", "", ""),
                    new Professor(3, "Ronaldo", "Marconi", "", ""),
                    new Professor(4, "Rodrigo","Carvalho", "", ""),
                    new Professor(5, "Alexandre", "Montanha", "", ""),
                });
            
            builder.Entity<Curso>()
                .HasData(new List<Curso>{
                    new Curso(1, "Tecnologia da informação",  new List<Disciplina>() {}),
                    new Curso(2, "Sistemas de Informação",  new List<Disciplina>() {}),
                    new Curso(3, "Ciência da Computação",  new List<Disciplina>() {}),
                });

            builder.Entity<Disciplina>()
                .HasData(new List<Disciplina>{
                    new Disciplina(1, "Matemática", 1, 1),
                    new Disciplina(2, "Matemática", 1, 2),
                    new Disciplina(3, "Matemática", 1, 3),
                    new Disciplina(4, "Português", 3, 1),
                    new Disciplina(5, "Português", 3, 3),
                    new Disciplina(6, "Inglês", 4, 1),
                    new Disciplina(7, "Inglês", 4, 3),
                    new Disciplina(8, "Programação", 5, 1),
                    new Disciplina(9, "Programação", 5, 2),
                    new Disciplina(10, "Programação", 5, 3)
                });
            
            builder.Entity<Aluno>()
                .HasData(new List<Aluno>(){
                    new Aluno(1, "Marta", "Kent", "33225555", "ADBC254845", DateTime.Parse("05/08/2005")),
                    new Aluno(2, "Paula", "Isabela", "3354288", "ADBC254846", DateTime.Parse("25/07/2000")),
                    new Aluno(3, "Laura", "Antonia", "55668899", "ADBC254847", DateTime.Parse("05/08/2002")),
                    new Aluno(4, "Luiza", "Maria", "6565659", "ADBC254848", DateTime.Parse("09/08/2005")),
                    new Aluno(5, "Lucas", "Machado", "565685415", "ADBC254849", DateTime.Parse("03/01/2002")),
                    new Aluno(6, "Pedro", "Alvares", "456454545", "ADBC254850", DateTime.Parse("12/03/2005")),
                    new Aluno(7, "Paulo", "José", "9874512", "ADBC254851", DateTime.Parse("17/06/2000"))
                });

            builder.Entity<AlunoDisciplina>()
                .HasData(new List<AlunoDisciplina>() {
                    new AlunoDisciplina() {AlunoId = 1, DisciplinaId = 2 },
                    new AlunoDisciplina() {AlunoId = 1, DisciplinaId = 4 },
                    new AlunoDisciplina() {AlunoId = 1, DisciplinaId = 5 },
                    new AlunoDisciplina() {AlunoId = 2, DisciplinaId = 1 },
                    new AlunoDisciplina() {AlunoId = 2, DisciplinaId = 2 },
                    new AlunoDisciplina() {AlunoId = 2, DisciplinaId = 5 },
                    new AlunoDisciplina() {AlunoId = 3, DisciplinaId = 1 },
                    new AlunoDisciplina() {AlunoId = 3, DisciplinaId = 2 },
                    new AlunoDisciplina() {AlunoId = 3, DisciplinaId = 3 },
                    new AlunoDisciplina() {AlunoId = 4, DisciplinaId = 1 },
                    new AlunoDisciplina() {AlunoId = 4, DisciplinaId = 4 },
                    new AlunoDisciplina() {AlunoId = 4, DisciplinaId = 5 },
                    new AlunoDisciplina() {AlunoId = 5, DisciplinaId = 4 },
                    new AlunoDisciplina() {AlunoId = 5, DisciplinaId = 5 },
                    new AlunoDisciplina() {AlunoId = 6, DisciplinaId = 1 },
                    new AlunoDisciplina() {AlunoId = 6, DisciplinaId = 2 },
                    new AlunoDisciplina() {AlunoId = 6, DisciplinaId = 3 },
                    new AlunoDisciplina() {AlunoId = 6, DisciplinaId = 4 },
                    new AlunoDisciplina() {AlunoId = 7, DisciplinaId = 1 },
                    new AlunoDisciplina() {AlunoId = 7, DisciplinaId = 2 },
                    new AlunoDisciplina() {AlunoId = 7, DisciplinaId = 3 },
                    new AlunoDisciplina() {AlunoId = 7, DisciplinaId = 4 },
                    new AlunoDisciplina() {AlunoId = 7, DisciplinaId = 5 }
                });

            return builder;
        }
        
    }
}