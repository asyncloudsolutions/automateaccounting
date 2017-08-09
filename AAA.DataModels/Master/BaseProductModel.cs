using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.DataModels
{
    public class BaseProductModel : CommonAuditDatesModel
    {
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public int ProductGroupId { get; set; }
        public int BrandId { get; set; }
        public int UnitId { get; set; }
        public int SizeId { get; set; }
        public int ModelNumberId { get; set; }
        public int TaxId { get; set; }
        public string TaxApplicableOn { get; set; }
        public decimal? PurchaseRate { get; set; }
        public decimal? SalesRate { get; set; }
        public decimal? MRP { get; set; }
        public decimal? MinimumStock { get; set; }
        public decimal? MaximumStock { get; set; }
        public decimal? ReOrderLevel { get; set; }
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
    }
}
