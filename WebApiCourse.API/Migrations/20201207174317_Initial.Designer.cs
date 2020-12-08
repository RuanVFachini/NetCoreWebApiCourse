﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiCourse.API.Data;

namespace WebApiCourse.API.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20201207174317_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10");

            modelBuilder.Entity("WebApiCourse.Domain.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DataFim")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataNasc")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Matricula")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Aluno");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataInicio = new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(5742),
                            DataNasc = new DateTime(2005, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            Matricula = "ADBC254845",
                            Nome = "Marta",
                            Sobrenome = "Kent",
                            Telefone = "33225555"
                        },
                        new
                        {
                            Id = 2,
                            DataInicio = new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(7273),
                            DataNasc = new DateTime(2000, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            Matricula = "ADBC254846",
                            Nome = "Paula",
                            Sobrenome = "Isabela",
                            Telefone = "3354288"
                        },
                        new
                        {
                            Id = 3,
                            DataInicio = new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(7341),
                            DataNasc = new DateTime(2002, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            Matricula = "ADBC254847",
                            Nome = "Laura",
                            Sobrenome = "Antonia",
                            Telefone = "55668899"
                        },
                        new
                        {
                            Id = 4,
                            DataInicio = new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(7348),
                            DataNasc = new DateTime(2005, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            Matricula = "ADBC254848",
                            Nome = "Luiza",
                            Sobrenome = "Maria",
                            Telefone = "6565659"
                        },
                        new
                        {
                            Id = 5,
                            DataInicio = new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(7353),
                            DataNasc = new DateTime(2002, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            Matricula = "ADBC254849",
                            Nome = "Lucas",
                            Sobrenome = "Machado",
                            Telefone = "565685415"
                        },
                        new
                        {
                            Id = 6,
                            DataInicio = new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(7361),
                            DataNasc = new DateTime(2005, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            Matricula = "ADBC254850",
                            Nome = "Pedro",
                            Sobrenome = "Alvares",
                            Telefone = "456454545"
                        },
                        new
                        {
                            Id = 7,
                            DataInicio = new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(7367),
                            DataNasc = new DateTime(2000, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            Matricula = "ADBC254851",
                            Nome = "Paulo",
                            Sobrenome = "José",
                            Telefone = "9874512"
                        });
                });

            modelBuilder.Entity("WebApiCourse.Domain.Models.AlunoCurso", b =>
                {
                    b.Property<int>("AlunoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CursoId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DataFim")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataIni")
                        .HasColumnType("TEXT");

                    b.Property<int>("Id")
                        .HasColumnType("INTEGER");

                    b.HasKey("AlunoId", "CursoId");

                    b.HasIndex("CursoId");

                    b.ToTable("AlunoCurso");
                });

            modelBuilder.Entity("WebApiCourse.Domain.Models.AlunoDisciplina", b =>
                {
                    b.Property<int>("AlunoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DisciplinaId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DataFim")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataIni")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("Nota")
                        .HasColumnType("TEXT");

                    b.HasKey("AlunoId", "DisciplinaId");

                    b.HasIndex("DisciplinaId");

                    b.ToTable("AlunoDisciplina");

                    b.HasData(
                        new
                        {
                            AlunoId = 1,
                            DisciplinaId = 2,
                            DataIni = new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(8684)
                        },
                        new
                        {
                            AlunoId = 1,
                            DisciplinaId = 4,
                            DataIni = new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(9267)
                        },
                        new
                        {
                            AlunoId = 1,
                            DisciplinaId = 5,
                            DataIni = new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(9302)
                        },
                        new
                        {
                            AlunoId = 2,
                            DisciplinaId = 1,
                            DataIni = new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(9303)
                        },
                        new
                        {
                            AlunoId = 2,
                            DisciplinaId = 2,
                            DataIni = new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(9305)
                        },
                        new
                        {
                            AlunoId = 2,
                            DisciplinaId = 5,
                            DataIni = new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(9369)
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 1,
                            DataIni = new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(9371)
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 2,
                            DataIni = new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(9372)
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 3,
                            DataIni = new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(9374)
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 1,
                            DataIni = new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(9376)
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 4,
                            DataIni = new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(9378)
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 5,
                            DataIni = new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(9379)
                        },
                        new
                        {
                            AlunoId = 5,
                            DisciplinaId = 4,
                            DataIni = new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(9381)
                        },
                        new
                        {
                            AlunoId = 5,
                            DisciplinaId = 5,
                            DataIni = new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(9382)
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 1,
                            DataIni = new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(9383)
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 2,
                            DataIni = new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(9385)
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 3,
                            DataIni = new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(9386)
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 4,
                            DataIni = new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(9388)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 1,
                            DataIni = new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(9390)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 2,
                            DataIni = new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(9391)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 3,
                            DataIni = new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(9393)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 4,
                            DataIni = new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(9394)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 5,
                            DataIni = new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(9395)
                        });
                });

            modelBuilder.Entity("WebApiCourse.Domain.Models.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Curso");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Tecnologia da informação"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Sistemas de Informação"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Ciência da Computação"
                        });
                });

            modelBuilder.Entity("WebApiCourse.Domain.Models.Disciplina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CH")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CursoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PrerequisitoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProfessorId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CursoId");

                    b.HasIndex("PrerequisitoId");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Disciplina");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CH = 0,
                            CursoId = 1,
                            Nome = "Matemática",
                            ProfessorId = 1
                        },
                        new
                        {
                            Id = 2,
                            CH = 0,
                            CursoId = 2,
                            Nome = "Matemática",
                            ProfessorId = 1
                        },
                        new
                        {
                            Id = 3,
                            CH = 0,
                            CursoId = 3,
                            Nome = "Matemática",
                            ProfessorId = 1
                        },
                        new
                        {
                            Id = 4,
                            CH = 0,
                            CursoId = 1,
                            Nome = "Português",
                            ProfessorId = 3
                        },
                        new
                        {
                            Id = 5,
                            CH = 0,
                            CursoId = 3,
                            Nome = "Português",
                            ProfessorId = 3
                        },
                        new
                        {
                            Id = 6,
                            CH = 0,
                            CursoId = 1,
                            Nome = "Inglês",
                            ProfessorId = 4
                        },
                        new
                        {
                            Id = 7,
                            CH = 0,
                            CursoId = 3,
                            Nome = "Inglês",
                            ProfessorId = 4
                        },
                        new
                        {
                            Id = 8,
                            CH = 0,
                            CursoId = 1,
                            Nome = "Programação",
                            ProfessorId = 5
                        },
                        new
                        {
                            Id = 9,
                            CH = 0,
                            CursoId = 2,
                            Nome = "Programação",
                            ProfessorId = 5
                        },
                        new
                        {
                            Id = 10,
                            CH = 0,
                            CursoId = 3,
                            Nome = "Programação",
                            ProfessorId = 5
                        });
                });

            modelBuilder.Entity("WebApiCourse.Domain.Models.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DataFim")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Registro")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Professor");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataInicio = new DateTime(2020, 12, 7, 14, 43, 17, 82, DateTimeKind.Local).AddTicks(1386),
                            IsActive = true,
                            Nome = "Lauro",
                            Registro = "",
                            Sobrenome = "Oliveira",
                            Telefone = ""
                        },
                        new
                        {
                            Id = 2,
                            DataInicio = new DateTime(2020, 12, 7, 14, 43, 17, 83, DateTimeKind.Local).AddTicks(2035),
                            IsActive = true,
                            Nome = "Roberto",
                            Registro = "",
                            Sobrenome = "Soares",
                            Telefone = ""
                        },
                        new
                        {
                            Id = 3,
                            DataInicio = new DateTime(2020, 12, 7, 14, 43, 17, 83, DateTimeKind.Local).AddTicks(2102),
                            IsActive = true,
                            Nome = "Ronaldo",
                            Registro = "",
                            Sobrenome = "Marconi",
                            Telefone = ""
                        },
                        new
                        {
                            Id = 4,
                            DataInicio = new DateTime(2020, 12, 7, 14, 43, 17, 83, DateTimeKind.Local).AddTicks(2106),
                            IsActive = true,
                            Nome = "Rodrigo",
                            Registro = "",
                            Sobrenome = "Carvalho",
                            Telefone = ""
                        },
                        new
                        {
                            Id = 5,
                            DataInicio = new DateTime(2020, 12, 7, 14, 43, 17, 83, DateTimeKind.Local).AddTicks(2107),
                            IsActive = true,
                            Nome = "Alexandre",
                            Registro = "",
                            Sobrenome = "Montanha",
                            Telefone = ""
                        });
                });

            modelBuilder.Entity("WebApiCourse.Domain.Models.AlunoCurso", b =>
                {
                    b.HasOne("WebApiCourse.Domain.Models.Aluno", "Aluno")
                        .WithMany()
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApiCourse.Domain.Models.Curso", "Curso")
                        .WithMany()
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApiCourse.Domain.Models.AlunoDisciplina", b =>
                {
                    b.HasOne("WebApiCourse.Domain.Models.Aluno", "Aluno")
                        .WithMany("AlunoDisciplinas")
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApiCourse.Domain.Models.Disciplina", "Disciplina")
                        .WithMany("AlunoDisciplinas")
                        .HasForeignKey("DisciplinaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApiCourse.Domain.Models.Disciplina", b =>
                {
                    b.HasOne("WebApiCourse.Domain.Models.Curso", "Curso")
                        .WithMany("Disciplinas")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApiCourse.Domain.Models.Disciplina", "Prerequisito")
                        .WithMany()
                        .HasForeignKey("PrerequisitoId");

                    b.HasOne("WebApiCourse.Domain.Models.Professor", "Professor")
                        .WithMany("Disciplinas")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
