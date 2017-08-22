using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AAA.ReqResp;
using AAA.Entities;
using LinqKit;
using AAA.DataConversions;

namespace AAA.DataProviders
{
    public class PayrollProvider : ProviderHelper, IPayRollProvider
    {
        #region BonusDeduction
        #region Get
        public async Task<GetBaseBonusDeductionsResponse> GetBaseBonusDeductionsAsync(GetBaseBonusDeductionsRequest request)
        {
            return await Task.Run(() =>
            {
                GetBaseBonusDeductionsResponse _response = new GetBaseBonusDeductionsResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    ExpressionStarter<BonusDeduction> _predicateBonusDeductions = PredicateBuilder.New<BonusDeduction>(true);
                    if (request.Id.HasValue) { _predicateBonusDeductions = _predicateBonusDeductions.And(p => p.Id == request.Id); }
                    List<BonusDeduction> _BonusDeductions = _dbContext.BonusDeductions.AsExpandable().Where(_predicateBonusDeductions).ToList();
                    if (_BonusDeductions.Any()) { _response.BaseObjects = _BonusDeductions.ToBaseBonusDeduction(); }
                }
                return _response;
            });
        }
        #endregion

        #region Upsert
        public async Task<UpsertBaseBonusDeductionResponse> UpsertBaseBonusDeductionAsync(UpsertBaseBonusDeductionRequest request)
        {
            return await Task.Run(() =>
            {
                UpsertBaseBonusDeductionResponse _response = new UpsertBaseBonusDeductionResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    if (request.BaseObject != null)
                    {
                        try
                        {
                            BonusDeduction _BonusDeduction = request.BaseObject.ToBonusDeduction();
                            UpsertEntity<BonusDeduction>(request.BaseObject.Id, ref _BonusDeduction, _dbContext);
                            _response.BaseObject = _BonusDeduction.ToBaseBonusDeduction();
                        }
                        catch (Exception ex) { AssignStatusData(_response, false, string.Format("Some error occurred during DB interaction. Message is something like : \n{0}", ex.Message)); }
                    }
                    else { AssignStatusData(_response, false, "No entity data recieved to insert/update."); }
                }
                return _response;
            });
        }
        #endregion
        #endregion

        #region Designation
        #region Get
        public async Task<GetBaseDesignationsResponse> GetBaseDesignationsAsync(GetBaseDesignationsRequest request)
        {
            return await Task.Run(() =>
            {
                GetBaseDesignationsResponse _response = new GetBaseDesignationsResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    ExpressionStarter<Designation> _predicateDesignations = PredicateBuilder.New<Designation>(true);
                    if (request.Id.HasValue) { _predicateDesignations = _predicateDesignations.And(p => p.Id == request.Id); }
                    List<Designation> _Designations = _dbContext.Designations.AsExpandable().Where(_predicateDesignations).ToList();
                    if (_Designations.Any()) { _response.BaseObjects = _Designations.ToBaseDesignation(); }
                }
                return _response;
            });
        }
        #endregion

        #region Upsert
        public async Task<UpsertBaseDesignationResponse> UpsertBaseDesignationAsync(UpsertBaseDesignationRequest request)
        {
            return await Task.Run(() =>
            {
                UpsertBaseDesignationResponse _response = new UpsertBaseDesignationResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    if (request.BaseObject != null)
                    {
                        try
                        {
                            Designation _Designation = request.BaseObject.ToDesignation();
                            UpsertEntity<Designation>(request.BaseObject.Id, ref _Designation, _dbContext);
                            _response.BaseObject = _Designation.ToBaseDesignation();
                        }
                        catch (Exception ex) { AssignStatusData(_response, false, string.Format("Some error occurred during DB interaction. Message is something like : \n{0}", ex.Message)); }
                    }
                    else { AssignStatusData(_response, false, "No entity data recieved to insert/update."); }
                }
                return _response;
            });
        }
        #endregion
        #endregion

        #region Employee
        #region Get
        public async Task<GetBaseEmployeesResponse> GetBaseEmployeesAsync(GetBaseEmployeesRequest request)
        {
            return await Task.Run(() =>
            {
                GetBaseEmployeesResponse _response = new GetBaseEmployeesResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    ExpressionStarter<Employee> _predicateEmployees = PredicateBuilder.New<Employee>(true);
                    if (request.Id.HasValue) { _predicateEmployees = _predicateEmployees.And(p => p.Id == request.Id); }
                    List<Employee> _Employees = _dbContext.Employees.AsExpandable().Where(_predicateEmployees).ToList();
                    if (_Employees.Any()) { _response.BaseObjects = _Employees.ToBaseEmployee(); }
                }
                return _response;
            });
        }
        #endregion

        #region Upsert
        public async Task<UpsertBaseEmployeeResponse> UpsertBaseEmployeeAsync(UpsertBaseEmployeeRequest request)
        {
            return await Task.Run(() =>
            {
                UpsertBaseEmployeeResponse _response = new UpsertBaseEmployeeResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    if (request.BaseObject != null)
                    {
                        try
                        {
                            Employee _Employee = request.BaseObject.ToEmployee();
                            UpsertEntity<Employee>(request.BaseObject.Id, ref _Employee, _dbContext);
                            _response.BaseObject = _Employee.ToBaseEmployee();
                        }
                        catch (Exception ex) { AssignStatusData(_response, false, string.Format("Some error occurred during DB interaction. Message is something like : \n{0}", ex.Message)); }
                    }
                    else { AssignStatusData(_response, false, "No entity data recieved to insert/update."); }
                }
                return _response;
            });
        }
        #endregion
        #endregion

        #region SalaryPackage
        #region Get
        public async Task<GetBaseSalaryPackagesResponse> GetBaseSalaryPackagesAsync(GetBaseSalaryPackagesRequest request)
        {
            return await Task.Run(() =>
            {
                GetBaseSalaryPackagesResponse _response = new GetBaseSalaryPackagesResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    ExpressionStarter<SalaryPackage> _predicateSalaryPackages = PredicateBuilder.New<SalaryPackage>(true);
                    if (request.Id.HasValue) { _predicateSalaryPackages = _predicateSalaryPackages.And(p => p.Id == request.Id); }
                    List<SalaryPackage> _SalaryPackages = _dbContext.SalaryPackages.AsExpandable().Where(_predicateSalaryPackages).ToList();
                    if (_SalaryPackages.Any()) { _response.BaseObjects = _SalaryPackages.ToBaseSalaryPackage(); }
                }
                return _response;
            });
        }
        #endregion

        #region Upsert
        public async Task<UpsertBaseSalaryPackageResponse> UpsertBaseSalaryPackageAsync(UpsertBaseSalaryPackageRequest request)
        {
            return await Task.Run(() =>
            {
                UpsertBaseSalaryPackageResponse _response = new UpsertBaseSalaryPackageResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    if (request.BaseObject != null)
                    {
                        try
                        {
                            SalaryPackage _SalaryPackage = request.BaseObject.ToSalaryPackage();
                            UpsertEntity<SalaryPackage>(request.BaseObject.Id, ref _SalaryPackage, _dbContext);
                            _response.BaseObject = _SalaryPackage.ToBaseSalaryPackage();
                        }
                        catch (Exception ex) { AssignStatusData(_response, false, string.Format("Some error occurred during DB interaction. Message is something like : \n{0}", ex.Message)); }
                    }
                    else { AssignStatusData(_response, false, "No entity data recieved to insert/update."); }
                }
                return _response;
            });
        }
        #endregion
        #endregion
    }
}
