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
    
    public partial class PadecimientoPaciente
    {
        public decimal idPadecimiento { get; set; }
        public decimal paciente { get; set; }
        public Nullable<System.DateTime> fechaDiagnostico { get; set; }
    
        public virtual Paciente Paciente1 { get; set; }
        public virtual Padecimiento Padecimiento { get; set; }
    }
}
