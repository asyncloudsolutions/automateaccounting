using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.DataModels
{
    public class BaseMasterModel : CommonAuditDatesModel
    {
        public int FormName { get; set; }
        public bool IsTwoLineForHedder { get; set; }
        public bool IsTwoLineForDetails { get; set; }
        public int PageSize { get; set; }
        public int PageSizeOther { get; set; }
        public int BlankLineForFooter { get; set; }
        public string FooterLocation { get; set; }
        public int LineCountBetweenTwo { get; set; }
        public string Pitch { get; set; }
        public string Condensed { get; set; }
        public int LineCountAfterPrint { get; set; }
    }
}
