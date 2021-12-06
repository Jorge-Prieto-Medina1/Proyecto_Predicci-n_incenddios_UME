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
        Incendio incendioOriginal = new Incendio();

        public VentanaMoficarIncendio(Incendio IncendioOriginal)
        {
            InitializeComponent();
            this.incendioOriginal = IncendioOriginal;
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cargado = true;
            cargarIncendio();
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

            String localidad = this.txtLocalidades.Text;
            String hecateas = this.txtHectareas.Text.Trim();
            String temperatura = this.txtTempMed.Text.Trim();
            String humedad = this.txtHumMed.Text.Trim();
            String fechaInicio = this.dpkFechaInicio.SelectedDate.Value.Date.ToShortDateString();
            String fechaExtincion = this.dpkFechaExtincion.SelectedDate.Value.Date.ToShortDateString();
            if (localidad.Length != 0 && hecateas.Length != 0 && temperatura.Length != 0 && humedad.Length != 0 && fechaInicio.Length != 0 && fechaExtincion.Length != 0)
            {
                if (int.TryParse(temperatura, out _) && int.TryParse(humedad, out _) && int.TryParse(hecateas, out _))
                {
                    DateTime fechaInicioDate = Convert.ToDateTime(fechaInicio);
                    DateTime fechaExtincionDate = Convert.ToDateTime(fechaExtincion);
                    if (fechaInicioDate < fechaExtincionDate)
                    {
                        int tempInt = int.Parse(temperatura);
                        int humInt = int.Parse(humedad);
                        int hecInt = int.Parse(hecateas);
                        if ((tempInt <= 60 && tempInt >= -60) && (humInt <= 100 && humInt >= 0))
                        {
                            Incendio incendioModificar = new Incendio();
                            int IdLocalidad = incendioOriginal.idLocalidad;
                            incendioModificar.idLocalidad = IdLocalidad;
                            incendioModificar.humedadMedia = humInt;
                            incendioModificar.temperaturaMedia = tempInt;
                            incendioModificar.hectareasQuemadas = hecInt;
                            incendioModificar.fechaDeInicio = fechaInicioDate;
                            incendioModificar.fechaDeExtinción = fechaExtincionDate;
                            consultas.modificarIncendio(incendioModificar);
                            MessageBox.Show("Incendio modificado con exito");
                            this.Close();
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
                    MessageBox.Show("La temperatura, humedad y hectareas han de se numeros");
                }
            }
            else
            {
                MessageBox.Show("Rellene todos los campos");
            }



        }

        private void cargarIncendio()
        {
            int idLocalidad = this.incendioOriginal.idLocalidad;
            String[] nombres = consultas.buscarNombreLocalidadPrivincia(idLocalidad);
            this.txtLocalidades.Text = nombres[0];
            this.txtProvincia.Text = nombres[1];
            this.txtHectareas.Text = incendioOriginal.hectareasQuemadas.ToString();
            this.txtHumMed.Text = incendioOriginal.humedadMedia.ToString();
            this.txtTempMed.Text = incendioOriginal.temperaturaMedia.ToString();
            this.dpkFechaInicio.SelectedDate = incendioOriginal.fechaDeInicio;
            this.dpkFechaExtincion.SelectedDate = incendioOriginal.fechaDeExtinción;
        }
    }
}

