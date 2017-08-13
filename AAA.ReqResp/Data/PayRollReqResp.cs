using AAA.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.ReqResp
{
    #region Employee
    #region Get
    public class GetBaseEmployeesRequest : CommonGetRequest { }

    public class GetBaseEmployeesResponse : CommonGetResponse<BaseEmployeeModel> { }
    #endregion

    #region Upsert
    public class UpsertBaseEmployeeRequest : CommonUpsertRequest<BaseEmployeeModel> { }

    public class UpsertBaseEmployeeResponse : CommonUpsertResponse<BaseEmployeeModel> { }
    #endregion
    #endregion

    #region BonusDeduction
    #region Get
    public class GetBaseBonusDeductionsRequest : CommonGetRequest { }

    public class GetBaseBonusDeductionsResponse : CommonGetResponse<BaseBonusDeductionModel> { }
    #endregion

    #region Upsert
    public class UpsertBaseBonusDeductionRequest : CommonUpsertRequest<BaseBonusDeductionModel> { }

    public class UpsertBaseBonusDeductionResponse : CommonUpsertResponse<BaseBonusDeductionModel> { }
    #endregion
    #endregion

    #region Designation
    #region Get
    public class GetBaseDesignationsRequest : CommonGetRequest { }

    public class GetBaseDesignationsResponse : CommonGetResponse<BaseDesignationModel> { }
    #endregion

    #region Upsert
    public class UpsertBaseDesignationRequest : CommonUpsertRequest<BaseDesignationModel> { }

    public class UpsertBaseDesignationResponse : CommonUpsertResponse<BaseDesignationModel> { }
    #endregion
    #endregion


    #region SalaryPackage
    #region Get
    public class GetBaseSalaryPackagesRequest : CommonGetRequest { }

    public class GetBaseSalaryPackagesResponse : CommonGetResponse<BaseSalaryPackageModel> { }
    #endregion

    #region Upsert
    public class UpsertBaseSalaryPackageRequest : CommonUpsertRequest<BaseSalaryPackageModel> { }

    public class UpsertBaseSalaryPackageResponse : CommonUpsertResponse<BaseSalaryPackageModel> { }
    #endregion
    #endregion


}
