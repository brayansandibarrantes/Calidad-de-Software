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
    
    public partial class Cita
    {
        public decimal idCita { get; set; }
        public decimal idNutricionista { get; set; }
        public decimal idPaciente { get; set; }
        public System.DateTime fecha { get; set; }
        public System.TimeSpan hora { get; set; }
        public bool estado { get; set; }
    
        public virtual Nutricionista Nutricionista { get; set; }
        public virtual Paciente Paciente { get; set; }
    }
}
