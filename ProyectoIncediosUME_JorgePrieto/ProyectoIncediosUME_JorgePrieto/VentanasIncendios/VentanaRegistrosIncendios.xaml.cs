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

namespace ProyectoIncediosUME_JorgePrieto.VentanasIncendios
{
    /// <summary>
    /// Lógica de interacción para VentanaRegistrosIncendios.xaml
    /// </summary>
    public partial class VentanaRegistrosIncendios : Window
    {
        ClaseConsultas consultas = new ClaseConsultas();
        Boolean cargado = false;
        List<Incendio> listaIncendios;
        List<IncendiosAVisualizar> listaDGRIncendios = new List<IncendiosAVisualizar>();
        ClaseLogin infoUsuario;


        public VentanaRegistrosIncendios(ClaseLogin InfoUsuario)
        {
            this.infoUsuario = InfoUsuario;
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cargado = true;
            cargarDgrIncendios();
        }

        private void CompruebaSalir(Object sender, CanExecuteRoutedEventArgs e)
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

        private void CompruebaModificaciones(Object sender, CanExecuteRoutedEventArgs e)
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

        private void Salir(Object sender, ExecutedRoutedEventArgs e)
        {
            VentanaPrincipal ventanaPrincipal = new VentanaPrincipal(infoUsuario);
            ventanaPrincipal.Show();
            this.Close();
        }

        private void AñadirRegistro(Object sender, ExecutedRoutedEventArgs e)
        {
            VentanaAñadirIncendio añadirIncendio = new VentanaAñadirIncendio();
            this.Hide();
            añadirIncendio.ShowDialog();
            this.Show();
            cargarDgrIncendios();
        }

        private void BorrarRegistro(Object sender, ExecutedRoutedEventArgs e)
        {
            if (this.dgrIncendios.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un incendio");
            }
            else
            {
                MessageBoxResult resultadoEliminar = MessageBox.Show("¿Seguro que desea eliminar este incendio?", "Aviso", MessageBoxButton.YesNo);

                if (resultadoEliminar == MessageBoxResult.Yes)
                {
                    int fila = this.dgrIncendios.SelectedIndex;
                    int idIncendio = this.listaIncendios[fila].idIncendio;
                    consultas.eliminarIncendio(idIncendio);
                    MessageBox.Show("Incendio eliminado");
                    cargarDgrIncendios();
                    
                }

            }
        }

        private void ModificarRegistro(Object sender, ExecutedRoutedEventArgs e)
        {
            if (this.dgrIncendios.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un incendio");
            }
            else
            {
                int fila = this.dgrIncendios.SelectedIndex;
                Incendio IncendioAModificar = this.listaIncendios[fila];
                VentanaMoficarIncendio modificarIncendio= new VentanaMoficarIncendio(IncendioAModificar);
                this.Hide();
                modificarIncendio.ShowDialog();
                this.Show();
                cargarDgrIncendios();

            }
        }

        private void cargarDgrIncendios()
        {
            this.dgrIncendios.ItemsSource = null;
            this.listaDGRIncendios.Clear();
            this.listaIncendios = consultas.obtenerIncendios();
            foreach (var incendio in listaIncendios)
            {
                int idLocalidad = incendio.idLocalidad;
                String [] nombres = consultas.buscarNombreLocalidadPrivincia(idLocalidad);
                IncendiosAVisualizar incendioNuevo = new IncendiosAVisualizar(nombres[0], nombres[1], incendio.temperaturaMedia.Value, incendio.humedadMedia.Value, incendio.hectareasQuemadas.Value, incendio.fechaDeInicio.ToString().Substring(0, 10), incendio.fechaDeExtinción.ToString().Substring(0, 10));
                this.listaDGRIncendios.Add(incendioNuevo);
            }
            this.dgrIncendios.ItemsSource = listaDGRIncendios;
            dgrIncendios.Columns[0].Header = "Provincia";
            dgrIncendios.Columns[1].Header = "Localidad";
            dgrIncendios.Columns[2].Header = "Temperatura Media";
            dgrIncendios.Columns[3].Header = "Humedad Media";
            dgrIncendios.Columns[4].Header = "Hectareas";
            dgrIncendios.Columns[5].Header = "Fecha de inicio";
            dgrIncendios.Columns[6].Header = "Fecha de extinción";
        }
    }
}