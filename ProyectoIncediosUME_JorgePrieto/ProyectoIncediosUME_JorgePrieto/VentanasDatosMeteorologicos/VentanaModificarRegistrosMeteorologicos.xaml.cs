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
    /// Lógica de interacción para VentanaModificarRegistrosMeteorologicos.xaml
    /// </summary>

    public partial class VentanaModificarRegistrosMeteorologicos : Window
    {

        ClaseConsultas consultas = new ClaseConsultas();
        Boolean cargado = false;
        datoMeteorologico datoOriginal = new datoMeteorologico();

        public VentanaModificarRegistrosMeteorologicos(datoMeteorologico DatoOriginal)
        {
            InitializeComponent();
            this.datoOriginal = DatoOriginal;
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cargado = true;
            cargarDato();
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


        private void Modificar(Object sender, ExecutedRoutedEventArgs e)
        {
            
            String temperatura = this.txtTempMed.Text.Trim();
            String humedad = this.txtHumMed.Text.Trim();
            String fechaInicio = this.dpkFechaInicio.SelectedDate.Value.Date.ToShortDateString();
            String fechaFinalizacion = this.dpkFechaFinalizacion.SelectedDate.Value.Date.ToShortDateString();
            if (temperatura.Length != 0 && humedad.Length != 0 && fechaInicio.Length != 0 && fechaFinalizacion.Length != 0)
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
                            int IdLocalidad = datoOriginal.idLocalidad;
                            int IdDato = datoOriginal.idDato;

                            if (consultas.buscarDatoConMismaFechaModificar(IdDato, IdLocalidad, fechaInicioDate, fechaFinalizacionDate))
                            {
                                MessageBox.Show("Ya existe un dato climatologico en esa localidad en esa fecha");
                            }
                            else
                            {
                                datoMeteorologico datoMeteorologicoModificar = new datoMeteorologico();
                                datoMeteorologicoModificar.idLocalidad = IdLocalidad;
                                datoMeteorologicoModificar.idDato = datoOriginal.idDato;
                                datoMeteorologicoModificar.humedadMedia = humInt;
                                datoMeteorologicoModificar.temperaturaMedia = tempInt;
                                datoMeteorologicoModificar.fechaDeInicio = fechaInicioDate;
                                datoMeteorologicoModificar.fechaDeFinalizacion = fechaFinalizacionDate;
                                consultas.modificarDato(datoMeteorologicoModificar);
                                MessageBox.Show("Dato climatologico modificado con exito");
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
        }

        private void cargarDato()
        {
            int idLocalidad = this.datoOriginal.idLocalidad;
            String[] nombres = consultas.buscarNombreLocalidadPrivincia(idLocalidad);
            this.txtLocalidad.Text = nombres[0];
            this.txtProvincia.Text = nombres[1];
            this.txtHumMed.Text = datoOriginal.humedadMedia.ToString();
            this.txtTempMed.Text = datoOriginal.temperaturaMedia.ToString();
            this.dpkFechaInicio.SelectedDate = datoOriginal.fechaDeInicio;
            this.dpkFechaFinalizacion.SelectedDate = datoOriginal.fechaDeFinalizacion;
        }
    }
}



