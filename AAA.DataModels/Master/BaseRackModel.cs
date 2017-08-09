using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.DataModels
{
    public class BaseRackModel : CommonAuditDatesModel
    {
        public string RackName { get; set; }
        public int GodownId { get; set; }
        public string Narration { get; set; }
    }
}
