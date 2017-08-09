using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.DataModels
{
    public class BaseDesignationModel : CommonAuditDatesModel
    {
        public string DesignationName { get; set; }
        public decimal? LeaveDays { get; set; }
        public decimal? AdvanceAmount { get; set; }
        public string Narration { get; set; }
    }
}
