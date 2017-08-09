using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.DataModels
{
    public class BaseBudgetMasterModel : CommonAuditDatesModel
    {
        public string BudgetName { get; set; }
        public string Type { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public decimal? TotalDr { get; set; }
        public decimal? TotalCr { get; set; }
        public string Narration { get; set; }
    }
}
