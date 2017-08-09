using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.DataModels
{
    public class BaseLedgerPostingModel : CommonAuditDatesModel
    {
        public DateTime Date { get; set; }
        public int VoucherTypeId { get; set; }
        public string VoucherNumber { get; set; }
        public int LedgerId { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public int DetailsId { get; set; }
        public int FinancialYearId { get; set; }
        public string InvoiceNumber { get; set; }
        public string Text { get; set; }
        public string ChequeNumber { get; set; }
        public DateTime? ChequeDate { get; set; }
    }
}
