using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace ProyectoIncediosUME_JorgePrieto.Clases
{
    public class ClaseConsultas
    {

        public Boolean[] consultaUsuarioLogin(String Correo, String Contraseña)
        {
            Boolean[] resultado = new Boolean[3];
            using (prediccion_incendiosEntitiesDB baseDeDatos = new prediccion_incendiosEntitiesDB())
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
            using (prediccion_incendiosEntitiesDB baseDeDatos = new prediccion_incendiosEntitiesDB())
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
            using (prediccion_incendiosEntitiesDB baseDeDatos = new prediccion_incendiosEntitiesDB())
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
            prediccion_incendiosEntitiesDB baseDeDatos = new prediccion_incendiosEntitiesDB();
            baseDeDatos.usuario.Add(UsuarioAInsertar);
            baseDeDatos.SaveChanges();
        }

        public List<usuario> obtenerUsuarios(String correo)
        {
            using (prediccion_incendiosEntitiesDB baseDeDatos = new prediccion_incendiosEntitiesDB())
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

        public List<localidad> obtenerLocalidades()
        {
            using (prediccion_incendiosEntitiesDB baseDeDatos = new prediccion_incendiosEntitiesDB())
            {
                List<localidad> listaLocalidades;
                listaLocalidades = baseDeDatos.localidad.OrderBy(x => x.nombreLocalidad).ToList();
                return listaLocalidades;
            }

        }


        public void modificarUsuario(String correoUsuario)
        {
            using (prediccion_incendiosEntitiesDB baseDeDatos = new prediccion_incendiosEntitiesDB())
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
            using (prediccion_incendiosEntitiesDB baseDeDatos = new prediccion_incendiosEntitiesDB())
            {

                usuario UsuarioAEliminar = baseDeDatos.usuario.First(x => x.correoUsuario.Equals(correoUsuario));
                baseDeDatos.usuario.Remove(UsuarioAEliminar);
                baseDeDatos.SaveChanges();
            }

        }


        public String consultarNombreProvincia(int Provincia)
        {
            String provincia = "";
            using (prediccion_incendiosEntitiesDB baseDeDatos = new prediccion_incendiosEntitiesDB())
            {
                var consultaLocalidad = from busqueda in baseDeDatos.provincia
                                        where busqueda.idProvincia == Provincia
                                        select new { busqueda.nombreProvincia };

                provincia = consultaLocalidad.FirstOrDefault().nombreProvincia;
            }

            return provincia;
        }

        public Boolean consultaIncendiosEnLocalidad(int idLocalidad)
        {
            Boolean resultado = true;
            using (prediccion_incendiosEntitiesDB baseDeDatos = new prediccion_incendiosEntitiesDB())
            {
                var consultaCorreo = from busqueda in baseDeDatos.Incendio
                                     where busqueda.idLocalidad == idLocalidad
                                     select new { busqueda.idIncendio };


                if (consultaCorreo.Count() != 0)
                {
                    resultado = true; 
                }
                else
                {
                    resultado = false;
                }
            }
            return resultado;
        }

        public void eliminarLocalidad(int IdLocalidad)
        {
            using (prediccion_incendiosEntitiesDB baseDeDatos = new prediccion_incendiosEntitiesDB())
            {
                var consultaDatoMeteorologico = from busqueda in baseDeDatos.datoMeteorologico
                                    where busqueda.idLocalidad == IdLocalidad
                                    select new { busqueda.idDato };

                if (consultaDatoMeteorologico.Count() != 0)
                {
                    var idDatos = consultaDatoMeteorologico.ToList();
                    foreach (var dato in idDatos)
                    {
                        int idDato = dato.idDato;
                        datoMeteorologico datoMeteorologicoEliminar = baseDeDatos.datoMeteorologico.First(x => x.idDato == idDato);
                        baseDeDatos.datoMeteorologico.Remove(datoMeteorologicoEliminar);
                        baseDeDatos.SaveChanges();
                    }

                }
                   
                localidad LocalidadAEliminar = baseDeDatos.localidad.First(x => x.idLocalidad == IdLocalidad);
                baseDeDatos.localidad.Remove(LocalidadAEliminar);
                baseDeDatos.SaveChanges();
            }

        }


        public List<String> cargarProvincias()
        {
            List<String> listaProvincias = new List<string>();
            using (prediccion_incendiosEntitiesDB baseDeDatos = new prediccion_incendiosEntitiesDB())
            {
                var consultaProvincia = from busqueda in baseDeDatos.provincia
                                        select new { busqueda.nombreProvincia };
                var lista = consultaProvincia.ToList();
                foreach (var provincia in lista)
                {
                    listaProvincias.Add(provincia.nombreProvincia);
                }
                return listaProvincias;
            }
        }

        public int buscarIdProvincia(String nombreProvincia)
        {
            using (prediccion_incendiosEntitiesDB baseDeDatos = new prediccion_incendiosEntitiesDB())
            {
                var consultaID = from busqueda in baseDeDatos.provincia
                                 where busqueda.nombreProvincia.Contains(nombreProvincia)
                                 select new { busqueda.idProvincia };

                int IdProvincia = consultaID.FirstOrDefault().idProvincia;

                return IdProvincia;
            }
        }

        public String buscarNombreProvincia(int IdProvincia)
        {
            using (prediccion_incendiosEntitiesDB baseDeDatos = new prediccion_incendiosEntitiesDB())
            {
                var consultaNombre = from busqueda in baseDeDatos.provincia
                                 where busqueda.idProvincia == IdProvincia
                                 select new { busqueda.nombreProvincia };

                String nombreProvincia = consultaNombre.FirstOrDefault().nombreProvincia;

                return nombreProvincia;
            }
        }

        public Boolean consultarLocalidad(String nombreLocalidad, int IdProvincia)
        {
            Boolean resultado = false;
            using (prediccion_incendiosEntitiesDB baseDeDatos = new prediccion_incendiosEntitiesDB())
            {
                var consultaNombre = from busqueda in baseDeDatos.localidad
                                    where busqueda.nombreLocalidad.Contains(nombreLocalidad) && 
                                    busqueda.idProvincia == IdProvincia
                                     select new { busqueda.idLocalidad };
                var listaDeLocalidades = consultaNombre.ToList();
                if(listaDeLocalidades.Count != 0)
                {
                    resultado = true;
                }
            }

            return resultado;
        }

        public void insertarLocalidad (localidad localidadInsetar)
        {
            using (prediccion_incendiosEntitiesDB baseDeDatos = new prediccion_incendiosEntitiesDB())
            {
                baseDeDatos.localidad.Add(localidadInsetar);
                baseDeDatos.SaveChanges();
            }
        }

        public void modificarLocalidad(localidad localidadModificada)
        {
            using (prediccion_incendiosEntitiesDB baseDeDatos = new prediccion_incendiosEntitiesDB())
            {
                localidad localidadOriginal = baseDeDatos.localidad.First(x => x.idLocalidad == localidadModificada.idLocalidad);
                localidadOriginal.temperaturaMediaPrimavera = localidadModificada.temperaturaMediaPrimavera;
                localidadOriginal.temperaturaMediaVerano = localidadModificada.temperaturaMediaVerano;
                localidadOriginal.temperaturaMediaOtoño = localidadModificada.temperaturaMediaOtoño;
                localidadOriginal.temperaturaMediaInvierno = localidadModificada.temperaturaMediaInvierno;
                localidadOriginal.humedadMediaPrimavera = localidadModificada.humedadMediaPrimavera;
                localidadOriginal.humedadMediaVerano = localidadModificada.humedadMediaVerano;
                localidadOriginal.humedadMediaOtoño = localidadModificada.humedadMediaOtoño;
                localidadOriginal.humedadMediaInvierno = localidadModificada.humedadMediaInvierno;
                baseDeDatos.SaveChanges();
            }
        }
        

    }


}