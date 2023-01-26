using System;
using System.Collections.Generic;

namespace studentsApp.Models
{
    public partial class Estudiante
    {
        public int EstudianteMatricula { get; set; }
        public string EstudianteNombre { get; set; } = null!;
        public string EstudianteSexo { get; set; } = null!;
        public string EstudianteCurso { get; set; } = null!;
        public int EstudianteEdad { get; set; }
        public string EstudianteTelefono { get; set; } = null!;
        public string EstudianteEstado { get; set; } = null!;
        public string? EstudianteFoto { get; set; }
    }
}
