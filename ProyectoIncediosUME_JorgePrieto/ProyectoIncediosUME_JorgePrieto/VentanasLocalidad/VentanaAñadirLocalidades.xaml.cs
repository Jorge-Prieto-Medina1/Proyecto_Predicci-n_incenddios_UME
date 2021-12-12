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

    public partial class VentanaAñadirLocalidades : Window
    {

        ClaseConsultas consultas = new ClaseConsultas();
        Boolean cargado = false;


        public VentanaAñadirLocalidades()
        {
            InitializeComponent();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cargado = true;
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
            if (this.cmbProvincias.SelectedIndex != -1)
            {
                String nombreProvincia = this.cmbProvincias.SelectedItem.ToString();
                String nombreLocalidad = this.txtNombreLocalidad.Text.ToString().Trim();
                String temperaturaMediaPrimavera = this.txtTempPrim.Text.ToString();
                String temperaturaMediaVerano = this.txtTempVer.Text.ToString();
                String temperaturaMediaOtoño = this.txtTempOto.Text.ToString();
                String temperaturaMediaInvierno = this.txtTempInv.Text.ToString();

                String humedadMediaPrimavera = this.txtHumPrim.Text.ToString();
                String humedadMediaVerano = this.txtHumVer.Text.ToString();
                String humedadMediaOtoño = this.txtHumOto.Text.ToString();
                String humedadMediaInvierno = this.txtHumInv.Text.ToString();
                if (nombreLocalidad.Trim().Length == 0 || temperaturaMediaPrimavera.Trim().Length == 0 || temperaturaMediaVerano.Trim().Length == 0 || temperaturaMediaOtoño.Trim().Length == 0 || temperaturaMediaInvierno.Trim().Length == 0
                    || humedadMediaPrimavera.Trim().Length == 0 || humedadMediaVerano.Trim().Length == 0 || humedadMediaOtoño.Trim().Length == 0 || humedadMediaInvierno.Trim().Length == 0)
                {
                    MessageBox.Show("Por favor rellene todos los campos");
                }
                else
                {
                    int idProvincia = consultas.buscarIdProvincia(nombreProvincia);
                    if (consultas.consultarLocalidad(nombreLocalidad, idProvincia))
                    {
                        MessageBox.Show("Ya existe una localidad con ese nombre en la provincia seleccionada");
                    }
                    else
                    {

                        if (int.TryParse(temperaturaMediaPrimavera, out _) && int.TryParse(temperaturaMediaVerano, out _) && int.TryParse(temperaturaMediaOtoño, out _) && int.TryParse(temperaturaMediaInvierno, out _)
                            && int.TryParse(humedadMediaPrimavera, out _) && int.TryParse(humedadMediaVerano, out _) && int.TryParse(humedadMediaOtoño, out _) && int.TryParse(humedadMediaInvierno, out _))
                        {
                            int tempPrimInt = int.Parse(temperaturaMediaPrimavera);
                            int tempVerInt = int.Parse(temperaturaMediaVerano);
                            int tempOtoInt = int.Parse(temperaturaMediaOtoño);
                            int tempInvInt = int.Parse(temperaturaMediaInvierno);
                            int humPrimInt = int.Parse(humedadMediaPrimavera);
                            int humVerInt = int.Parse(humedadMediaVerano);
                            int humOtoInt = int.Parse(humedadMediaOtoño);
                            int humInvInt = int.Parse(humedadMediaInvierno);

                            if ((tempPrimInt <= 60 && tempPrimInt >= -60) && (tempVerInt <= 60 && tempVerInt >= -60) && (tempOtoInt <= 60 && tempOtoInt >= -60) && (tempInvInt <= 60 && tempInvInt >= -60)
                                && (humPrimInt <= 100 && humPrimInt >= 0) && (humVerInt <= 100 && humVerInt >= 0) && (humOtoInt <= 100 && humOtoInt >= 0) && (humInvInt <= 100 && humInvInt >= 0))
                            {
                                localidad localidadAñadir = new localidad();
                                localidadAñadir.idProvincia = idProvincia;
                                localidadAñadir.nombreLocalidad = nombreLocalidad;
                                localidadAñadir.temperaturaMediaPrimavera = int.Parse(temperaturaMediaPrimavera);
                                localidadAñadir.temperaturaMediaVerano = int.Parse(temperaturaMediaVerano);
                                localidadAñadir.temperaturaMediaOtoño = int.Parse(temperaturaMediaOtoño);
                                localidadAñadir.temperaturaMediaInvierno = int.Parse(temperaturaMediaInvierno);
                                localidadAñadir.humedadMediaPrimavera = int.Parse(humedadMediaPrimavera);
                                localidadAñadir.humedadMediaVerano = int.Parse(humedadMediaVerano);
                                localidadAñadir.humedadMediaOtoño = int.Parse(humedadMediaOtoño);
                                localidadAñadir.humedadMediaInvierno = int.Parse(humedadMediaInvierno);
                                consultas.insertarLocalidad(localidadAñadir);
                                MessageBox.Show("Localidad insertada con exito");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("La temperatura no puede ser ni superior a 60 ni inferior a - 60 y la humedad no puede ser negativa ni superior a 100");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Por favor no introduzca letras ni numeros decimales, la temperatura y la humedad media se registran usando enteros");
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione una provincia");
            }

        }


        private void cargarCmbProvincias()
        {
            List<String> listaProvincias = consultas.cargarProvincias();
            this.cmbProvincias.ItemsSource = listaProvincias;
            this.cmbProvincias.SelectedIndex = 0;
        }
    }

}

