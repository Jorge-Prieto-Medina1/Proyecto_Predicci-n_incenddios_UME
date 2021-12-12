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
    /// Lógica de interacción para VentanaAñadirIncendio.xaml
    /// </summary>
    
    public partial class VentanaAñadiorRegistrosMeteorologicos : Window
    {

        ClaseConsultas consultas = new ClaseConsultas();
        Boolean cargado = false;


        public VentanaAñadiorRegistrosMeteorologicos()
        {
            InitializeComponent();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cargado = true;
            this.dpkFechaInicio.SelectedDate = DateTime.Now;
            this.dpkFechaFinalizacion.SelectedDate = DateTime.Now;
            cargarCmbProvincias();
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
            this.Close();
        }


        private void Añdair(Object sender, ExecutedRoutedEventArgs e)
        {
            if (this.cmbLocalidades.SelectedIndex != -1 && this.cmbLocalidades.SelectedIndex != -1)
            {
                String localidad = this.cmbLocalidades.SelectedItem.ToString().Trim();
                String temperatura = this.txtTempMed.Text.Trim();
                String humedad = this.txtHumMed.Text.Trim();
                String fechaInicio = this.dpkFechaInicio.SelectedDate.Value.Date.ToShortDateString();
                String fechaFinalizacion = this.dpkFechaFinalizacion.SelectedDate.Value.Date.ToShortDateString();
                if (localidad.Length != 0 && temperatura.Length != 0 && humedad.Length != 0 && fechaInicio.Length != 0 && fechaFinalizacion.Length != 0)
                {
                    if (int.TryParse(temperatura, out _) && int.TryParse(humedad, out _))
                    {
                        DateTime fechaInicioDate = Convert.ToDateTime(fechaInicio);
                        DateTime fechaFinalizacionDate = Convert.ToDateTime(fechaFinalizacion);
                        if (fechaInicioDate < fechaFinalizacionDate)
                        {
                            int tempInt = int.Parse(temperatura);
                            int humInt = int.Parse(humedad);
                            if ((tempInt <= 60 && tempInt >= -60) && (humInt <= 100 && humInt >= 0))
                            {
                                int idProvincia = consultas.buscarIdProvincia(this.cmbProvincias.Text);
                                int IdLocalidad = consultas.buscarIdLocalidad(idProvincia, localidad);

                                if (consultas.buscarDatoConMismaFecha(IdLocalidad, fechaInicioDate, fechaFinalizacionDate))
                                {
                                    MessageBox.Show("Ya existe un dato climatologico en esa localidad en esa fecha");
                                }
                                else
                                {
                                    datoMeteorologico datoMeteorologicoAñadir = new datoMeteorologico();
                                    datoMeteorologicoAñadir.idLocalidad = IdLocalidad;
                                    datoMeteorologicoAñadir.humedadMedia = humInt;
                                    datoMeteorologicoAñadir.temperaturaMedia = tempInt;
                                    datoMeteorologicoAñadir.fechaDeInicio = fechaInicioDate;
                                    datoMeteorologicoAñadir.fechaDeFinalizacion = fechaFinalizacionDate;
                                    consultas.insertarDato(datoMeteorologicoAñadir);
                                    MessageBox.Show("Dato climatologico insertado con exito");
                                    this.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("La temperatura no puede ser ni superior a 60 ni inferior a - 60 y la humedad no puede ser negativa ni superior a 100");
                            }
                        }
                        else
                        {
                            MessageBox.Show("La fecha de inicio no puede ser mayor a la de extinción");
                        }

                    }
                    else
                    {
                        MessageBox.Show("La temperatura y humedad han de se numeros");
                    }
                }
                else
                {
                    MessageBox.Show("Rellene todos los campos");
                }
            }

            else
            {
                MessageBox.Show("Por favor seleccione una localidad");
            }

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





