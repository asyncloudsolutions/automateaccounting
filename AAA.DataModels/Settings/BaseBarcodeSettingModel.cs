using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.DataModels
{
    public class BaseBarcodeSettingModel : CommonAuditDatesModel
    {
        public bool ShowProductCode { get; set; }
        public bool ShowCompanyName { get; set; }
        public bool ShowPurchaseRate { get; set; }
        public bool ShowMRP { get; set; }
        public string CompanyName { get; set; }
        public string Point { get; set; }
        public string Zero { get; set; }
        public string One { get; set; }
        public string Two { get; set; }
        public string Three { get; set; }
        public string Four { get; set; }
        public string Five { get; set; }
        public string Six { get; set; }
        public string Seven { get; set; }
        public string Eight { get; set; }
        public string Nine { get; set; }
    }
}
