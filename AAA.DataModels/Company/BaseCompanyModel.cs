using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.DataModels
{
    public class BaseCompanyModel : CommonAuditDatesModel
    {
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Web { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string Pin { get; set; }
        public DateTime? FinancialYearFrom { get; set; }
        public DateTime? BooksBeginingFrom { get; set; }
        public string TIN { get; set; }
        public string CST { get; set; }
        public string PAN { get; set; }
        public DateTime? CurrentDate { get; set; }
        public byte[] Logo { get; set; }
        public int CurrencyId { get; set; }
    }
}
