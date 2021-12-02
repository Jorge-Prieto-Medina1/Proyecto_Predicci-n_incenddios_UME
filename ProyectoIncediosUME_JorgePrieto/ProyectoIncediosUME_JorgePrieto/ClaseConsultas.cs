using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace ProyectoIncediosUME_JorgePrieto
{
    public class ClaseConsultas
    {

        public Boolean[] consultaUsuarioLogin(String Correo, String Contraseña)
        {
            Boolean[] resultado = new Boolean[3];
            using (prediccionIncendiosEntites baseDeDatos = new prediccionIncendiosEntites())
            {
                var consultaCorreo = from busqueda in baseDeDatos.usuario
                                     where busqueda.correoUsuario.Contains(Correo)
                                     select new { busqueda.contrasenaUsuario, busqueda.activo };


                if (consultaCorreo.Count() != 0)
                {
                    resultado[0] = true;

                    if (Contraseña.Equals(consultaCorreo.FirstOrDefault().contrasenaUsuario))
                    {
                        resultado[1] = true;
                        if (consultaCorreo.FirstOrDefault().activo.Equals("Activo"))
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
            using (prediccionIncendiosEntites baseDeDatos = new prediccionIncendiosEntites())
            {
                var consultaCorreo = from busqueda in baseDeDatos.usuario
                                     where busqueda.correoUsuario.Contains(Correo)
                                     select new { busqueda.nombreUsuario };

                usuario = consultaCorreo.FirstOrDefault().nombreUsuario;
            }

            return usuario;
        }

        public Boolean consultaUsuarioRegistro(String correo)
        {
            Boolean resultado = false;
            using (prediccionIncendiosEntites baseDeDatos = new prediccionIncendiosEntites())
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

        public void insertarUsuario(usuario UsuarioAInsertar)
        {
            prediccionIncendiosEntites baseDeDatos = new prediccionIncendiosEntites();
            baseDeDatos.usuario.Add(UsuarioAInsertar);
            baseDeDatos.SaveChanges();
        }

        public List<usuario> obtenerUsuarios(String correo)
        {
            using (prediccionIncendiosEntites baseDeDatos = new prediccionIncendiosEntites())
            {
                List<usuario> listaUsuarios;
                listaUsuarios = baseDeDatos.usuario.OrderBy(x => x.nombreUsuario).ToList();

                for (int i = 0; i < listaUsuarios.Count; i++)
                {
                    if (listaUsuarios[i].correoUsuario.Equals(correo))
                    {
                        listaUsuarios.RemoveAt(i);
                    }
                }
                return listaUsuarios;
            }

        }


        public void modificarUsuario(String correoUsuario)
        {
            using (prediccionIncendiosEntites baseDeDatos = new prediccionIncendiosEntites())
            {

                usuario UsuarioAModificar = baseDeDatos.usuario.First(x => x.correoUsuario.Equals(correoUsuario));
                String activo = UsuarioAModificar.activo;


                if (activo.Equals("Activo"))
                {

                    UsuarioAModificar.activo = "Inactivo";
                    baseDeDatos.SaveChanges();

                }
                else
                {
                    UsuarioAModificar.activo = "Activo";
                    baseDeDatos.SaveChanges();
                }
            }
        }

        public void eliminarUsuario(String correoUsuario)
        {
            using (prediccionIncendiosEntites baseDeDatos = new prediccionIncendiosEntites())
            {

                usuario UsuarioAEliminar = baseDeDatos.usuario.First(x => x.correoUsuario.Equals(correoUsuario));
                baseDeDatos.usuario.Remove(UsuarioAEliminar);
                baseDeDatos.SaveChanges();
            }

        }
    }
}