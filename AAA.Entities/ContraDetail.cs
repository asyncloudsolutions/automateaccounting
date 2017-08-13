//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AAA.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class ContraDetail
    {
        public int Id { get; set; }
        public int ContraMasterId { get; set; }
        public int LedgerId { get; set; }
        public int ExchangeRateId { get; set; }
        public string ChequeNumber { get; set; }
        public Nullable<System.DateTime> ChequeDate { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual AccountLedger AccountLedger { get; set; }
        public virtual ContraMaster ContraMaster { get; set; }
        public virtual ExchangeRate ExchangeRate { get; set; }
    }
}