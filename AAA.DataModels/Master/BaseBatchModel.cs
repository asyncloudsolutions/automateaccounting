using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.DataModels
{
    public class BaseBatchModel : CommonAuditDatesModel
    {
        public int ProductId { get; set; }
        public string BatchNumber { get; set; }
        public string Barcode { get; set; }
        public string PartNumber { get; set; }
        public DateTime? ManufacturingDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string Narration { get; set; }
    }
}
