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
    
    public partial class SuffixPrefix
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SuffixPrefix()
        {
            this.AdvancePayments = new HashSet<AdvancePayment>();
            this.ContraMasters = new HashSet<ContraMaster>();
            this.CreditNoteMasters = new HashSet<CreditNoteMaster>();
            this.DailySalaryVoucherMasters = new HashSet<DailySalaryVoucherMaster>();
            this.DebitNoteMasters = new HashSet<DebitNoteMaster>();
        }
    
        public int Id { get; set; }
        public System.DateTime FromDate { get; set; }
        public System.DateTime ToDate { get; set; }
        public Nullable<int> StartIndex { get; set; }
        public string Prefix { get; set; }
        public string Suffix { get; set; }
        public Nullable<int> WidthOfNumericalPart { get; set; }
        public bool PrefillWithZero { get; set; }
        public string Narration { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public int VoucherTypeId { get; set; }
    
        public virtual VoucherType VoucherType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AdvancePayment> AdvancePayments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContraMaster> ContraMasters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CreditNoteMaster> CreditNoteMasters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DailySalaryVoucherMaster> DailySalaryVoucherMasters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DebitNoteMaster> DebitNoteMasters { get; set; }
    }
}
