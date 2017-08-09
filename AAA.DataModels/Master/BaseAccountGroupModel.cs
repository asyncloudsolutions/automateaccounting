using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.DataModels
{
    public class BaseAccountGroupModel : CommonAuditDatesModel
    {
        public string AccountGroupName { get; set; }
        public decimal GroupUnder { get; set; }
        public string Narration { get; set; }
        public bool IsDefault { get; set; }
        public string Nature { get; set; }
        public string AffectGrossProfit { get; set; }
    }
}
