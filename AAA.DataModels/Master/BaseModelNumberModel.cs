using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.DataModels
{
    public class BaseModelNumberModel : CommonAuditDatesModel
    {
        public string ModelNo { get; set; }
        public string Narration { get; set; }
    }
}
