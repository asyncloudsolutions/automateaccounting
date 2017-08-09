using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.DataModels
{
    public class BaseFieldModel : CommonAuditDatesModel
    {
        public int FormId { get; set; }
        public string FieldName { get; set; }
    }
}
