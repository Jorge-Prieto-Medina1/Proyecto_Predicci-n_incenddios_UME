using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIncediosUME_JorgePrieto.Clases
{

    class DatosMeteorologicosAVisualizar
    {
        public String nombreLocalidad { get; set; }
        public String nombreProvincia { get; set; }
        public String temperaturaMedia { get; set; }
        public String fechaInicio { get; set; }
        public String fechaFin { get; set; }


        public DatosMeteorologicosAVisualizar(String NombreLocalidad, String NombreProvincia, String TemperaturaMedia ,String FechaInicio, String FechaFin)
        {
            this.nombreLocalidad = NombreLocalidad;
            this.nombreProvincia = NombreProvincia;
            this.temperaturaMedia = TemperaturaMedia;
            this.fechaInicio = FechaInicio;
            this.fechaFin = FechaFin;

        }
    }
}
