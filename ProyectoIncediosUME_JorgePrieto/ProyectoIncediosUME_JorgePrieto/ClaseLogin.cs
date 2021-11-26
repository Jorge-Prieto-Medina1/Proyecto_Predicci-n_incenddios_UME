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
        public String email { get; set; }

        public ClaseLogin(Boolean Login, String Email)
        {
            this.login = Login;
            this.email = Email;
        }
    }
}
