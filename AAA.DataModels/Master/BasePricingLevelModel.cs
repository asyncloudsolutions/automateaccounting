using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.DataModels
{
    public class BasePricingLevelModel : CommonAuditDatesModel
    {
        public string PricingLevelName { get; set; }
        public string Narration { get; set; }
    }
}
