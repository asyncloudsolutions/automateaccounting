using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.DataModels
{
    public class BaseBonusDeductionModel : CommonAuditDatesModel
    {
        public int EmployeeId { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? Month { get; set; }
        public decimal? BonusAmount { get; set; }
        public decimal? DeductionAmount { get; set; }
        public string Narration { get; set; }
    }
}
