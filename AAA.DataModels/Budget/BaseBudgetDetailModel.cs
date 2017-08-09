using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.DataModels
{
    public class BaseBudgetDetailModel : CommonAuditDatesModel
    {
        public int BudgetMasterId { get; set; }
        public string Particular { get; set; }
        public Nullable<System.DateTime> ExtraDate { get; set; }
        public Nullable<decimal> Credit { get; set; }
        public Nullable<decimal> Debit { get; set; }
    }
}
