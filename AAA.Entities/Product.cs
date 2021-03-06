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
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.Batches = new HashSet<Batch>();
            this.Boms = new HashSet<Bom>();
        }
    
        public int Id { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public int ProductGroupId { get; set; }
        public int BrandId { get; set; }
        public int UnitId { get; set; }
        public int SizeId { get; set; }
        public int ModelNumberId { get; set; }
        public int TaxId { get; set; }
        public string TaxApplicableOn { get; set; }
        public Nullable<decimal> PurchaseRate { get; set; }
        public Nullable<decimal> SalesRate { get; set; }
        public Nullable<decimal> MRP { get; set; }
        public Nullable<decimal> MinimumStock { get; set; }
        public Nullable<decimal> MaximumStock { get; set; }
        public Nullable<decimal> ReOrderLevel { get; set; }
        public int GodownId { get; set; }
        public int RackId { get; set; }
        public bool IsAllowBatch { get; set; }
        public bool IsMultipleUnit { get; set; }
        public bool IsBOM { get; set; }
        public bool IsOpeningStock { get; set; }
        public string Narration { get; set; }
        public bool IsActive { get; set; }
        public bool IsShowRemember { get; set; }
        public string PartNumber { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Batch> Batches { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Godown Godown { get; set; }
        public virtual ModelNumber ModelNumber { get; set; }
        public virtual ProductGroup ProductGroup { get; set; }
        public virtual Rack Rack { get; set; }
        public virtual Size Size { get; set; }
        public virtual Tax Tax { get; set; }
        public virtual Unit Unit { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bom> Boms { get; set; }
    }
}
