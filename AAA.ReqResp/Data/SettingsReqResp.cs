using AAA.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.ReqResp
{
    #region User
    #region Get
    public class GetBaseUsersRequest : CommonGetRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class GetBaseUsersResponse : CommonGetResponse<BaseUserModel> { }
    #endregion

    #region Upsert
    public class UpsertBaseUserRequest : CommonUpsertRequest<BaseUserModel> { }

    public class UpsertBaseUserResponse : CommonUpsertResponse<BaseUserModel> { }
    #endregion
    #endregion

    #region Role
    #region Get
    public class GetBaseRolesRequest : CommonGetRequest { }

    public class GetBaseRolesResponse : CommonGetResponse<BaseRoleModel> { }

    #endregion

    #region Upsert
    public class UpsertBaseRoleRequest : CommonUpsertRequest<BaseRoleModel> { }

    public class UpsertBaseRoleResponse : CommonUpsertResponse<BaseRoleModel> { }

    #endregion
    #endregion


    #region BarcodeSettingModel
    #region Get
    public class GetBarcodeSettingResponse : CommonGetRequest { }

    public class GetBarcodeSettingModelsResponse : CommonGetResponse<BaseBarcodeSettingModel> { }
    #endregion

    #region Upsert
    public class UpsertBaseBarcodeSettingModelRequest : CommonUpsertRequest<BaseBarcodeSettingModel> { }

    public class UpsertBaseBarcodeSettingModelResponse : CommonUpsertResponse<BaseBarcodeSettingModel> { }

    #endregion
    #endregion

    #region Field
    #region Get
    public class GetBaseFieldsRequest : CommonGetRequest { }

    public class GetBaseFieldsResponse : CommonGetResponse<BaseFieldModel> { }
    #endregion

    #region Upsert
    public class UpsertBaseFieldRequest : CommonUpsertRequest<BaseFieldModel> { }

    public class UpsertBaseFieldResponse : CommonUpsertResponse<BaseFieldModel> { }

    #endregion
    #endregion

    #region FinancialYear
    #region Get
    public class GetBaseFinancialYearsRequest : CommonGetRequest { }

    public class GetBaseFinancialYearsResponse : CommonGetResponse<BaseFinancialYearModel> { }
    #endregion

    #region Upsert
    public class UpsertBaseFinancialYearRequest : CommonUpsertRequest<BaseFinancialYearModel> { }

    public class UpsertBaseFinancialYearResponse : CommonUpsertResponse<BaseFinancialYearModel> { }

    #endregion
    #endregion

    #region Form
    #region Get
    public class GetBaseFormsRequest : CommonGetRequest { }

    public class GetBaseFormsResponse : CommonGetResponse<BaseFormModel> { }
    #endregion

    #region Upsert
    public class UpsertBaseFormRequest : CommonUpsertRequest<BaseFormModel> { }

    public class UpsertBaseFormResponse : CommonUpsertResponse<BaseFormModel> { }

    #endregion
    #endregion

    #region Privilege
    #region Get
    public class GetBasePrivilegesRequest : CommonGetRequest { }

    public class GetBasePrivilegesResponse : CommonGetResponse<BasePrivilegeModel> { }
    #endregion

    #region Upsert
    public class UpsertBasePrivilegeRequest : CommonUpsertRequest<BasePrivilegeModel> { }

    public class UpsertBasePrivilegeResponse : CommonUpsertResponse<BasePrivilegeModel> { }

    #endregion
    #endregion

    #region Setting
    #region Get
    public class GetBaseSettingsRequest : CommonGetRequest { }

    public class GetBaseSettingsResponse : CommonGetResponse<BaseSettingModel> { }

    #endregion

    #region Upsert
    public class UpsertBaseSettingRequest : CommonUpsertRequest<BaseSettingModel> { }

    public class UpsertBaseSettingResponse : CommonUpsertResponse<BaseSettingModel> { }

    #endregion
    #endregion

    #region SuffixPrifix
    #region Get
    public class GetBaseSuffixPrifixesRequest : CommonGetRequest
    {
        public readonly string SuffixPrefixName;
    }

    public class GetBaseSuffixPrifixesResponse : CommonGetResponse<BaseSuffixPrefixModel> { }
    #endregion

    #region Upsert
    public class UpsertBaseSuffixPrifixRequest : CommonUpsertRequest<BaseSuffixPrefixModel> { }

    public class UpsertBaseSuffixPrifixResponse : CommonUpsertResponse<BaseSuffixPrefixModel> { }

    #endregion
    #endregion
   }
