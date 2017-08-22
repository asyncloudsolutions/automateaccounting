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
    public class SettingsProvider : ProviderHelper, ISettingsProvider
    {
        #region User
        #region Get
        public async Task<GetBaseUsersResponse> GetBaseUsersAsync(GetBaseUsersRequest request)
        {
            return await Task.Run(() =>
            {
                GetBaseUsersResponse _response = new GetBaseUsersResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    ExpressionStarter<User> _predicateUser = PredicateBuilder.New<User>(true);
                    if (request.Id.HasValue) { _predicateUser = _predicateUser.And(p => p.Id == request.Id); }
                    List<User> _Users = _dbContext.Users.AsExpandable().Where(_predicateUser).ToList();
                    if (_Users.Any()) { _response.BaseObjects = _Users.ToBaseUsers(); }
                }
                return _response;
            });
        }
        #endregion

        #region Upsert
        public async Task<UpsertBaseUserResponse> UpsertBaseUserAsync(UpsertBaseUserRequest request)
        {
            return await Task.Run(() =>
            {
                UpsertBaseUserResponse _response = new UpsertBaseUserResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    if (request.BaseObject != null)
                    {
                        try
                        {
                            User _User = request.BaseObject.ToUser();
                            UpsertEntity<User>(request.BaseObject.Id, ref _User, _dbContext);
                            _response.BaseObject = _User.ToBaseUser();
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

        #region Role
        #region Get
        public async Task<GetBaseRolesResponse> GetBaseRolesAsync(GetBaseRolesRequest request)
        {
            return await Task.Run(() =>
            {
                GetBaseRolesResponse _response = new GetBaseRolesResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    ExpressionStarter<Role> _predicateRole = PredicateBuilder.New<Role>(true);
                    if (request.Id.HasValue) { _predicateRole = _predicateRole.And(p => p.Id == request.Id); }
                    List<Role> _Roles = _dbContext.Roles.AsExpandable().Where(_predicateRole).ToList();
                    if (_Roles.Any()) { _response.BaseObjects = _Roles.ToBaseRoles(); }
                }
                return _response;
            });
        }
        #endregion

        #region Upsert
        public async Task<UpsertBaseRoleResponse> UpsertBaseRoleAsync(UpsertBaseRoleRequest request)
        {
            return await Task.Run(() =>
            {
                UpsertBaseRoleResponse _response = new UpsertBaseRoleResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    if (request.BaseObject != null)
                    {
                        try
                        {
                            Role _Role = request.BaseObject.ToRole();
                            UpsertEntity<Role>(request.BaseObject.Id, ref _Role, _dbContext);
                            _response.BaseObject = _Role.ToBaseRole();
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

        #region SuffixPrifix
        #region Get
        public async Task<GetBaseSuffixPrifixesResponse> GetBaseSuffixPrifixesAsync(GetBaseSuffixPrifixesRequest request)
        {
            return await Task.Run(() =>
            {
                GetBaseSuffixPrifixesResponse _response = new GetBaseSuffixPrifixesResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    ExpressionStarter<SuffixPrefix> _predicateSuffixPrifix = PredicateBuilder.New<SuffixPrefix>(true);
                    if (request.Id.HasValue) { _predicateSuffixPrifix = _predicateSuffixPrifix.And(p => p.Id == request.Id); }
                    List<SuffixPrefix> _SuffixPrifixes = _dbContext.SuffixPrefixes.AsExpandable().Where(_predicateSuffixPrifix).ToList();
                    if (_SuffixPrifixes.Any()) { _response.BaseObjects = _SuffixPrifixes.ToBaseSuffixPrifix(); }
                }
                return _response;
            });
        }
        #endregion

        #region Upsert
        public async Task<UpsertBaseSuffixPrifixResponse> UpsertBaseSuffixPrifixAsync(UpsertBaseSuffixPrifixRequest request)
        {
            return await Task.Run(() =>
            {
                UpsertBaseSuffixPrifixResponse _response = new UpsertBaseSuffixPrifixResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    if (request.BaseObject != null)
                    {
                        try
                        {
                            SuffixPrefix _SuffixPrifix = request.BaseObject.ToSuffixPrifix();
                            UpsertEntity<SuffixPrefix>(request.BaseObject.Id, ref _SuffixPrifix, _dbContext);
                            _response.BaseObject = _SuffixPrifix.ToBaseSuffixPrifix();
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

        #region Setting
        #region Get
        public async Task<GetBaseSettingsResponse> GetBaseSettingsAsync(GetBaseSettingsRequest request)
        {
            return await Task.Run(() =>
            {
                GetBaseSettingsResponse _response = new GetBaseSettingsResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    ExpressionStarter<Setting> _predicateSetting = PredicateBuilder.New<Setting>(true);
                    if (request.Id.HasValue) { _predicateSetting = _predicateSetting.And(p => p.Id == request.Id); }
                    List<Setting> _Settings = _dbContext.Settings.AsExpandable().Where(_predicateSetting).ToList();
                    if (_Settings.Any()) { _response.BaseObjects = _Settings.ToBaseSetting(); }
                }
                return _response;
            });
        }
        #endregion

        #region Upsert
        public async Task<UpsertBaseSettingResponse> UpsertBaseSettingAsync(UpsertBaseSettingRequest request)
        {
            return await Task.Run(() =>
            {
                UpsertBaseSettingResponse _response = new UpsertBaseSettingResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    if (request.BaseObject != null)
                    {
                        try
                        {
                            Setting _Setting = request.BaseObject.ToSetting();
                            UpsertEntity<Setting>(request.BaseObject.Id, ref _Setting, _dbContext);
                            _response.BaseObject = _Setting.ToBaseSetting();
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

        #region Privilege
        #region Get
        public async Task<GetBasePrivilegesResponse> GetBasePrivilegesAsync(GetBasePrivilegesRequest request)
        {
            return await Task.Run(() =>
            {
                GetBasePrivilegesResponse _response = new GetBasePrivilegesResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    ExpressionStarter<Privilege> _predicatePrivilege = PredicateBuilder.New<Privilege>(true);
                    if (request.Id.HasValue) { _predicatePrivilege = _predicatePrivilege.And(p => p.Id == request.Id); }
                    List<Privilege> _Privileges = _dbContext.Privileges.AsExpandable().Where(_predicatePrivilege).ToList();
                    if (_Privileges.Any()) { _response.BaseObjects = _Privileges.ToBasePrivilege(); }
                }
                return _response;
            });
        }
        #endregion

        #region Upsert
        public async Task<UpsertBasePrivilegeResponse> UpsertBasePrivilegeAsync(UpsertBasePrivilegeRequest request)
        {
            return await Task.Run(() =>
            {
                UpsertBasePrivilegeResponse _response = new UpsertBasePrivilegeResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    if (request.BaseObject != null)
                    {
                        try
                        {
                            Privilege _Privilege = request.BaseObject.ToPrivelege();
                            UpsertEntity<Privilege>(request.BaseObject.Id, ref _Privilege, _dbContext);
                            _response.BaseObject = _Privilege.ToBasePrivilege();
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

        #region Form
        #region Get
        public async Task<GetBaseFormsResponse> GetBaseFormsAsync(GetBaseFormsRequest request)
        {
            return await Task.Run(() =>
            {
                GetBaseFormsResponse _response = new GetBaseFormsResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    ExpressionStarter<Form> _predicateForm = PredicateBuilder.New<Form>(true);
                    if (request.Id.HasValue) { _predicateForm = _predicateForm.And(p => p.Id == request.Id); }
                    List<Form> _Forms = _dbContext.Forms.AsExpandable().Where(_predicateForm).ToList();
                    if (_Forms.Any()) { _response.BaseObjects = _Forms.ToBaseForm(); }
                }
                return _response;
            });
        }
        #endregion

        #region Upsert
        public async Task<UpsertBaseFormResponse> UpsertBaseFormAsync(UpsertBaseFormRequest request)
        {
            return await Task.Run(() =>
            {
                UpsertBaseFormResponse _response = new UpsertBaseFormResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    if (request.BaseObject != null)
                    {
                        try
                        {
                            Form _Form = request.BaseObject.ToForm();
                            UpsertEntity<Form>(request.BaseObject.Id, ref _Form, _dbContext);
                            _response.BaseObject = _Form.ToBaseForm();
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

        #region FinancialYear
        #region Get
        public async Task<GetBaseFinancialYearsResponse> GetBaseFinancialYearsAsync(GetBaseFinancialYearsRequest request)
        {
            return await Task.Run(() =>
            {
                GetBaseFinancialYearsResponse _response = new GetBaseFinancialYearsResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    ExpressionStarter<FinancialYear> _predicateFinancialYear = PredicateBuilder.New<FinancialYear>(true);
                    if (request.Id.HasValue) { _predicateFinancialYear = _predicateFinancialYear.And(p => p.Id == request.Id); }
                    List<FinancialYear> _FinancialYears = _dbContext.FinancialYears.AsExpandable().Where(_predicateFinancialYear).ToList();
                    if (_FinancialYears.Any()) { _response.BaseObjects = _FinancialYears.ToBaseFinancialYear(); }
                }
                return _response;
            });
        }
        #endregion

        #region Upsert
        public async Task<UpsertBaseFinancialYearResponse> UpsertBaseFinancialYearAsync(UpsertBaseFinancialYearRequest request)
        {
            return await Task.Run(() =>
            {
                UpsertBaseFinancialYearResponse _response = new UpsertBaseFinancialYearResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    if (request.BaseObject != null)
                    {
                        try
                        {
                            FinancialYear _FinancialYear = request.BaseObject.ToFinancialYear();
                            UpsertEntity<FinancialYear>(request.BaseObject.Id, ref _FinancialYear, _dbContext);
                            _response.BaseObject = _FinancialYear.ToBaseFinancialYear();
                        }
                        catch (Exception ex) { AssignStatusData(_response, false, string.Format ("Some error occurred during DB interaction. Message is something like : \n{0}", ex.Message)); }
                    }
                    else { AssignStatusData(_response, false, "No entity data recieved to insert/update."); }
                }
                return _response;
            });
        }
        #endregion
        #endregion

        #region Field
        #region Get
        public async Task<GetBaseFieldsResponse> GetBaseFieldsAsync(GetBaseFieldsRequest request)
        {
            return await Task.Run(() =>
            {
                GetBaseFieldsResponse _response = new GetBaseFieldsResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    ExpressionStarter<Field> _predicateField = PredicateBuilder.New<Field>(true);
                    if (request.Id.HasValue) { _predicateField = _predicateField.And(p => p.Id == request.Id); }
                    List<Field> _Fields = _dbContext.Fields.AsExpandable().Where(_predicateField).ToList();
                    if (_Fields.Any()) { _response.BaseObjects = _Fields.ToBaseField(); }
                }
                return _response;
            });
        }
        #endregion

        #region Upsert
        public async Task<UpsertBaseFieldResponse> UpsertBaseFieldAsync(UpsertBaseFieldRequest request)
        {
            return await Task.Run(() =>
            {
                UpsertBaseFieldResponse _response = new UpsertBaseFieldResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    if (request.BaseObject != null)
                    {
                        try
                        {
                            Field _Field = request.BaseObject.ToField();
                            UpsertEntity<Field>(request.BaseObject.Id, ref _Field, _dbContext);
                            _response.BaseObject = _Field.ToBaseField();
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

        #region BarcodeSetting
        #region Get
        public async Task<GetBaseBarcodeSettingsResponse> GetBaseBarcodeSettingsAsync(GetBaseBarcodeSettingsRequest request)
        {
            return await Task.Run(() =>
            {
                GetBaseBarcodeSettingsResponse _response = new GetBaseBarcodeSettingsResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    ExpressionStarter<BarcodeSetting> _predicateBarcodeSetting = PredicateBuilder.New<BarcodeSetting>(true);
                    if (request.Id.HasValue) { _predicateBarcodeSetting = _predicateBarcodeSetting.And(p => p.Id == request.Id); }
                    List<BarcodeSetting> _barcodeSettings = _dbContext.BarcodeSettings.AsExpandable().Where(_predicateBarcodeSetting).ToList();
                    if (_barcodeSettings.Any()) { _response.BaseObjects = _barcodeSettings.ToBaseBarcodeSettings(); }
                }
                return _response;
            });
        }
        #endregion

        #region Upsert
        public async Task<UpsertBaseBarcodeSettingResponse> UpsertBaseBarcodeSettingAsync(UpsertBaseBarcodeSettingRequest request)
        {
            return await Task.Run(() =>
            {
                UpsertBaseBarcodeSettingResponse _response = new UpsertBaseBarcodeSettingResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    if (request.BaseObject != null)
                    {
                        try
                        {
                            BarcodeSetting _barcodeSetting = request.BaseObject.ToBarcodeSetting();
                            UpsertEntity<BarcodeSetting>(request.BaseObject.Id, ref _barcodeSetting, _dbContext);
                            _response.BaseObject = _barcodeSetting.ToBaseBarcodeSetting();
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
