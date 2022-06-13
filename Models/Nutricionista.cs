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
    
    public partial class Nutricionista
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Nutricionista()
        {
            this.Cita = new HashSet<Cita>();
            this.PlanNutricional = new HashSet<PlanNutricional>();
        }
    
        public decimal cedula { get; set; }
        public decimal licencia { get; set; }
        public bool sexo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cita> Cita { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlanNutricional> PlanNutricional { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
