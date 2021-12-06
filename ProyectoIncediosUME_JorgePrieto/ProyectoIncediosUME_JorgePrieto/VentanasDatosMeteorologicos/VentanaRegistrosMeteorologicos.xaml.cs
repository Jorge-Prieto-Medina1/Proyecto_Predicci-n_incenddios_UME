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

namespace ProyectoIncediosUME_JorgePrieto.VentanasDatosMeteorologicos
{
    /// <summary>
    /// Lógica de interacción para VentanaRegistrosMeteorologicos.xaml
    /// </summary>
    public partial class VentanaRegistrosMeteorologicos : Window
    {
        ClaseConsultas consultas = new ClaseConsultas();
        Boolean cargado = false;
        List<datoMeteorologico> listaDatos;
        List<DatosMeteorologicosAVisualizar> listaDGRDatos = new List<DatosMeteorologicosAVisualizar>();
        ClaseLogin infoUsuario;


        public VentanaRegistrosMeteorologicos(ClaseLogin InfoUsuario)
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
            VentanaAñadiorRegistrosMeteorologicos añadirIncendio = new VentanaAñadiorRegistrosMeteorologicos();
            this.Hide();
            añadirIncendio.ShowDialog();
            this.Show();
            cargarDgrIncendios();
        }

        private void BorrarRegistro(Object sender, ExecutedRoutedEventArgs e)
        {
            if (this.dgrDatosMeteorologicos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un incendio");
            }
            else
            {
                MessageBoxResult resultadoEliminar = MessageBox.Show("¿Seguro que desea eliminar este dato climatologico?", "Aviso", MessageBoxButton.YesNo);

                if (resultadoEliminar == MessageBoxResult.Yes)
                {
                    int fila = this.dgrDatosMeteorologicos.SelectedIndex;
                    int idDato = this.listaDatos[fila].idDato;
                    consultas.eliminarDato(idDato);
                    MessageBox.Show("Dato climatologico eliminado");
                    cargarDgrIncendios();

                }

            }
        }

        private void ModificarRegistro(Object sender, ExecutedRoutedEventArgs e)
        {
            if (this.dgrDatosMeteorologicos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un incendio");
            }
            else
            {
                int fila = this.dgrDatosMeteorologicos.SelectedIndex;
                datoMeteorologico datoAModificar = this.listaDatos[fila];
                VentanaModificarRegistrosMeteorologicos modificarDato = new VentanaModificarRegistrosMeteorologicos();
                this.Hide();
                modificarDato.ShowDialog();
                this.Show();
                cargarDgrIncendios();

            }
        }

        private void cargarDgrIncendios()
        {
            this.dgrDatosMeteorologicos.ItemsSource = null;
            this.listaDGRDatos.Clear();
            this.listaDatos = consultas.ObtenerDatosClimatologicos();
            foreach (var dato in listaDatos)
            {
                int idLocalidad = dato.idLocalidad;
                String[] nombres = consultas.buscarNombreLocalidadPrivincia(idLocalidad);
                DatosMeteorologicosAVisualizar datoNuevo = new DatosMeteorologicosAVisualizar(nombres[0], nombres[1], dato.temperaturaMedia.ToString() , dato.fechaDeInicio.ToString().Substring(0, 10), dato.fechaDeFinalizacion.ToString().Substring(0, 10));
                this.listaDGRDatos.Add(datoNuevo);
            }
            this.dgrDatosMeteorologicos.ItemsSource = listaDGRDatos;
            dgrDatosMeteorologicos.Columns[0].Header = "Nombre de la Provincia";
            dgrDatosMeteorologicos.Columns[1].Header = "Nombre de la Localidad";
            dgrDatosMeteorologicos.Columns[2].Header = "Temperatura media";
            dgrDatosMeteorologicos.Columns[3].Header = "Fecha de inicio";
            dgrDatosMeteorologicos.Columns[4].Header = "Fecha de finalización";
        }
    }
}