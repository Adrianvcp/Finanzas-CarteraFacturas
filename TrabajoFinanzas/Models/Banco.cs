//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrabajoFinanzas.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Banco
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Banco()
        {
            this.Banco_Promocion = new HashSet<Banco_Promocion>();
            this.leasings = new HashSet<leasing>();
        }
    
        public int idBanco { get; set; }
        public int idUsuario { get; set; }
        public string NombreBanco { get; set; }
        public float TEA { get; set; }
        public float SeguroRiesgo { get; set; }
        public float PorRecompa { get; set; }
        public float costesNotariales { get; set; }
        public float costesRegistrales { get; set; }
        public float Tasacion { get; set; }
        public float comEstudio { get; set; }
        public Nullable<float> comActivacion { get; set; }
        public float comPeriodica { get; set; }
        public float PorsegRiesgo { get; set; }
        public float ks { get; set; }
        public float wacc { get; set; }
    
        public virtual Administrador Administrador { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Banco_Promocion> Banco_Promocion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<leasing> leasings { get; set; }
    }
}
