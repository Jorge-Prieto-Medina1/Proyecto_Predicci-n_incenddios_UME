using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProyectoIncediosUME_JorgePrieto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClaseConsultas consulta = new ClaseConsultas();

        public MainWindow()
        {
            InitializeComponent();
        }

      

        private void compruebaLoginInvitado(Object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void loginInvitado(Object sender, ExecutedRoutedEventArgs e)
        {
            ClaseLogin InfoUsuario = new ClaseLogin(false, "invitado");
            VentanaPrincipal ventanaMain = new VentanaPrincipal(InfoUsuario);
            ventanaMain.Show();
            this.Close();
        }


        private void compruebaLogin(Object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void loginUsuario(Object sender, ExecutedRoutedEventArgs e)
        {
            string email = this.txtEmailLogin.Text.Trim();
            string contraseña = this.txtContraseñaLogin.Password.Trim();
            if (email.Length == 0 | contraseña.Length == 0)
            {
                MessageBox.Show("Rellene todos los campos para realizar el login");
            }
            else
            {
                if (this.consulta.consultaUsuarioLogin(email, contraseña))
                {
                    ClaseLogin InfoUsuario = new ClaseLogin(true, email);
                    VentanaPrincipal ventanaMain = new VentanaPrincipal(InfoUsuario);
                    ventanaMain.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Contraseña, correo erroneos o cuenta desactivada");
                }
            }
        }



        private void compruebaRegistro(Object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void registroUsuario(Object sender, ExecutedRoutedEventArgs e)
        {
            string email = this.txtEmailRegistro.Text.Trim();
            string usuario = this.txtUsuarioRegistro.Text.Trim();
            string contraseña = this.txtContraseñaRegistro.Password.Trim();
            if (email.Length == 0 | usuario.Length == 0 | contraseña.Length == 0 )
            {
                MessageBox.Show("Rellene todos los campos para realizar el registro");
            }
            else
            {
                if (this.consulta.consultaUsuarioRegistro(email))
                {
                    MessageBox.Show("Email en uso");
                }
                else
                {
                    usuario UsuarioAInsertar = new usuario();

                    UsuarioAInsertar.activo = false;
                    UsuarioAInsertar.contrasenaUsuario = contraseña;
                    UsuarioAInsertar.correoUsuario = email;
                    UsuarioAInsertar.nombreUsuario = usuario;

                    this.consulta.insertarUsuario(UsuarioAInsertar);

                    MessageBox.Show("Cuenta creada, por favor espere a que una administrador la active");
                }
            }
        }

    }

}
