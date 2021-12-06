using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIncediosUME_JorgePrieto.Clases
{
    class IncendiosAVisualizar
    {
        public String nombreLocalidad { get; set; }
        public String nombreProvincia { get; set; }
        public String fechaInicio { get; set; }
        public String fechaFin { get; set; }


        public IncendiosAVisualizar(String NombreLocalidad, String NombreProvincia, String FechaInicio, String FechaFin)
        {
            this.nombreLocalidad = NombreLocalidad;
            this.nombreProvincia = NombreProvincia;
            this.fechaInicio = NombreLocalidad;
            this.fechaFin = NombreProvincia;

        }
    }
}
