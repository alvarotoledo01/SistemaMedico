using System;
using System.Collections.Generic;

namespace SistemaMedico.Models
{
    public class Recepcionista
    {
        public int RecepcionistaId { get; set; } // PK
        public int UsuarioId { get; set; } // FK

        public string Nombre { get; set; }

        // Relación
        public Usuario Usuario { get; set; }
    }
}
