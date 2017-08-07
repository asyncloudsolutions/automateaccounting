using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.DataModels
{
    public class BaseRoleModel : CommonAuditDatesModel
    {
        public string RoleName { get; set; }
        public string Narration { get; set; }
    }
}
