using AAA.DataModels;
using AAA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AAA.DataConversions
{
    public static class PayRollAssembler
    {

        #region BonusDeduction

        public static IList<BaseBonusDeductionModel> ToBaseBonusDeduction(this List<BonusDeduction> bonusDeductions)
        {
            IList<BaseBonusDeductionModel> _result = new List<BaseBonusDeductionModel>();
            bonusDeductions.ForEach(BonusDeduction => _result.Add(BonusDeduction.ToBaseBonusDeduction()));
            return _result;
        }

        public static BaseBonusDeductionModel ToBaseBonusDeduction(this BonusDeduction BonusDeduction)
        {
            BaseBonusDeductionModel _result = new BaseBonusDeductionModel();
            _result.EmployeeId = BonusDeduction.EmployeeId;
            _result.Date = BonusDeduction.Date;
            _result.Month = BonusDeduction.Month;
            _result.BonusAmount = BonusDeduction.BonusAmount;
            return _result;
        }

        #endregion

        #region Designation

        public static IList<BaseDesignationModel> ToBaseDesignation(this List<Designation> designations)
        {
            IList<BaseDesignationModel> _result = new List<BaseDesignationModel>();
            designations.ForEach(Designation => _result.Add(Designation.ToBaseDesignation()));
            return _result;
        }

        public static BaseDesignationModel ToBaseDesignation(this Designation Designation)
        {
            BaseDesignationModel _result = new BaseDesignationModel();
            _result.DesignationName = Designation.DesignationName;
            _result.LeaveDays = Designation.LeaveDays;
            _result.AdvanceAmount = Designation.AdvanceAmount;
            _result.Narration = Designation.Narration;
            return _result;
        }

        #endregion

        #region SalaryPackage

        public static IList<BaseSalaryPackageModel> ToBaseSalaryPackage(this List<SalaryPackage> salaryPackages)
        {
            IList<BaseSalaryPackageModel> _result = new List<BaseSalaryPackageModel>();
            salaryPackages.ForEach(SalaryPackage => _result.Add(SalaryPackage.ToBaseSalaryPackage()));
            return _result;
        }

        public static BaseSalaryPackageModel ToBaseSalaryPackage(this SalaryPackage SalaryPackage)
        {
            BaseSalaryPackageModel _result = new BaseSalaryPackageModel();
            _result.SalaryPackageName = SalaryPackage.SalaryPackageName;
            _result.IsActive = SalaryPackage.IsActive;
            _result.Narration = SalaryPackage.Narration;
            _result.TotalAmount = SalaryPackage.TotalAmount;
            return _result;
        }

        #endregion

        #region Employee

        public static IList<BaseEmployeeModel> ToBaseEmployee(this List<Employee> employees)
        {
            IList<BaseEmployeeModel> _result = new List<BaseEmployeeModel>();
            employees.ForEach(Employee => _result.Add(Employee.ToBaseEmployee()));
            return _result;
        }

        public static BaseEmployeeModel ToBaseEmployee(this Employee Employee)
        {
            BaseEmployeeModel _result = new BaseEmployeeModel();
            _result.DesignationId = Employee.DesignationId;
            _result.EmployeeName = Employee.EmployeeName;
            _result.EmployeeCode = Employee.EmployeeCode;
            _result.DateOfBirth = Employee.DateOfBirth;
            _result.MaritalStatus = Employee.MaritalStatus;
            _result.Gender = Employee.Gender;
            _result.Qualification = Employee.Qualification;
            _result.Address = Employee.Address;
            _result.PhoneNumber = Employee.PhoneNumber;
            _result.MobileNumber = Employee.MobileNumber;
            _result.Email = Employee.Email;
            _result.JoiningDate = Employee.JoiningDate;
            _result.TerminationDate = Employee.TerminationDate;
            _result.Narration = Employee.Narration;
            _result.BloodGroup = Employee.BloodGroup;
            _result.PassportNumber = Employee.PassportNumber;
            _result.PassportExpiryDate = Employee.PassportExpiryDate;
            _result.LabourCardNumber = Employee.LabourCardNumber;
            _result.LabourCardExpiryDate = Employee.LabourCardExpiryDate;
            _result.SalaryType = Employee.SalaryType;
            _result.DailyWage = Employee.DailyWage;
            _result.BankName = Employee.BankName;
            _result.BranchName = Employee.BranchName;
            _result.BankAccountNumber = Employee.BankAccountNumber;
            _result.BranchCode = Employee.BranchCode;
            _result.PANNumber = Employee.PANNumber;
            _result.PFNumber = Employee.PFNumber;
            _result.ESINumber = Employee.ESINumber;
            _result.DefaultPackageId = Employee.DefaultPackageId;

            return _result;
        }

        #endregion

    }
}
