using System;

namespace WebApiCourse.API.V1.DTO
{
    public class AlunoRequestDTO
    {
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNasc { get; set; }
        public DateTime DataInicio { get; set; } = DateTime.Now;
        public DateTime? DataFim { get; set; } = null;
        public bool IsActive { get; set; } = true;
    }
}