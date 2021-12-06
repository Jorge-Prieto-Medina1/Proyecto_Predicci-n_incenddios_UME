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

namespace ProyectoIncediosUME_JorgePrieto.VentanasLocalidad
{
    /// <summary>
    /// Lógica de interacción para VentanaModificarLocalidades.xaml
    /// </summary>
    public partial class VentanaLocalidad : Window
    {
        ClaseConsultas consultas = new ClaseConsultas();
        Boolean cargado = false;
        List<localidad> listaLocalidades;
        List<LocalidadesAVisualizar> listaDGRLocalidades = new List<LocalidadesAVisualizar>();
        ClaseLogin infoUsuario;


        public VentanaLocalidad(ClaseLogin InfoUsuario)
        {
            this.infoUsuario = InfoUsuario;
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            cargado = true;
            cargarDgrLocalidades();
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

        private void BorrarRegistro(Object sender, ExecutedRoutedEventArgs e)
        {
            if (this.dgrLocalidades.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione una localidad");
            }
            else
            {
                MessageBoxResult resultadoEliminar = MessageBox.Show("¿Seguro que desea eliminar esta localidad?", "Aviso", MessageBoxButton.YesNo);

                if (resultadoEliminar == MessageBoxResult.Yes)
                {
                    int fila = this.dgrLocalidades.SelectedIndex;
                    int idLocalidad = this.listaLocalidades[fila].idLocalidad;
                    if (consultas.consultaIncendiosEnLocalidad(idLocalidad))
                    {
                        MessageBox.Show("Esta localidad contiene incendios y no se puede eliminar");
                    }
                    else
                    {
                        consultas.eliminarLocalidad(idLocalidad);
                        MessageBox.Show("Localidad y datos meteorologicos borrados");
                        cargarDgrLocalidades();
                    }
                }

            }
        }
        private void AccederVentanaAñadirLocalidad(Object sender, ExecutedRoutedEventArgs e)
        {
            VentanaAñadirLocalidades añadirLocalidad = new VentanaAñadirLocalidades();
            this.Hide();
            añadirLocalidad.ShowDialog();
            this.Show();
            cargarDgrLocalidades();
        }

        private void AccederVentanaModificacionLocalidad(Object sender, ExecutedRoutedEventArgs e)
        {
            if (this.dgrLocalidades.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione una localidad");
            }
            else
            {
                int fila = this.dgrLocalidades.SelectedIndex;
                localidad LocalidadAModificar = this.listaLocalidades[fila];
                VentanaModificarLocalidades añadirLocalidad = new VentanaModificarLocalidades(LocalidadAModificar);
                this.Hide();
                añadirLocalidad.ShowDialog();
                this.Show();
                cargarDgrLocalidades();

            }
        }

        private void cargarDgrLocalidades()
        {
            this.dgrLocalidades.ItemsSource = null;
            this.listaDGRLocalidades.Clear();
            this.listaLocalidades = consultas.obtenerLocalidades();
            foreach (var localidad in listaLocalidades)
            {
                int idProvincia = localidad.idProvincia;
                String provincia = consultas.consultarNombreProvincia(idProvincia);
                LocalidadesAVisualizar localidadNueva = new LocalidadesAVisualizar(localidad.nombreLocalidad, provincia);
                this.listaDGRLocalidades.Add(localidadNueva);
            }
            this.dgrLocalidades.ItemsSource = listaDGRLocalidades;
            dgrLocalidades.Columns[0].Header = "Nombre de la Localidad";
            dgrLocalidades.Columns[1].Header = "Nombre de la Provincia";
        }

    }
}

