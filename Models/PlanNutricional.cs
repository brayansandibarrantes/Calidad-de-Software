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
    
    public partial class PlanNutricional
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PlanNutricional()
        {
            this.PacientePlanNutricional = new HashSet<PacientePlanNutricional>();
        }
    
        public decimal idPlan { get; set; }
        public decimal nutricionista { get; set; }
        public decimal idIngesta { get; set; }
        public decimal idAlimento { get; set; }
        public decimal idNutriente { get; set; }
        public decimal vet { get; set; }
        public int tiempoComida { get; set; }
        public decimal porcion { get; set; }
        public string proposito { get; set; }
        public int dia { get; set; }
    
        public virtual Alimento Alimento { get; set; }
        public virtual IngestaDiaria IngestaDiaria { get; set; }
        public virtual Nutricionista Nutricionista1 { get; set; }
        public virtual Nutriente Nutriente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PacientePlanNutricional> PacientePlanNutricional { get; set; }
        public virtual semana semana { get; set; }
        public virtual tiempoComida tiempoComida1 { get; set; }
    }
}
