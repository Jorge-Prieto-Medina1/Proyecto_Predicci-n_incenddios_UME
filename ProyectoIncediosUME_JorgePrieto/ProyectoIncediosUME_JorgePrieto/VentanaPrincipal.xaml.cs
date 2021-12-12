using ProyectoIncediosUME_JorgePrieto.Clases;
using ProyectoIncediosUME_JorgePrieto.VentanasDatosMeteorologicos;
using ProyectoIncediosUME_JorgePrieto.VentanasIncendios;
using ProyectoIncediosUME_JorgePrieto.VentanasLocalidad;
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
using System.Windows.Shapes;

namespace ProyectoIncediosUME_JorgePrieto
{
  
    public partial class VentanaPrincipal : Window
    {
        ClaseLogin infoUsuario;
        Boolean cargado = false;

        public VentanaPrincipal(ClaseLogin InfoUsuario)
        {
            this.infoUsuario = InfoUsuario;
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cargado = true;
            if (this.infoUsuario.login)
            {
                this.btnAdministracionUsuarios.Visibility = Visibility.Visible;
                this.btnModificarDatosMeteorológicos.Visibility = Visibility.Visible;
                this.btnModificarHistoralIncendios.Visibility = Visibility.Visible;
                this.btnModificarLocalidades.Visibility = Visibility.Visible;
            }
            
        }


        private void CompruebaSinLogin(Object sender, CanExecuteRoutedEventArgs e)
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

        private void CompruebaConLogin(Object sender, CanExecuteRoutedEventArgs e)
        {
            if (cargado)
            {
                if (infoUsuario.login)
                {
                    e.CanExecute = true;
                }
                else
                {
                    e.CanExecute = false;
                }
            }
            else
            {
                e.CanExecute = false;
            }
        }

        private void AccederVentanaGestiónUsuarios(Object sender, ExecutedRoutedEventArgs e)
        {
            VentanaGestionUsuarios ventanUsuarios = new VentanaGestionUsuarios(infoUsuario);
            this.Hide();
            ventanUsuarios.ShowDialog();
            this.Show();
        }

        private void AccederVentanaHistorialDeIncendios(Object sender, ExecutedRoutedEventArgs e)
        {
            VentanaHistorialIncendios ventanaIncendios = new VentanaHistorialIncendios();
            this.Hide();
            ventanaIncendios.ShowDialog();
            this.Show();
        }

        private void AccederVentanaModificarIncendios(Object sender, ExecutedRoutedEventArgs e)
        {
            VentanaRegistrosIncendios ventanIncendios = new VentanaRegistrosIncendios(infoUsuario);
            ventanIncendios.Show();
            this.Close();
        }

        private void AccederVentanaModificarDatosMeteorologicos(Object sender, ExecutedRoutedEventArgs e)
        {
            VentanaRegistrosMeteorologicos ventanDatosMeteorologicos = new VentanaRegistrosMeteorologicos(infoUsuario);
            ventanDatosMeteorologicos.Show();
            this.Close();
        }

        private void AccederVentanaProbabilidadDeIncendio(Object sender, ExecutedRoutedEventArgs e)
        {
            VentanaConsultarProbabilidadIncendio ventanaProbabilidadIncendios = new VentanaConsultarProbabilidadIncendio();
            this.Hide();
            ventanaProbabilidadIncendios.ShowDialog();
            this.Show();
        }

        private void AccederVentanaModificarLocalidades(Object sender, ExecutedRoutedEventArgs e)
        {
            VentanaLocalidad ventanaModificarLocalidades = new VentanaLocalidad(infoUsuario);
            ventanaModificarLocalidades.Show();
            this.Close();
        }

        private void Salir(Object sender, ExecutedRoutedEventArgs e)
        {
            
            MessageBoxResult resultadoSalir = MessageBox.Show("¿Seguro que desea salir?", "Aviso", MessageBoxButton.YesNo);

            if (resultadoSalir == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }


    }
}
