using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.DataModels
{
    public class BaseGodownModel : CommonAuditDatesModel
    {
        public string GodownName { get; set; }
        public string Narration { get; set; }
    }
}
