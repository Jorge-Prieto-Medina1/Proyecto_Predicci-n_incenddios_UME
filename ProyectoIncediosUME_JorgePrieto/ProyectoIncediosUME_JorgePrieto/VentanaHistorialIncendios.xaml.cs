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
    /// Lógica de interacción para VentanaHistorialIncendios.xaml
    /// </summary>
    public partial class VentanaHistorialIncendios : Window
    {

        ClaseConsultas consultas = new ClaseConsultas();
        Boolean cargado = false;
        List<IncendiosAVisualizar> listaDGRIncendios = new List<IncendiosAVisualizar>();
        List<Incendio> listaIncendios;

        public VentanaHistorialIncendios()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cargado = true;
            cargarDgrIncendios();
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

        private void Salir(Object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }

        private void Buscar(Object sender, ExecutedRoutedEventArgs e)
        {
            dgrIncendios.ItemsSource = null;

            using (prediccion_incendiosEntitiesDB BaseDeDatos = new prediccion_incendiosEntitiesDB())
            {


                var incendios = from busqueda in BaseDeDatos.Incendio
                                select new { busqueda.idLocalidad, busqueda.idIncendio, busqueda.temperaturaMedia, busqueda.humedadMedia, busqueda.hectareasQuemadas , busqueda.fechaDeInicio, busqueda.fechaDeExtinción };



                if (!cmbLocalidades.Text.Equals(""))
                {
                    String Provincia = this.cmbProvincias.Text;
                    int IdProvincia = consultas.buscarIdProvincia(Provincia);
                    String Localidad = this.cmbLocalidades.Text;
                    int IdLocalidad = consultas.buscarIdLocalidad(IdProvincia, Localidad);
                    incendios = incendios.Where(x => x.idLocalidad == IdLocalidad);
                }

                if (!dpkDesde.Text.Equals(""))
                {
                    DateTime desde = Convert.ToDateTime(this.dpkDesde.SelectedDate.Value.Date.ToShortDateString());
                    incendios = incendios.Where(x => x.fechaDeInicio >= desde);
                }

                if (!dpkHasta.Text.Equals(""))
                {
                    DateTime hasta = Convert.ToDateTime(this.dpkHasta.SelectedDate.Value.Date.ToShortDateString());
                    incendios = incendios.Where(x => x.fechaDeInicio <= hasta);
                }

                this.listaDGRIncendios.Clear();

                if (!cmbProvincias.Text.Equals("") && cmbLocalidades.Text.Equals(""))
                {
                    String Provincia = cmbProvincias.Text;
                    foreach (var incendio in incendios)
                    {
                        int idLocalidad = incendio.idLocalidad;
                        String[] nombres = consultas.buscarNombreLocalidadPrivincia(idLocalidad);
                        IncendiosAVisualizar incendioNuevo = new IncendiosAVisualizar(nombres[0], nombres[1], incendio.temperaturaMedia.Value, incendio.humedadMedia.Value, incendio.hectareasQuemadas.Value, incendio.fechaDeInicio.ToString().Substring(0, 10), incendio.fechaDeExtinción.ToString().Substring(0, 10));
                        if (incendioNuevo.nombreProvincia == Provincia)
                        {
                            this.listaDGRIncendios.Add(incendioNuevo);
                        }
                           
                    }
                }
                else
                {
                    foreach (var incendio in incendios)
                    {
                        int idLocalidad = incendio.idLocalidad;
                        String[] nombres = consultas.buscarNombreLocalidadPrivincia(idLocalidad);
                        IncendiosAVisualizar incendioNuevo = new IncendiosAVisualizar(nombres[0], nombres[1], incendio.temperaturaMedia.Value, incendio.humedadMedia.Value, incendio.hectareasQuemadas.Value, incendio.fechaDeInicio.ToString().Substring(0, 10), incendio.fechaDeExtinción.ToString().Substring(0, 10));
                        this.listaDGRIncendios.Add(incendioNuevo);
                    }
                }

              
                this.dgrIncendios.ItemsSource = listaDGRIncendios;
                dgrIncendios.Columns[0].Header = "Nombre de la Provincia";
                dgrIncendios.Columns[1].Header = "Nombre de la Localidad";
                dgrIncendios.Columns[2].Header = "Temperatura Media";
                dgrIncendios.Columns[3].Header = "Humedad media";
                dgrIncendios.Columns[4].Header = "Hectareas quemadas";
                dgrIncendios.Columns[5].Header = "Fecha de inicio";
                dgrIncendios.Columns[6].Header = "Fecha de extinción";


            }
        }

        private void Limpiar(Object sender, ExecutedRoutedEventArgs e)
        {
            this.cmbLocalidades.SelectedIndex = -1;
            this.dpkDesde.SelectedDate = null;
            this.dpkHasta.SelectedDate = null;
            cargarDgrIncendios();
        }

        private void cargarCmbProvincias()
        {
            List<String> listaProvincias = consultas.cargarProvincias();
            this.cmbProvincias.ItemsSource = listaProvincias;
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

        private void cargarDgrIncendios()
        {
            this.dgrIncendios.ItemsSource = null;
            this.listaDGRIncendios.Clear();
            this.listaIncendios = consultas.obtenerIncendios();
            foreach (var incendio in listaIncendios)
            {
                int idLocalidad = incendio.idLocalidad;
                String[] nombres = consultas.buscarNombreLocalidadPrivincia(idLocalidad);
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
