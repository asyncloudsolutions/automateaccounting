using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.DataModels
{
    public class BaseBrandModel : CommonAuditDatesModel
    {
        public string BrandName { get; set; }
        public string Manufacturer { get; set; }
        public string Narration { get; set; }
    }
}
