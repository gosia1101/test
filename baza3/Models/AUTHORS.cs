//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace baza3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AUTHORS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AUTHORS()
        {
            this.BOOKS = new HashSet<BOOKS>();
        }
    
        public decimal ID { get; set; }
        public string FIRSTNAME { get; set; }
        public string LASTNAME { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOOKS> BOOKS { get; set; }
    }
}
