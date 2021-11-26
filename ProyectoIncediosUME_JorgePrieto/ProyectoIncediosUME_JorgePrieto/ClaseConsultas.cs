using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIncediosUME_JorgePrieto
{
    public class ClaseConsultas
    {

        public Boolean consultaUsuarioLogin(String correo, String contraseña)
        {
            Boolean resultado = false;
            using (prediccion_incendios_Entities baseDeDatos = new prediccion_incendios_Entities())
            {
                var consulta = from busqueda in baseDeDatos.usuario
                               where busqueda.activo == true  &
                               busqueda.correoUsuario.Contains (correo) &
                               busqueda.contrasenaUsuario.Contains (contraseña)
                               select new { nombreUuario = busqueda.nombreUsuario };

                if (consulta.Count() != 0)
                {
                    resultado = true;
                }
               
            }

            return resultado;          
        }


        public Boolean consultaUsuarioRegistro(String correo)
        {
            Boolean resultado = false;
            using (prediccion_incendios_Entities baseDeDatos = new prediccion_incendios_Entities())
            {
                var consulta = from busqueda in baseDeDatos.usuario
                               where busqueda.correoUsuario.Contains(correo)
                               select new { nombreUuario = busqueda.nombreUsuario };

                if (consulta.Count() != 0)
                {
                    resultado = true;
                }

            }

            return resultado;
        }

        public void insertarUsuario (usuario UsuarioAInsertar)
        {
            prediccion_incendios_Entities baseDeDatos = new prediccion_incendios_Entities();
            baseDeDatos.usuario.Add(UsuarioAInsertar);
            baseDeDatos.SaveChanges();
        }
    }
}
