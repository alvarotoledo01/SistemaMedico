using System;
using System.Collections.Generic;

namespace SistemaMedico.Models
{

    public class Plantilla
    {
        public int PlantillaId { get; set; } // PK
        public int DiagnosticoId { get; set; } // FK
        public int HistoriaClinicaId { get; set; } // FK
        public int MedicoId { get; set; } // FK

        public string Detalles { get; set; }
        public DateTime Fecha { get; set; }

        // Relación
        public Diagnostico Diagnostico { get; set; }
        public HistoriaClinica HistoriaClinica { get; set; }
        public Medico Medico { get; set; }
    }


}
