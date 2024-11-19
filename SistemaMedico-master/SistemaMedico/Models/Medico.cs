using System;
using System.Collections.Generic;

namespace SistemaMedico.Models
{
    public class Medico
    {
        public int MedicoId { get; set; } // PK
        public int UsuarioId { get; set; } // FK

        public string Nombre { get; set; }
        public string Especialidad { get; set; }
        public string Matricula { get; set; }

        // Relación
        public Usuario Usuario { get; set; }
        public ICollection<EvolucionMedica> EvolucionesMedicas { get; set; }
        public ICollection<RecetaDigital> RecetasDigitales { get; set; }
        public ICollection<Plantilla> Plantillas{ get; set; }
    }

}
