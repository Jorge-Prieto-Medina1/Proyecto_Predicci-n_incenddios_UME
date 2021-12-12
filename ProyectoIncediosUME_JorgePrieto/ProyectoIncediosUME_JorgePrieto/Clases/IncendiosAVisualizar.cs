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
        public int temperatura { get; set; }
        public int humedad { get; set; }
        public int hectareas { get; set; }
        public String fechaInicio { get; set; }
        public String fechaFin { get; set; }


        public IncendiosAVisualizar(String NombreLocalidad, String NombreProvincia, int Temperatura, int Humedad, int Hecatareas ,String FechaInicio, String FechaFin)
        {
            this.nombreLocalidad = NombreLocalidad;
            this.nombreProvincia = NombreProvincia;
            this.temperatura = Temperatura;
            this.humedad = Humedad;
            this.hectareas = Hecatareas;
            this.fechaInicio = FechaInicio;
            this.fechaFin = FechaFin;

        }
    }
}
