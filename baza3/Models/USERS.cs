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
    
    public partial class USERS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USERS()
        {
            this.BOOK_RENTALS = new HashSet<BOOK_RENTALS>();
            this.PENALTIES = new HashSet<PENALTIES>();
        }
    
        public decimal ID { get; set; }
        public string LOGIN { get; set; }
        public string PASSWORD { get; set; }
        public string EMAIL { get; set; }
        public string NAME { get; set; }
        public string LASTNAME { get; set; }
        public Nullable<System.DateTime> BIRTH_DATE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOOK_RENTALS> BOOK_RENTALS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PENALTIES> PENALTIES { get; set; }
        public virtual USER_FAVORITES USER_FAVORITES { get; set; }
    }
}
