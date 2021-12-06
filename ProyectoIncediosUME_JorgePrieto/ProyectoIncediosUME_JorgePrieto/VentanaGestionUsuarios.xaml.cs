using ProyectoIncediosUME_JorgePrieto.Clases;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// Lógica de interacción para VentanaGestionUsuarios.xaml
    /// </summary>
    public partial class VentanaGestionUsuarios : Window
    {
        ClaseLogin infoUsuario;
        ClaseConsultas consultas = new ClaseConsultas();
        Boolean cargado = false;
        List<usuario> listaUsuarios;

        public VentanaGestionUsuarios(ClaseLogin InfoUsuario)
        {
            this.infoUsuario = InfoUsuario;
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            cargado = true;
            cargarDgrUsuarios();

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


        private void Activar_Desactivar(Object sender, ExecutedRoutedEventArgs e)
        {

            if (this.dgrUsuarios.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un usuario");
                
            }
            else
            {
                int fila = this.dgrUsuarios.SelectedIndex;
                String CorreoUsuarioElegido = this.listaUsuarios[fila].correoUsuario;
                consultas.modificarUsuario(CorreoUsuarioElegido);
                cargarDgrUsuarios();

            }
        }

        private void EliminarUsuario(Object sender, ExecutedRoutedEventArgs e)
        {

            if (this.dgrUsuarios.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un usuario");
            }
            else
            {
                MessageBoxResult resultadoEliminar = MessageBox.Show("¿Seguro que desea eliminar este usuario?", "Aviso", MessageBoxButton.YesNo);

                if (resultadoEliminar == MessageBoxResult.Yes)
                {
                    int fila = this.dgrUsuarios.SelectedIndex;
                    String CorreoUsuarioElegido = this.listaUsuarios[fila].correoUsuario;
                    consultas.eliminarUsuario(CorreoUsuarioElegido);
                    cargarDgrUsuarios();
                }

            }
        }

        private void Salir(Object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }

        private void cargarDgrUsuarios()
        {
            this.listaUsuarios = consultas.obtenerUsuarios(infoUsuario.correoUsuario);
            this.dgrUsuarios.ItemsSource = listaUsuarios;
                
            dgrUsuarios.ItemsSource = listaUsuarios;
            dgrUsuarios.Columns[0].Visibility = Visibility.Hidden;
            dgrUsuarios.Columns[1].Header = "Nombre Del Usuario";
            dgrUsuarios.Columns[2].Header = "Correo Del Usuario";
            dgrUsuarios.Columns[3].Header = "Contraseña Del Usuario";
            dgrUsuarios.Columns[4].Header = "Activo";
        }
    }
}
