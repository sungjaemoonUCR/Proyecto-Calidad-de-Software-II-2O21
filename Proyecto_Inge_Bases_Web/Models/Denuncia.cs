//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto_Inge_Bases_Web.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Denuncia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Denuncia()
        {
            this.Apelacions = new HashSet<Apelacion>();
        }
    
        public System.DateTime Fecha { get; set; }
        public string Comentarios { get; set; }
        public string Denunciante { get; set; }
        public string Denunciado { get; set; }
        public byte Tipo { get; set; }
        public Nullable<int> ProductoID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Apelacion> Apelacions { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Cliente Cliente1 { get; set; }
    }
}
