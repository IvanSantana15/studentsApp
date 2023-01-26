using System;
using System.Collections.Generic;

namespace studentsApp.Models
{
    public partial class Usuario
    {
        public int UsuarioId { get; set; }
        public string UsuarioNombre { get; set; } = null!;
        public string UsuarioCorreo { get; set; } = null!;
        public string UsuarioPassword { get; set; } = null!;
        public string? UsuarioEstado { get; set; }
    }
}
