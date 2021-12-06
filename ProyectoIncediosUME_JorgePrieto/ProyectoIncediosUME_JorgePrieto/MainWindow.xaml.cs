using ProyectoIncediosUME_JorgePrieto.Clases;
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
        Boolean cargado = false;
        ClaseConsultas consulta = new ClaseConsultas();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Ventana_Loaded(object sender, RoutedEventArgs e)
        {
            cargado = true;
        }


        private void CompruebaLoginInvitado(Object sender, CanExecuteRoutedEventArgs e)
        {
            if (cargado)
            {
                e.CanExecute = true;
            }
            else
            {
                e.CanExecute = false;
            }

        }

        private void LoginInvitado(Object sender, ExecutedRoutedEventArgs e)
        {
            ClaseLogin InfoUsuario = new ClaseLogin(false,"invitado", "");
            VentanaPrincipal ventanaMain = new VentanaPrincipal(InfoUsuario);
            MessageBox.Show("Bienvenido invitado");
            ventanaMain.Show();
            this.Close();
        }


        private void CompruebaLogin(Object sender, CanExecuteRoutedEventArgs e)
        {
            if (cargado)
            {
                e.CanExecute = true;
            }
            else
            {
                e.CanExecute = false;
            }
        }

        private void LoginUsuario(Object sender, ExecutedRoutedEventArgs e)
        {
            string email = this.txtEmailLogin.Text.Trim();
            string contraseña = this.txtContraseñaLogin.Password.Trim();
            if (email.Length == 0 | contraseña.Length == 0)
            {
                MessageBox.Show("Rellene todos los campos para realizar el login");
            }
            else
            {
                Boolean[] resultado = this.consulta.consultaUsuarioLogin(email, contraseña);

                if (resultado[0])
                {
                    if (resultado[1])
                    {
                        if (resultado[2])
                        {
                            String nombreUsuario = consulta.consultarNombreUsuario(email);

                            ClaseLogin InfoUsuario = new ClaseLogin(true,nombreUsuario, email);
                            VentanaPrincipal ventanaMain = new VentanaPrincipal(InfoUsuario);
                            MessageBox.Show("Bienvenido " + InfoUsuario.nombreUsuario);
                            ventanaMain.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Su cuenta está desactivada");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta");
                    }
                
                }
                else
                {

                    MessageBox.Show("El correo electronico no existe");

                }
            }
        }




        private void CompruebaRegistro(Object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void RegistroUsuario(Object sender, ExecutedRoutedEventArgs e)
        {
            string email = this.txtEmailRegistro.Text.Trim();
            string usuario = this.txtUsuarioRegistro.Text.Trim();
            string contraseña = this.txtContraseñaRegistro.Password.Trim();
            if (email.Length == 0 | usuario.Length == 0 | contraseña.Length == 0)
            {
                MessageBox.Show("Rellene todos los campos para realizar el registro");
            }
            else
            {
                if(EmailEsValido(email))
                {
                    if (this.consulta.consultaUsuarioRegistro(email))
                    {
                        MessageBox.Show("Email en uso");
                    }
                    else
                    {
                        usuario UsuarioAInsertar = new usuario();

                        UsuarioAInsertar.activo = "Inactivo";
                        UsuarioAInsertar.contrasenaUsuario = contraseña;
                        UsuarioAInsertar.correoUsuario = email;
                        UsuarioAInsertar.nombreUsuario = usuario;

                        this.consulta.insertarUsuario(UsuarioAInsertar);

                        MessageBox.Show("Cuenta creada, por favor espere a que una administrador la active");
                    }
                }
                else
                {
                    MessageBox.Show("El formato de su email no es válido");
                }
                
            }
        }


        private bool EmailEsValido(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }

        }
    }
}
