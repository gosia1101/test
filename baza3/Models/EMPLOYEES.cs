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
    
    public partial class EMPLOYEES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EMPLOYEES()
        {
            this.BOOK_RENTALS = new HashSet<BOOK_RENTALS>();
        }
    
        public decimal ID { get; set; }
        public string IS_ADMIN { get; set; }
        public string NAME { get; set; }
        public string LASTNAME { get; set; }
        public string LOGIN { get; set; }
        public string PASSWORD { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOOK_RENTALS> BOOK_RENTALS { get; set; }
    }
}
