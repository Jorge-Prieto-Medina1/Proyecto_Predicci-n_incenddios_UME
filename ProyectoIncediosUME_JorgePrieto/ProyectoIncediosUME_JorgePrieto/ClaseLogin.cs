using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIncediosUME_JorgePrieto
{
    public class ClaseLogin
    {
        public Boolean login { get; set; }
        public String nombreUsuario { get; set; }

        public ClaseLogin(Boolean Login, String NombreUsuario)
        {
            this.login = Login;
            this.nombreUsuario = NombreUsuario;
        }
    }
}
