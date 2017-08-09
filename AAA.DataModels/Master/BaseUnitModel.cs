using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.DataModels
{
    public class BaseUnitModel : CommonAuditDatesModel
    {
        public string UnitName { get; set; }
        public string Narration { get; set; }
        public int? NumberOfDecimalPlaces { get; set; }
        public string FormalName { get; set; }
    }
}
