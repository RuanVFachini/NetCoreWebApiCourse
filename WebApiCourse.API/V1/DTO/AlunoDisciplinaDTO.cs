using System;

namespace WebApiCourse.API.V1.DTO
{
    public class AlunoDisciplinaDTO
    {
        public DateTime DataIni { get; set; }
        public DateTime? DataFim { get; set; }
        public int DisciplinaId { get; set; }
        public int AlunoId { get; set; }
        public decimal? Nota { get; set; }
    }
}