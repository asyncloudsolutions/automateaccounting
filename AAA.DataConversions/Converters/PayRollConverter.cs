using AAA.DataModels;
using AAA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.DataConversions
{
    public static class PayRollConvertor
    {
        #region BonusDeduction
        public static BonusDeduction ToBonusDeduction(this BaseBonusDeductionModel bonusDeduction)
        {
            BonusDeduction _result = new BonusDeduction();
            if (bonusDeduction.Id.HasValue) { _result.Id = bonusDeduction.Id.GetValueOrDefault(); }
            _result.EmployeeId = bonusDeduction.EmployeeId;
            _result.Date = bonusDeduction.Date;
            _result.Month = bonusDeduction.Month;
            _result.BonusAmount = bonusDeduction.BonusAmount;
            _result.CreatedDate = bonusDeduction.CreatedDate;
            _result.ModifiedDate = bonusDeduction.ModifiedDate;
            return _result;
        }
        #endregion

        #region Designation
        public static Designation ToDesignation(this BaseDesignationModel designation)
        {
            Designation _result = new Designation();
            if (designation.Id.HasValue) { _result.Id = designation.Id.GetValueOrDefault(); }
            _result.DesignationName = designation.DesignationName;
            _result.LeaveDays = designation.LeaveDays;
            _result.AdvanceAmount = designation.AdvanceAmount;
            _result.Narration = designation.Narration;
            _result.CreatedDate = designation.CreatedDate;
            _result.ModifiedDate = designation.ModifiedDate;
            return _result;
        }
        #endregion

        #region Employee
        public static Employee ToEmployee(this BaseEmployeeModel employee)
        {
            Employee _result = new Employee();
            if (employee.Id.HasValue) { _result.Id = employee.Id.GetValueOrDefault(); }
            _result.DesignationId = employee.DesignationId;
            _result.EmployeeName = employee.EmployeeName;
            _result.EmployeeCode = employee.EmployeeCode;
            _result.DateOfBirth = employee.DateOfBirth;
            _result.MaritalStatus = employee.MaritalStatus;
            _result.Gender = employee.Gender;
            _result.Qualification = employee.Qualification;
            _result.Address = employee.Address;
            _result.PhoneNumber = employee.PhoneNumber;
            _result.MobileNumber = employee.MobileNumber;
            _result.Email = employee.Email;
            _result.JoiningDate = employee.JoiningDate;
            _result.TerminationDate = employee.TerminationDate;
            _result.Narration = employee.Narration;
            _result.BloodGroup = employee.BloodGroup;
            _result.PassportNumber = employee.PassportNumber;
            _result.PassportExpiryDate = employee.PassportExpiryDate;
            _result.LabourCardNumber = employee.LabourCardNumber;
            _result.LabourCardExpiryDate = employee.LabourCardExpiryDate;
            _result.SalaryType = employee.SalaryType;
            _result.DailyWage = employee.DailyWage;
            _result.BankName = employee.BankName;
            _result.BranchName = employee.BranchName;
            _result.BankAccountNumber = employee.BankAccountNumber;
            _result.BranchCode = employee.BranchCode;
            _result.PANNumber = employee.PANNumber;
            _result.PFNumber = employee.PFNumber;
            _result.ESINumber = employee.ESINumber;
            _result.DefaultPackageId = employee.DefaultPackageId;
            _result.CreatedDate = employee.CreatedDate;
            _result.ModifiedDate = employee.ModifiedDate;

            return _result;
        }
        #endregion

        #region SalaryPackage
        public static SalaryPackage ToSalaryPackage(this BaseSalaryPackageModel salaryPackage)
        {
            SalaryPackage _result = new SalaryPackage();
            if (salaryPackage.Id.HasValue) { _result.Id = salaryPackage.Id.GetValueOrDefault(); }
            _result.SalaryPackageName = salaryPackage.SalaryPackageName;
            _result.IsActive = salaryPackage.IsActive;
            _result.Narration = salaryPackage.Narration;
            _result.TotalAmount = salaryPackage.TotalAmount;
            _result.CreatedDate = salaryPackage.CreatedDate;
            _result.ModifiedDate = salaryPackage.ModifiedDate;
            return _result;
        }
        #endregion
    }
}