using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIncediosUME_JorgePrieto.Clases
{
    class LocalidadesAVisualizar
    {
        public String nombreLocalidad { get; set; }
        public String nombreProvincia { get; set; }

        public LocalidadesAVisualizar(String NombreLocalidad, String NombreProvincia)
        {
            this.nombreLocalidad = NombreLocalidad;
            this.nombreProvincia = NombreProvincia;
        }
    }
}
