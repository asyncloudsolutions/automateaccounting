using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.DataModels
{
    public class BaseProductGroupModel : CommonAuditDatesModel
    {
        public string GroupName { get; set; }
        public int? GroupUnder { get; set; }
        public string Narration { get; set; }
    }
}
