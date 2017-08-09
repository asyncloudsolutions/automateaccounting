using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.DataModels
{
    public class BaseAdvancePaymentModel : CommonAuditDatesModel
    {
        public int EmployeeId { get; set; }
        public int LedgerId { get; set; }
        public int SuffixPrefixId { get; set; }
        public int VoucherTypeId { get; set; }
        public int FinancialYearId { get; set; }
        public string VoucherNumber { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime? Date { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? SalaryMonth { get; set; }
        public string ChequeNumber { get; set; }
        public DateTime? ChequeDate { get; set; }
        public string Narration { get; set; }
    }
}
