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
    
    public partial class PENALTIES
    {
        public decimal ID { get; set; }
        public Nullable<decimal> AMOUNT { get; set; }
        public string STATUS { get; set; }
        public decimal USERS_ID { get; set; }
    
        public virtual USERS USERS { get; set; }
    }
}
