using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiCourse.API.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aluno",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true),
                    Matricula = table.Column<string>(nullable: true),
                    Sobrenome = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: true),
                    DataNasc = table.Column<DateTime>(nullable: false),
                    DataInicio = table.Column<DateTime>(nullable: false),
                    DataFim = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aluno", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Curso",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curso", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Professor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true),
                    Sobrenome = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: true),
                    Registro = table.Column<string>(nullable: true),
                    DataInicio = table.Column<DateTime>(nullable: false),
                    DataFim = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AlunoCurso",
                columns: table => new
                {
                    CursoId = table.Column<int>(nullable: false),
                    AlunoId = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false),
                    DataIni = table.Column<DateTime>(nullable: false),
                    DataFim = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlunoCurso", x => new { x.AlunoId, x.CursoId });
                    table.ForeignKey(
                        name: "FK_AlunoCurso_Aluno_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Aluno",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlunoCurso_Curso_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Curso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Disciplina",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true),
                    CH = table.Column<int>(nullable: false),
                    PrerequisitoId = table.Column<int>(nullable: true),
                    ProfessorId = table.Column<int>(nullable: false),
                    CursoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disciplina", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Disciplina_Curso_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Curso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Disciplina_Disciplina_PrerequisitoId",
                        column: x => x.PrerequisitoId,
                        principalTable: "Disciplina",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Disciplina_Professor_ProfessorId",
                        column: x => x.ProfessorId,
                        principalTable: "Professor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AlunoDisciplina",
                columns: table => new
                {
                    DisciplinaId = table.Column<int>(nullable: false),
                    AlunoId = table.Column<int>(nullable: false),
                    DataIni = table.Column<DateTime>(nullable: false),
                    DataFim = table.Column<DateTime>(nullable: true),
                    Nota = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlunoDisciplina", x => new { x.AlunoId, x.DisciplinaId });
                    table.ForeignKey(
                        name: "FK_AlunoDisciplina_Aluno_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Aluno",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlunoDisciplina_Disciplina_DisciplinaId",
                        column: x => x.DisciplinaId,
                        principalTable: "Disciplina",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Aluno",
                columns: new[] { "Id", "DataFim", "DataInicio", "DataNasc", "IsActive", "Matricula", "Nome", "Sobrenome", "Telefone" },
                values: new object[] { 1, null, new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(5742), new DateTime(2005, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "ADBC254845", "Marta", "Kent", "33225555" });

            migrationBuilder.InsertData(
                table: "Aluno",
                columns: new[] { "Id", "DataFim", "DataInicio", "DataNasc", "IsActive", "Matricula", "Nome", "Sobrenome", "Telefone" },
                values: new object[] { 2, null, new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(7273), new DateTime(2000, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "ADBC254846", "Paula", "Isabela", "3354288" });

            migrationBuilder.InsertData(
                table: "Aluno",
                columns: new[] { "Id", "DataFim", "DataInicio", "DataNasc", "IsActive", "Matricula", "Nome", "Sobrenome", "Telefone" },
                values: new object[] { 3, null, new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(7341), new DateTime(2002, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "ADBC254847", "Laura", "Antonia", "55668899" });

            migrationBuilder.InsertData(
                table: "Aluno",
                columns: new[] { "Id", "DataFim", "DataInicio", "DataNasc", "IsActive", "Matricula", "Nome", "Sobrenome", "Telefone" },
                values: new object[] { 4, null, new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(7348), new DateTime(2005, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "ADBC254848", "Luiza", "Maria", "6565659" });

            migrationBuilder.InsertData(
                table: "Aluno",
                columns: new[] { "Id", "DataFim", "DataInicio", "DataNasc", "IsActive", "Matricula", "Nome", "Sobrenome", "Telefone" },
                values: new object[] { 5, null, new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(7353), new DateTime(2002, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "ADBC254849", "Lucas", "Machado", "565685415" });

            migrationBuilder.InsertData(
                table: "Aluno",
                columns: new[] { "Id", "DataFim", "DataInicio", "DataNasc", "IsActive", "Matricula", "Nome", "Sobrenome", "Telefone" },
                values: new object[] { 6, null, new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(7361), new DateTime(2005, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "ADBC254850", "Pedro", "Alvares", "456454545" });

            migrationBuilder.InsertData(
                table: "Aluno",
                columns: new[] { "Id", "DataFim", "DataInicio", "DataNasc", "IsActive", "Matricula", "Nome", "Sobrenome", "Telefone" },
                values: new object[] { 7, null, new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(7367), new DateTime(2000, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "ADBC254851", "Paulo", "José", "9874512" });

            migrationBuilder.InsertData(
                table: "Curso",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 1, "Tecnologia da informação" });

            migrationBuilder.InsertData(
                table: "Curso",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 2, "Sistemas de Informação" });

            migrationBuilder.InsertData(
                table: "Curso",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 3, "Ciência da Computação" });

            migrationBuilder.InsertData(
                table: "Professor",
                columns: new[] { "Id", "DataFim", "DataInicio", "IsActive", "Nome", "Registro", "Sobrenome", "Telefone" },
                values: new object[] { 1, null, new DateTime(2020, 12, 7, 14, 43, 17, 82, DateTimeKind.Local).AddTicks(1386), true, "Lauro", "", "Oliveira", "" });

            migrationBuilder.InsertData(
                table: "Professor",
                columns: new[] { "Id", "DataFim", "DataInicio", "IsActive", "Nome", "Registro", "Sobrenome", "Telefone" },
                values: new object[] { 2, null, new DateTime(2020, 12, 7, 14, 43, 17, 83, DateTimeKind.Local).AddTicks(2035), true, "Roberto", "", "Soares", "" });

            migrationBuilder.InsertData(
                table: "Professor",
                columns: new[] { "Id", "DataFim", "DataInicio", "IsActive", "Nome", "Registro", "Sobrenome", "Telefone" },
                values: new object[] { 3, null, new DateTime(2020, 12, 7, 14, 43, 17, 83, DateTimeKind.Local).AddTicks(2102), true, "Ronaldo", "", "Marconi", "" });

            migrationBuilder.InsertData(
                table: "Professor",
                columns: new[] { "Id", "DataFim", "DataInicio", "IsActive", "Nome", "Registro", "Sobrenome", "Telefone" },
                values: new object[] { 4, null, new DateTime(2020, 12, 7, 14, 43, 17, 83, DateTimeKind.Local).AddTicks(2106), true, "Rodrigo", "", "Carvalho", "" });

            migrationBuilder.InsertData(
                table: "Professor",
                columns: new[] { "Id", "DataFim", "DataInicio", "IsActive", "Nome", "Registro", "Sobrenome", "Telefone" },
                values: new object[] { 5, null, new DateTime(2020, 12, 7, 14, 43, 17, 83, DateTimeKind.Local).AddTicks(2107), true, "Alexandre", "", "Montanha", "" });

            migrationBuilder.InsertData(
                table: "Disciplina",
                columns: new[] { "Id", "CH", "CursoId", "Nome", "PrerequisitoId", "ProfessorId" },
                values: new object[] { 1, 0, 1, "Matemática", null, 1 });

            migrationBuilder.InsertData(
                table: "Disciplina",
                columns: new[] { "Id", "CH", "CursoId", "Nome", "PrerequisitoId", "ProfessorId" },
                values: new object[] { 2, 0, 2, "Matemática", null, 1 });

            migrationBuilder.InsertData(
                table: "Disciplina",
                columns: new[] { "Id", "CH", "CursoId", "Nome", "PrerequisitoId", "ProfessorId" },
                values: new object[] { 3, 0, 3, "Matemática", null, 1 });

            migrationBuilder.InsertData(
                table: "Disciplina",
                columns: new[] { "Id", "CH", "CursoId", "Nome", "PrerequisitoId", "ProfessorId" },
                values: new object[] { 4, 0, 1, "Português", null, 3 });

            migrationBuilder.InsertData(
                table: "Disciplina",
                columns: new[] { "Id", "CH", "CursoId", "Nome", "PrerequisitoId", "ProfessorId" },
                values: new object[] { 5, 0, 3, "Português", null, 3 });

            migrationBuilder.InsertData(
                table: "Disciplina",
                columns: new[] { "Id", "CH", "CursoId", "Nome", "PrerequisitoId", "ProfessorId" },
                values: new object[] { 6, 0, 1, "Inglês", null, 4 });

            migrationBuilder.InsertData(
                table: "Disciplina",
                columns: new[] { "Id", "CH", "CursoId", "Nome", "PrerequisitoId", "ProfessorId" },
                values: new object[] { 7, 0, 3, "Inglês", null, 4 });

            migrationBuilder.InsertData(
                table: "Disciplina",
                columns: new[] { "Id", "CH", "CursoId", "Nome", "PrerequisitoId", "ProfessorId" },
                values: new object[] { 8, 0, 1, "Programação", null, 5 });

            migrationBuilder.InsertData(
                table: "Disciplina",
                columns: new[] { "Id", "CH", "CursoId", "Nome", "PrerequisitoId", "ProfessorId" },
                values: new object[] { 9, 0, 2, "Programação", null, 5 });

            migrationBuilder.InsertData(
                table: "Disciplina",
                columns: new[] { "Id", "CH", "CursoId", "Nome", "PrerequisitoId", "ProfessorId" },
                values: new object[] { 10, 0, 3, "Programação", null, 5 });

            migrationBuilder.InsertData(
                table: "AlunoDisciplina",
                columns: new[] { "AlunoId", "DisciplinaId", "DataFim", "DataIni", "Nota" },
                values: new object[] { 2, 1, null, new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(9303), null });

            migrationBuilder.InsertData(
                table: "AlunoDisciplina",
                columns: new[] { "AlunoId", "DisciplinaId", "DataFim", "DataIni", "Nota" },
                values: new object[] { 4, 5, null, new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(9379), null });

            migrationBuilder.InsertData(
                table: "AlunoDisciplina",
                columns: new[] { "AlunoId", "DisciplinaId", "DataFim", "DataIni", "Nota" },
                values: new object[] { 2, 5, null, new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(9369), null });

            migrationBuilder.InsertData(
                table: "AlunoDisciplina",
                columns: new[] { "AlunoId", "DisciplinaId", "DataFim", "DataIni", "Nota" },
                values: new object[] { 1, 5, null, new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(9302), null });

            migrationBuilder.InsertData(
                table: "AlunoDisciplina",
                columns: new[] { "AlunoId", "DisciplinaId", "DataFim", "DataIni", "Nota" },
                values: new object[] { 7, 4, null, new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(9394), null });

            migrationBuilder.InsertData(
                table: "AlunoDisciplina",
                columns: new[] { "AlunoId", "DisciplinaId", "DataFim", "DataIni", "Nota" },
                values: new object[] { 6, 4, null, new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(9388), null });

            migrationBuilder.InsertData(
                table: "AlunoDisciplina",
                columns: new[] { "AlunoId", "DisciplinaId", "DataFim", "DataIni", "Nota" },
                values: new object[] { 5, 4, null, new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(9381), null });

            migrationBuilder.InsertData(
                table: "AlunoDisciplina",
                columns: new[] { "AlunoId", "DisciplinaId", "DataFim", "DataIni", "Nota" },
                values: new object[] { 4, 4, null, new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(9378), null });

            migrationBuilder.InsertData(
                table: "AlunoDisciplina",
                columns: new[] { "AlunoId", "DisciplinaId", "DataFim", "DataIni", "Nota" },
                values: new object[] { 1, 4, null, new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(9267), null });

            migrationBuilder.InsertData(
                table: "AlunoDisciplina",
                columns: new[] { "AlunoId", "DisciplinaId", "DataFim", "DataIni", "Nota" },
                values: new object[] { 7, 3, null, new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(9393), null });

            migrationBuilder.InsertData(
                table: "AlunoDisciplina",
                columns: new[] { "AlunoId", "DisciplinaId", "DataFim", "DataIni", "Nota" },
                values: new object[] { 5, 5, null, new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(9382), null });

            migrationBuilder.InsertData(
                table: "AlunoDisciplina",
                columns: new[] { "AlunoId", "DisciplinaId", "DataFim", "DataIni", "Nota" },
                values: new object[] { 6, 3, null, new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(9386), null });

            migrationBuilder.InsertData(
                table: "AlunoDisciplina",
                columns: new[] { "AlunoId", "DisciplinaId", "DataFim", "DataIni", "Nota" },
                values: new object[] { 7, 2, null, new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(9391), null });

            migrationBuilder.InsertData(
                table: "AlunoDisciplina",
                columns: new[] { "AlunoId", "DisciplinaId", "DataFim", "DataIni", "Nota" },
                values: new object[] { 6, 2, null, new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(9385), null });

            migrationBuilder.InsertData(
                table: "AlunoDisciplina",
                columns: new[] { "AlunoId", "DisciplinaId", "DataFim", "DataIni", "Nota" },
                values: new object[] { 3, 2, null, new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(9372), null });

            migrationBuilder.InsertData(
                table: "AlunoDisciplina",
                columns: new[] { "AlunoId", "DisciplinaId", "DataFim", "DataIni", "Nota" },
                values: new object[] { 2, 2, null, new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(9305), null });

            migrationBuilder.InsertData(
                table: "AlunoDisciplina",
                columns: new[] { "AlunoId", "DisciplinaId", "DataFim", "DataIni", "Nota" },
                values: new object[] { 1, 2, null, new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(8684), null });

            migrationBuilder.InsertData(
                table: "AlunoDisciplina",
                columns: new[] { "AlunoId", "DisciplinaId", "DataFim", "DataIni", "Nota" },
                values: new object[] { 7, 1, null, new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(9390), null });

            migrationBuilder.InsertData(
                table: "AlunoDisciplina",
                columns: new[] { "AlunoId", "DisciplinaId", "DataFim", "DataIni", "Nota" },
                values: new object[] { 6, 1, null, new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(9383), null });

            migrationBuilder.InsertData(
                table: "AlunoDisciplina",
                columns: new[] { "AlunoId", "DisciplinaId", "DataFim", "DataIni", "Nota" },
                values: new object[] { 4, 1, null, new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(9376), null });

            migrationBuilder.InsertData(
                table: "AlunoDisciplina",
                columns: new[] { "AlunoId", "DisciplinaId", "DataFim", "DataIni", "Nota" },
                values: new object[] { 3, 1, null, new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(9371), null });

            migrationBuilder.InsertData(
                table: "AlunoDisciplina",
                columns: new[] { "AlunoId", "DisciplinaId", "DataFim", "DataIni", "Nota" },
                values: new object[] { 3, 3, null, new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(9374), null });

            migrationBuilder.InsertData(
                table: "AlunoDisciplina",
                columns: new[] { "AlunoId", "DisciplinaId", "DataFim", "DataIni", "Nota" },
                values: new object[] { 7, 5, null, new DateTime(2020, 12, 7, 14, 43, 17, 86, DateTimeKind.Local).AddTicks(9395), null });

            migrationBuilder.CreateIndex(
                name: "IX_AlunoCurso_CursoId",
                table: "AlunoCurso",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_AlunoDisciplina_DisciplinaId",
                table: "AlunoDisciplina",
                column: "DisciplinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplina_CursoId",
                table: "Disciplina",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplina_PrerequisitoId",
                table: "Disciplina",
                column: "PrerequisitoId");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplina_ProfessorId",
                table: "Disciplina",
                column: "ProfessorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlunoCurso");

            migrationBuilder.DropTable(
                name: "AlunoDisciplina");

            migrationBuilder.DropTable(
                name: "Aluno");

            migrationBuilder.DropTable(
                name: "Disciplina");

            migrationBuilder.DropTable(
                name: "Curso");

            migrationBuilder.DropTable(
                name: "Professor");
        }
    }
}
