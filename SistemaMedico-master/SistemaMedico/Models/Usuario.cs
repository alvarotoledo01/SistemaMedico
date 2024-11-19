using System;
using System.Collections.Generic;

namespace SistemaMedico.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; } // PK
        public string NombreUsuario { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }

        // Relación
        public ICollection<Medico> Medicos { get; set; }
        public ICollection<Recepcionista> Recepcionistas { get; set; }
    }

}
