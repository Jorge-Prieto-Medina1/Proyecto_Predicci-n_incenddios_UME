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
    /// Lógica de interacción para VentanaMoficarIncendio.xaml
    /// </summary>
    public partial class VentanaMoficarIncendio : Window
    {
        ClaseConsultas consultas = new ClaseConsultas();
        Boolean cargado = false;
        List<Incendio> listaIncendios;
        List<IncendiosAVisualizar> listaDGRIncendios = new List<IncendiosAVisualizar>();
        ClaseLogin infoUsuario;

           
        public VentanaMoficarIncendio(ClaseLogin InfoUsuario
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

        private void cargarDgrIncendios()
        {
            this.dgrIncendios.ItemsSource = null;
            this.listaDGRIncendios.Clear();
            this.listaIncendios = consultas.obtenerLocalidades();
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
