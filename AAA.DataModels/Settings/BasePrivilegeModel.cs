using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.DataModels
{
    public class BasePrivilegeModel : CommonAuditDatesModel
    {
        public string Action { get; set; }
        public int RoleId { get; set; }
        public string Narration { get; set; }
        public string FormName { get; set; }
    }
}
