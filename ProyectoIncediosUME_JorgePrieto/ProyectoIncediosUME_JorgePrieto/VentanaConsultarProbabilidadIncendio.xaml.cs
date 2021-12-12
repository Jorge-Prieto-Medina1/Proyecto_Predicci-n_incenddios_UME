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
using System.Windows.Shapes;

namespace ProyectoIncediosUME_JorgePrieto
{
    /// <summary>
    /// Lógica de interacción para VentanaConsultarProbabilidadIncendio.xaml
    /// </summary>
    public partial class VentanaConsultarProbabilidadIncendio : Window
    {
        ClaseConsultas consultas = new ClaseConsultas();
        Boolean cargado = false;


        public VentanaConsultarProbabilidadIncendio()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cargado = true;
            cargarCmbProvincias();
        }


        private void Comprueba(Object sender, CanExecuteRoutedEventArgs e)
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

        private void CalcularProbabilidad(Object sender, ExecutedRoutedEventArgs e)
        {
            if (this.cmbProvincias.Text == "" || this.cmbLocalidades.Text == "" || this.dpkFecha.Text == "")
            {
                MessageBox.Show("Por favor rellene los campos");
            }
            else
            {
                DateTime fecha = Convert.ToDateTime(this.dpkFecha.SelectedDate.Value.Date.ToShortDateString());
                String provincia = this.cmbProvincias.Text;
                String localidad = this.cmbLocalidades.Text;

                int idProvincia = consultas.buscarIdProvincia(provincia);
                int idLocalidad = consultas.buscarIdLocalidad(idProvincia, localidad);
                this.txtRiesgo.Text = consultas.consultaProbabilidad(idLocalidad, fecha);
            }
        }

        private void Salir(Object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }

        private void cargarCmbProvincias()
        {
            List<String> listaProvincias = consultas.cargarProvincias();
            this.cmbProvincias.ItemsSource = listaProvincias;
            this.cmbProvincias.SelectedIndex = 0;
        }

        private void cargarCmbLocalidades()
        {
            String provincia = this.cmbProvincias.SelectedItem.ToString();
            List<String> listaLocalidades = consultas.cargarLocalidades(provincia);
            this.cmbLocalidades.ItemsSource = listaLocalidades;
        }

        private void cmbProvincias_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cargarCmbLocalidades();
        }
    }
}
