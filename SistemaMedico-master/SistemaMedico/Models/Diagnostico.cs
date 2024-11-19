using System;
using System.Collections.Generic;

namespace SistemaMedico.Models
{
    public class Diagnostico
    {
        public int DiagnosticoId { get; set; } // PK
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        // Relación
        public ICollection<EvolucionMedica> EvolucionesMedicas { get; set; }
        public ICollection<RecetaDigital> RecetasDigitales { get; set; }
        public ICollection<Plantilla> Plantillas { get; set; }
    }

}
