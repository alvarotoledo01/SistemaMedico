using System;
using System.Collections.Generic;

namespace SistemaMedico.Models
{
    using System.Collections.Generic;

    public class HistoriaClinica
    {
        public int HistoriaClinicaId { get; set; } // PK
        public int PacienteId { get; set; } // FK

        // Relación
        public Paciente Paciente { get; set; }
        public ICollection<EvolucionMedica> EvolucionesMedicas { get; set; }
        public ICollection<RecetaDigital> RecetasDigitales { get; set; }
        public ICollection<Plantilla> Plantillas { get; set; }
    }


}
