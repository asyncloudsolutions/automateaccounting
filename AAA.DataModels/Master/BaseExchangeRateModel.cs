using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.DataModels
{
    public class BaseExchangeRateModel : CommonAuditDatesModel
    {
        public int CurrencyId { get; set; }
        public DateTime? Date { get; set; }
        public decimal? Rate { get; set; }
        public string Narration { get; set; }
    }
}
