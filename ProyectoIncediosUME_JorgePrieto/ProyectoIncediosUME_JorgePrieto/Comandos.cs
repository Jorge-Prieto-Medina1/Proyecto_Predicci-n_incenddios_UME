using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProyectoIncediosUME_JorgePrieto
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
    }
}
