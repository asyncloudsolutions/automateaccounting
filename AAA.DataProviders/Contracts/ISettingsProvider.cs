using AAA.ReqResp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.DataProviders
{
    public interface ISettingsProvider
    {
        #region User
        #region Get
        Task<GetBaseUsersResponse> GetBaseUsersAsync(GetBaseUsersRequest request);
        #endregion

        #region Upsert
        Task<UpsertBaseUserResponse> UpsertBaseUserAsync(UpsertBaseUserRequest request);
        #endregion
        #endregion

        #region Role
        #region Get
        Task<GetBaseRolesResponse> GetBaseRolesAsync(GetBaseRolesRequest request);
        #endregion

        #region Upsert
        Task<UpsertBaseRoleResponse> UpsertBaseRoleAsync(UpsertBaseRoleRequest request);
        #endregion
        #endregion

        #region SuffixPrifix
        #region Get
        Task<GetBaseSuffixPrifixesResponse> GetBaseSuffixPrifixsAsync(GetBaseSuffixPrifixesRequest request);
        #endregion

        #region Upsert
        Task<UpsertBaseSuffixPrifixResponse> UpsertBaseSuffixPrifixAsync(UpsertBaseSuffixPrifixRequest request);
        #endregion
        #endregion

        #region Setting
        #region Get
        Task<GetBaseSettingsResponse> GetBaseSettingsAsync(GetBaseSettingsRequest request);
        #endregion

        #region Upsert
        Task<UpsertBaseSettingResponse> UpsertBaseSettingAsync(UpsertBaseSettingRequest request);
        #endregion
        #endregion

        #region Privilege
        #region Get
        Task<GetBasePrivilegesResponse> GetBasePrivilegesAsync(GetBasePrivilegesRequest request);
        #endregion

        #region Upsert
        Task<UpsertBasePrivilegeResponse> UpsertBasePrivilegeAsync(UpsertBasePrivilegeRequest request);
        #endregion
        #endregion

        #region Form
        #region Get
        Task<GetBaseFormsResponse> GetBaseRFormsAsync(GetBaseFormsRequest request);
        #endregion

        #region Upsert
        Task<UpsertBaseFormResponse> UpsertBaseFormAsync(UpsertBaseFormRequest request);
        #endregion
        #endregion

        #region FinancialYear
        #region Get
        Task<GetBaseFinancialYearsResponse> GetBaseUsersAsync(GetBaseFinancialYearsRequest request);
        #endregion

        #region Upsert
        Task<UpsertBaseFinancialYearResponse> UpsertBaseFinancialYearAsync(UpsertBaseFinancialYearRequest request);
        #endregion
        #endregion

        #region Field
        #region Get
        Task<GetBaseFieldsResponse> GetBaseFieldsAsync(GetBaseFieldsRequest request);
        #endregion

        #region Upsert
        Task<UpsertBaseFieldResponse> UpsertBaseFieldAsync(UpsertBaseFieldRequest request);
        #endregion
        #endregion

        #region BarCodeSetting
        #region Get
        Task<GetBaseBarcodeSettingsResponse> GetBaseBarcodeSettingsAsync(GetBaseBarcodeSettingsRequest request);
        #endregion

        #region Upsert
        Task<UpsertBaseBarcodeSettingResponse> UpsertBaseBarcodeSettingAsync(UpsertBaseBarcodeSettingRequest request);
        #endregion
        #endregion

    }
        }
