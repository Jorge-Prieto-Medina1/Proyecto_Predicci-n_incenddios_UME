//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoIncediosUME_JorgePrieto
{
    using System;
    using System.Collections.Generic;
    
    public partial class Incendio
    {
        public int idIncendio { get; set; }
        public int idLocalidad { get; set; }
        public int idProvincia { get; set; }
        public Nullable<int> hectareasQuemadas { get; set; }
        public Nullable<double> temperaturaMedia { get; set; }
        public Nullable<double> humedadMedia { get; set; }
        public Nullable<System.DateTime> fechaDeInicio { get; set; }
        public Nullable<System.DateTime> fechaDeExtinción { get; set; }
    
        public virtual localidad localidad { get; set; }
        public virtual provincia provincia { get; set; }
    }
}
