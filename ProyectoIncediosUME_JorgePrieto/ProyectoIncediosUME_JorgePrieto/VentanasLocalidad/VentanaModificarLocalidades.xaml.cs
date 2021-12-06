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
    /// 
    public partial class VentanaModificarLocalidades : Window
    {

        ClaseConsultas consultas = new ClaseConsultas();
        Boolean cargado = false;
        localidad localidadOriginal = new localidad();

        public VentanaModificarLocalidades(localidad LocalidadOriginal)
        {
            InitializeComponent();
            this.localidadOriginal = LocalidadOriginal;
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cargado = true;
            cargarLocalidad();
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
            String nombreProvincia = this.txtProvincia.Text.ToString();
            String nombreLocalidad = this.txtNombreLocalidad.Text.ToString().Trim();
            String temperaturaMediaPrimavera = this.txtTempPrim.Text.ToString();
            String temperaturaMediaVerano = this.txtTempVer.Text.ToString();
            String temperaturaMediaOtoño = this.txtTempOto.Text.ToString();
            String temperaturaMediaInvierno = this.txtTempInv.Text.ToString();

            String humedadMediaPrimavera = this.txtHumPrim.Text.ToString();
            String humedadMediaVerano = this.txtHumVer.Text.ToString();
            String humedadMediaOtoño = this.txtHumOto.Text.ToString();
            String humedadMediaInvierno = this.txtHumInv.Text.ToString();
            if (temperaturaMediaPrimavera.Trim().Length == 0 || temperaturaMediaVerano.Trim().Length == 0 || temperaturaMediaOtoño.Trim().Length == 0 || temperaturaMediaInvierno.Trim().Length == 0
                || humedadMediaPrimavera.Trim().Length == 0 || humedadMediaVerano.Trim().Length == 0 || humedadMediaOtoño.Trim().Length == 0 || humedadMediaInvierno.Trim().Length == 0)
            {
                MessageBox.Show("Por favor rellene todos los campos");
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

                        int idProvincia = consultas.buscarIdProvincia(nombreProvincia);
                        localidad localidadModificada = new localidad();
                        localidadModificada.idLocalidad = localidadOriginal.idLocalidad;
                        localidadModificada.idProvincia = idProvincia;
                        localidadModificada.nombreLocalidad = nombreLocalidad;
                        localidadModificada.temperaturaMediaPrimavera = int.Parse(temperaturaMediaPrimavera);
                        localidadModificada.temperaturaMediaVerano = int.Parse(temperaturaMediaVerano);
                        localidadModificada.temperaturaMediaOtoño = int.Parse(temperaturaMediaOtoño);
                        localidadModificada.temperaturaMediaInvierno = int.Parse(temperaturaMediaInvierno);
                        localidadModificada.humedadMediaPrimavera = int.Parse(humedadMediaPrimavera);
                        localidadModificada.humedadMediaVerano = int.Parse(humedadMediaVerano);
                        localidadModificada.humedadMediaOtoño = int.Parse(humedadMediaOtoño);
                        localidadModificada.humedadMediaInvierno = int.Parse(humedadMediaInvierno);
                        consultas.modificarLocalidad(localidadModificada);
                        MessageBox.Show("Localidad modificado con exito");
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

        private void cargarLocalidad()
        {
            int idProvincia = this.localidadOriginal.idProvincia;
            this.txtProvincia.Text = consultas.buscarNombreProvincia(idProvincia);
            this.txtNombreLocalidad.Text = localidadOriginal.nombreLocalidad;
            this.txtTempPrim.Text = localidadOriginal.temperaturaMediaPrimavera.ToString();
            this.txtTempVer.Text = localidadOriginal.temperaturaMediaVerano.ToString();
            this.txtTempOto.Text = localidadOriginal.temperaturaMediaOtoño.ToString();
            this.txtTempInv.Text = localidadOriginal.temperaturaMediaInvierno.ToString();
            this.txtHumPrim.Text = localidadOriginal.humedadMediaPrimavera.ToString();
            this.txtHumVer.Text = localidadOriginal.humedadMediaVerano.ToString();
            this.txtHumOto.Text = localidadOriginal.humedadMediaOtoño.ToString();
            this.txtHumInv.Text = localidadOriginal.humedadMediaInvierno.ToString();
        }
    }
}

