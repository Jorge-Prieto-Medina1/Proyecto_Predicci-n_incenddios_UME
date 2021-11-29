using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIncediosUME_JorgePrieto
{
    public class ClaseConsultas
    {

        public Boolean[] consultaUsuarioLogin(String Correo, String Contraseña)
        {
            Boolean [] resultado  = new Boolean [3];
            using (prediccion_incendios_Entities baseDeDatos = new prediccion_incendios_Entities())
            {
                var consultaCorreo = from busqueda in baseDeDatos.usuario
                                where busqueda.correoUsuario.Contains(Correo)
                                select new {busqueda.contrasenaUsuario, busqueda.activo};


                if (consultaCorreo.Count() != 0)
                {
                    resultado[0] = true;

                    if (Contraseña.Equals(consultaCorreo.FirstOrDefault().contrasenaUsuario))
                    {
                        resultado[1] = true;
                        if (consultaCorreo.FirstOrDefault().activo == true)
                        {
                            resultado[2] = true;
                        }
                        else
                        {
                            resultado[2] = false;
                        }
                    }
                    else
                    {
                        resultado[1] = false;
                        resultado[2] = false;
                    }
                }
                else
                {
                    resultado[0] = false;
                    resultado[1] = false;
                    resultado[2] = false;
                }


            }

            return resultado;          
        }

        public String consultarNombreUsuario(String Correo)
        {
            String usuario = "";
            Boolean[] resultado = new Boolean[3];
            using (prediccion_incendios_Entities baseDeDatos = new prediccion_incendios_Entities())
            {
                var consultaCorreo = from busqueda in baseDeDatos.usuario
                                     where busqueda.correoUsuario.Contains(Correo)
                                     select new { busqueda.nombreUsuario};

                usuario = consultaCorreo.FirstOrDefault().nombreUsuario;
            }

                return usuario;
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
