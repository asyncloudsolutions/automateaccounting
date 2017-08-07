using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.DataModels
{
    public class BaseTaxModel : CommonAuditDatesModel
    {
        public string TaxName { get; set; }
        public string ApplicableOn { get; set; }
        public decimal Rate { get; set; }
        public string CalculatingMode { get; set; }
        public string Narration { get; set; }
        public bool IsActive { get; set; }
    }
}
