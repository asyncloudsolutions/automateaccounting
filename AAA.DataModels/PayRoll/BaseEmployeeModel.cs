using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.DataModels
{
    public class BaseEmployeeModel : CommonAuditDatesModel
    {
        public int DesignationId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeCode { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string MaritalStatus { get; set; }
        public string Gender { get; set; }
        public string Qualification { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public DateTime JoiningDate { get; set; }
        public DateTime? TerminationDate { get; set; }
        public bool IsActive { get; set; }
        public string Narration { get; set; }
        public string BloodGroup { get; set; }
        public string PassportNumber { get; set; }
        public DateTime? PassportExpiryDate { get; set; }
        public string LabourCardNumber { get; set; }
        public DateTime? LabourCardExpiryDate { get; set; }
        public string SalaryType { get; set; }
        public decimal? DailyWage { get; set; }
        public string BankName { get; set; }
        public string BranchName { get; set; }
        public string BankAccountNumber { get; set; }
        public string BranchCode { get; set; }
        public string PANNumber { get; set; }
        public string PFNumber { get; set; }
        public string ESINumber { get; set; }
        public int DefaultPackageId { get; set; }
    }
}
