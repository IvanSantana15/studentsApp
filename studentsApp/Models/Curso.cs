using System;
using System.Collections.Generic;

namespace studentsApp.Models
{
    public partial class Curso
    {
        public int CursoId { get; set; }
        public string CursoTitulo { get; set; } = null!;
        public int CursoCantidadEstudiante { get; set; }
    }
}
