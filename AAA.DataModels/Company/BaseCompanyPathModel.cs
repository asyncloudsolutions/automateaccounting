using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.DataModels
{
    public class BaseCompanyPathModel : CommonAuditDatesModel
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyPath1 { get; set; }
        public bool IsDefault { get; set; }
    }
}
