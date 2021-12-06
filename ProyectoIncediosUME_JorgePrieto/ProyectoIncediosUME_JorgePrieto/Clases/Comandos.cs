using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProyectoIncediosUME_JorgePrieto.Clases
{
    public static class Comandos
    {
        public static readonly RoutedUICommand loginInvitado = new RoutedUICommand();

        public static readonly RoutedUICommand login = new RoutedUICommand();

        public static readonly RoutedUICommand registrar = new RoutedUICommand();

        public static readonly RoutedUICommand salir = new RoutedUICommand();

        public static readonly RoutedUICommand gestinarUsuarios = new RoutedUICommand();

        public static readonly RoutedUICommand accederHistorialIncendios = new RoutedUICommand();

        public static readonly RoutedUICommand modificarRegistrosDeIncendios = new RoutedUICommand();

        public static readonly RoutedUICommand modificarDatosMeteorologicos = new RoutedUICommand();

        public static readonly RoutedUICommand consultarProbabilidadesDeIncendio = new RoutedUICommand();

        public static readonly RoutedUICommand modificarLocalidades = new RoutedUICommand();

        public static readonly RoutedUICommand volverAtras = new RoutedUICommand();

        public static readonly RoutedUICommand activarDesactivarUsuario = new RoutedUICommand();

        public static readonly RoutedUICommand eliminarUsuario = new RoutedUICommand();

        public static readonly RoutedUICommand eliminarLocalidad = new RoutedUICommand();

        public static readonly RoutedUICommand añadirLocalidad = new RoutedUICommand();

        public static readonly RoutedUICommand modificarLocalidad = new RoutedUICommand();

        public static readonly RoutedUICommand añadirIncendio = new RoutedUICommand();

        public static readonly RoutedUICommand modificarIncendio = new RoutedUICommand();

        public static readonly RoutedUICommand eliminarIncendio = new RoutedUICommand();

        public static readonly RoutedUICommand añadirDato = new RoutedUICommand();

        public static readonly RoutedUICommand modificarDato = new RoutedUICommand();

        public static readonly RoutedUICommand eliminarDato = new RoutedUICommand();


    }
}
