#pragma checksum "..\..\..\VentanasDatosMeteorologicos\VentanaRegistrosMeteorologicos.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "404DEBC6EC1DE1F4F22E3C47D04349BCF946B308604B2302ADF740C1B297641F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using ProyectoIncediosUME_JorgePrieto.Clases;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace ProyectoIncediosUME_JorgePrieto.VentanasDatosMeteorologicos {
    
    
    /// <summary>
    /// VentanaRegistrosMeteorologicos
    /// </summary>
    public partial class VentanaRegistrosMeteorologicos : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\VentanasDatosMeteorologicos\VentanaRegistrosMeteorologicos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAñadirDato;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\VentanasDatosMeteorologicos\VentanaRegistrosMeteorologicos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEliminarDato;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\VentanasDatosMeteorologicos\VentanaRegistrosMeteorologicos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnVolverAtras;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\VentanasDatosMeteorologicos\VentanaRegistrosMeteorologicos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgrDatosMeteorologicos;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\VentanasDatosMeteorologicos\VentanaRegistrosMeteorologicos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnModificarDato;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ProyectoIncediosUME_JorgePrieto;component/ventanasdatosmeteorologicos/ventanareg" +
                    "istrosmeteorologicos.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\VentanasDatosMeteorologicos\VentanaRegistrosMeteorologicos.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\VentanasDatosMeteorologicos\VentanaRegistrosMeteorologicos.xaml"
            ((ProyectoIncediosUME_JorgePrieto.VentanasDatosMeteorologicos.VentanaRegistrosMeteorologicos)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 10 "..\..\..\VentanasDatosMeteorologicos\VentanaRegistrosMeteorologicos.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.CompruebaSalir);
            
            #line default
            #line hidden
            
            #line 10 "..\..\..\VentanasDatosMeteorologicos\VentanaRegistrosMeteorologicos.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.Salir);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 11 "..\..\..\VentanasDatosMeteorologicos\VentanaRegistrosMeteorologicos.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.CompruebaModificaciones);
            
            #line default
            #line hidden
            
            #line 11 "..\..\..\VentanasDatosMeteorologicos\VentanaRegistrosMeteorologicos.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.BorrarRegistro);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 12 "..\..\..\VentanasDatosMeteorologicos\VentanaRegistrosMeteorologicos.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.CompruebaModificaciones);
            
            #line default
            #line hidden
            
            #line 12 "..\..\..\VentanasDatosMeteorologicos\VentanaRegistrosMeteorologicos.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.AñadirRegistro);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 13 "..\..\..\VentanasDatosMeteorologicos\VentanaRegistrosMeteorologicos.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.CompruebaModificaciones);
            
            #line default
            #line hidden
            
            #line 13 "..\..\..\VentanasDatosMeteorologicos\VentanaRegistrosMeteorologicos.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.ModificarRegistro);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnAñadirDato = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.btnEliminarDato = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.btnVolverAtras = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            this.dgrDatosMeteorologicos = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 10:
            this.btnModificarDato = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

