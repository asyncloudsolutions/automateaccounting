using AAA.ReqResp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.DataProviders
{
    public interface IPayRollProvider
    {
        #region BonusDeduction
        #region Get
        Task<GetBaseBonusDeductionsResponse> GetBaseBonusDeductionsAsync(GetBaseBonusDeductionsRequest request);
        #endregion

        #region Upsert
        Task<UpsertBaseBonusDeductionResponse> UpsertBaseBonusDeductionAsync(UpsertBaseBonusDeductionRequest request);
        #endregion
        #endregion

        #region Designation

        #region Get
        Task<GetBaseDesignationsResponse> GetBaseDesignationsAsync(GetBaseBudgetDetailsRequest request);
        #endregion

        #region Upsert
        Task<UpsertBaseDesignationResponse> UpsertBaseDesignationAsync(UpsertBaseDesignationRequest request);
        #endregion
        #endregion

        #region Employee
        #region Get
        Task<GetBaseEmployeesResponse> GetBaseEmployeesAsync(GetBaseEmployeesRequest request);
        #endregion

        #region Upsert
        Task<UpsertBaseEmployeeResponse> UpsertBaseEmployeeAsync(UpsertBaseEmployeeRequest request);
        #endregion
        #endregion

        #region SalaryPackage

        #region Get
        Task<GetBaseSalaryPackagesResponse> GetBaseDesignationsAsync(GetBaseSalaryPackagesRequest request);
        #endregion

        #region Upsert
        Task<UpsertBaseSalaryPackageResponse> UpsertBaseDesignationAsync(UpsertBaseSalaryPackageRequest request);
        #endregion
        #endregion

    }
}
