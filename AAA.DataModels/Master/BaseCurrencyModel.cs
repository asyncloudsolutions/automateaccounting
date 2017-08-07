using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.DataModels
{
    public class BaseCurrencyModel : CommonAuditDatesModel
    {
        public string CurrencySymbol { get; set; }
        public string CurrencyName { get; set; }
        public string SubUnitName { get; set; }
        public int NoOfDecimalPlaces { get; set; }
        public string Narration { get; set; }
        public bool IsDefault { get; set; }
    }
}
