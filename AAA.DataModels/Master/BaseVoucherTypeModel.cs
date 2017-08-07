using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.DataModels
{
    public class BaseVoucherTypeModel : CommonAuditDatesModel
    {
        public string VoucherTypeName { get; set; }
        public string TypeOfVoucher { get; set; }
        public string MethodOfVoucherNumbering { get; set; }
        public bool IsTaxApplicable { get; set; }
        public string Narration { get; set; }
        public bool IsActive { get; set; }
        public bool IsDefault { get; set; }
        public string Declaration { get; set; }
        public string HeadingOne { get; set; }
        public string HeadingTwo { get; set; }
        public string HeadingThree { get; set; }
        public string HeadingFour { get; set; }
        public int MasterId { get; set; }
    }
}
