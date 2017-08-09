using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.DataModels
{
    public class BaseAdditionalCostModel : CommonAuditDatesModel
    {
        public int VoucherTypeId { get; set; }
        public int LedgerId { get; set; }
        public string VoucherNumber { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
    }
}
