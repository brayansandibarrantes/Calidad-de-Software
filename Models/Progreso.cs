//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NutriHub.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Progreso
    {
        public decimal idProgreso { get; set; }
        public decimal paciente { get; set; }
        public int talla { get; set; }
        public decimal peso { get; set; }
        public decimal porcentAgua { get; set; }
        public decimal porcentMusculo { get; set; }
        public decimal porcentGrasa { get; set; }
        public decimal circunfBraquial { get; set; }
        public decimal circunfPantorrilla { get; set; }
        public int edad { get; set; }
        public System.DateTime fecha { get; set; }
    
        public virtual Paciente Paciente1 { get; set; }
    }
}
