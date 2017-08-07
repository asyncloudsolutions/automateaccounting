using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.DataModels
{
    public abstract class CommonAuditUserDetailsModel : CommonAuditDatesModel
    {
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
    }
}
