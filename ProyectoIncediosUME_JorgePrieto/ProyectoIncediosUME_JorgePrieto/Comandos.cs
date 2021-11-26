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
        public static readonly RoutedUICommand loginInvitado = new RoutedUICommand(
            "Login",
            "Invitado",
            typeof(Comandos),
            new InputGestureCollection()
            {
                new KeyGesture(Key.A,ModifierKeys.Control)
            }
            );

        public static readonly RoutedUICommand login = new RoutedUICommand(
           "Login",
           "Aceptar",
           typeof(Comandos),
           new InputGestureCollection()
           {
                new KeyGesture(Key.B,ModifierKeys.Control)
           }
           );

        public static readonly RoutedUICommand registrar = new RoutedUICommand(
           "Registro",
           "Registrando",
           typeof(Comandos),
           new InputGestureCollection()
           {
                new KeyGesture(Key.C,ModifierKeys.Control)
           }
           );
    }
}
