using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.DataModels
{
    public class BaseAccountLedgerModel : CommonAuditDatesModel
    {
        public int AccountGroupId { get; set; }
        public int PricingLevelId { get; set; }
        public int AreaId { get; set; }
        public int RouteId { get; set; }
        public string LedgerName { get; set; }
        public string OpeningBalance { get; set; }
        public bool IsDefault { get; set; }
        public string CrOrDr { get; set; }
        public string AffectGrossProfit { get; set; }
        public string MailingName { get; set; }
        public string Narration { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public int? CreditPeriod { get; set; }
        public decimal? CreditLimit { get; set; }
        public bool BillByBill { get; set; }
        public string TIN { get; set; }
        public string CST { get; set; }
        public string PAN { get; set; }
        public string BankAccountNumber { get; set; }
        public string BranchName { get; set; }
        public string BranchCode { get; set; }
    }
}
