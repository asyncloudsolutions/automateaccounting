using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.DataModels
{
    public class BaseSalaryPackageModel : CommonAuditDatesModel
    {
        public string SalaryPackageName { get; set; }
        public bool IsActive { get; set; }
        public string Narration { get; set; }
        public decimal? TotalAmount { get; set; }
    }
}
