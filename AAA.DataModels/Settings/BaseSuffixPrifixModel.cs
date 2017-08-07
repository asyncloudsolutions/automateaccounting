using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.DataModels
{
    public class BaseSuffixPrifixModel : CommonAuditDatesModel
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int? StartIndex { get; set; }
        public string Prefix { get; set; }
        public string Suffix { get; set; }
        public int? WidthOfNumericalPart { get; set; }
        public bool PrefillWithZero { get; set; }
        public string Narration { get; set; }
        public int VoucherTypeId { get; set; }
    }
}
