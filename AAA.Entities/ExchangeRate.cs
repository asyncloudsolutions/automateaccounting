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
    
    public partial class ExchangeRate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ExchangeRate()
        {
            this.ContraDetails = new HashSet<ContraDetail>();
            this.CreditNoteDetails = new HashSet<CreditNoteDetail>();
            this.DebitNoteDetails = new HashSet<DebitNoteDetail>();
        }
    
        public int Id { get; set; }
        public int CurrencyId { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public string Narration { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual Currency Currency { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContraDetail> ContraDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CreditNoteDetail> CreditNoteDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DebitNoteDetail> DebitNoteDetails { get; set; }
    }
}
