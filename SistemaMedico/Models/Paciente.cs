using System;
using System.Collections.Generic;

namespace SistemaMedico.Models
{
    public class Paciente
    {
        public int PacienteId { get; set; } // PK
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public DateTime FechaNacimiento { get; set; }

        // Relación
        public HistoriaClinica HistoriaClinica { get; set; }
    }


}
