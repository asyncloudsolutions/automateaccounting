using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.DataModels
{
    public class BaseBankReconciliationModel : CommonAuditDatesModel
    {
        public int LedgerPostingId { get; set; }
        public DateTime? StatementDate { get; set; }
    }
}
