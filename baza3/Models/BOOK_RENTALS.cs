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
    
    public partial class BOOK_RENTALS
    {
        public decimal ID { get; set; }
        public Nullable<System.DateTime> DATE_OF_RENTAL { get; set; }
        public Nullable<System.DateTime> DATE_OF_RETURN { get; set; }
        public decimal USERS_ID { get; set; }
        public decimal EMPLOYEES_ID { get; set; }
        public decimal BOOK_COPIES_ID { get; set; }
    
        public virtual BOOK_COPIES BOOK_COPIES { get; set; }
        public virtual EMPLOYEES EMPLOYEES { get; set; }
        public virtual USERS USERS { get; set; }
    }
}
