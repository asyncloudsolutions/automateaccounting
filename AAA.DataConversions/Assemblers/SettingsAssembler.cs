using AAA.DataModels;
using AAA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.DataConversions
{
    public static class SettingsAssembler
    {
        #region BarcodeSetting
        public static IList<BaseBarcodeSettingModel> ToBaseBarcodeSettings(this List<BarcodeSetting> barcodeSettings)
        {
            IList<BaseBarcodeSettingModel> _result = new List<BaseBarcodeSettingModel>();
            barcodeSettings.ForEach(barcodeSetting => _result.Add(barcodeSetting.ToBaseBarcodeSetting()));
            return _result;
        }

        public static BaseBarcodeSettingModel ToBaseBarcodeSetting(this BarcodeSetting barcodeSetting)
        {
            BaseBarcodeSettingModel _result = new BaseBarcodeSettingModel();
            _result.Id = barcodeSetting.Id;
            _result.ShowProductCode = barcodeSetting.ShowProductCode;
            _result.ShowCompanyName = barcodeSetting.ShowCompanyName;
            _result.ShowPurchaseRate = barcodeSetting.ShowPurchaseRate;
            _result.ShowMRP = barcodeSetting.ShowMRP;
            _result.CompanyName = barcodeSetting.CompanyName;
            _result.Point = barcodeSetting.Point;
            _result.Zero = barcodeSetting.Zero;
            _result.One = barcodeSetting.One;
            _result.Two = barcodeSetting.Two;
            _result.Three = barcodeSetting.Three;
            _result.Four = barcodeSetting.Four;
            _result.Five = barcodeSetting.Five;
            _result.Six = barcodeSetting.Six;
            _result.Seven = barcodeSetting.Seven;
            _result.Eight = barcodeSetting.Eight;
            _result.Nine = barcodeSetting.Nine;
            _result.CreatedDate = barcodeSetting.CreatedDate;
            _result.ModifiedDate = barcodeSetting.ModifiedDate;
            return _result;
        }
        #endregion

        #region Field
        public static IList<BaseFieldModel> ToBaseFields(this List<Field> fields)
        {
            IList<BaseFieldModel> _result = new List<BaseFieldModel>();
            fields.ForEach(field => _result.Add(field.ToBaseField()));
            return _result;
        }

        public static BaseFieldModel ToBaseField(this Field field)
        {
            BaseFieldModel _result = new BaseFieldModel();
            _result.Id = field.Id;
            _result.FormId = field.FormId;
            _result.FieldName = field.FieldName;
            _result.CreatedDate = field.CreatedDate;
            _result.ModifiedDate = field.ModifiedDate;
            return _result;
        }
        #endregion

        #region FinancialYear
        public static IList<BaseFinancialYearModel> ToBaseFinancialYears(this List<FinancialYear> financialYears)
        {
            IList<BaseFinancialYearModel> _result = new List<BaseFinancialYearModel>();
            financialYears.ForEach(financialYear => _result.Add(financialYear.ToBaseFinancialYear()));
            return _result;
        }

        public static BaseFinancialYearModel ToBaseFinancialYear(this FinancialYear financialYear)
        {
            BaseFinancialYearModel _result = new BaseFinancialYearModel();
            _result.Id = financialYear.Id;
            _result.FromDate = financialYear.FromDate;
            _result.ToDate = financialYear.ToDate;
            _result.CreatedDate = financialYear.CreatedDate;
            _result.ModifiedDate = financialYear.ModifiedDate;
            return _result;
        }
        #endregion

        #region Form
        public static IList<BaseFormModel> ToBaseForms(this List<Form> forms)
        {
            IList<BaseFormModel> _result = new List<BaseFormModel>();
            forms.ForEach(form => _result.Add(form.ToBaseForm()));
            return _result;
        }

        public static BaseFormModel ToBaseForm(this Form form)
        {
            BaseFormModel _result = new BaseFormModel();
            _result.Id = form.Id;
            _result.FormName = form.FormName;
            _result.CreatedDate = form.CreatedDate;
            _result.ModifiedDate = form.ModifiedDate;
            return _result;
        }
        #endregion

        #region Privilege
        public static IList<BasePrivilegeModel> ToBasePrivileges(this List<Privilege> privileges)
        {
            IList<BasePrivilegeModel> _result = new List<BasePrivilegeModel>();
            privileges.ForEach(privilege => _result.Add(privilege.ToBasePrivilege()));
            return _result;
        }

        public static BasePrivilegeModel ToBasePrivilege(this Privilege privilege)
        {
            BasePrivilegeModel _result = new BasePrivilegeModel();
            _result.Id = privilege.Id;
            _result.Action = privilege.Action;
            _result.RoleId = privilege.RoleId;
            _result.Narration = privilege.Narration;
            _result.FormName = privilege.FormName;
            _result.CreatedDate = privilege.CreatedDate;
            _result.ModifiedDate = privilege.ModifiedDate;
            return _result;
        }
        #endregion

        #region Role
        public static IList<BaseRoleModel> ToBaseRoles(this List<Role> roles)
        {
            IList<BaseRoleModel> _result = new List<BaseRoleModel>();
            roles.ForEach(role => _result.Add(role.ToBaseRole()));
            return _result;
        }

        public static BaseRoleModel ToBaseRole(this Role role)
        {
            BaseRoleModel _result = new BaseRoleModel();
            _result.Id = role.Id;
            _result.RoleName = role.RoleName;
            _result.Narration = role.Narration;
            _result.CreatedDate = role.CreatedDate;
            _result.ModifiedDate = role.ModifiedDate;
            return _result;
        }
        #endregion

        #region Setting
        public static IList<BaseSettingModel> ToBaseSettings(this List<Setting> settings)
        {
            IList<BaseSettingModel> _result = new List<BaseSettingModel>();
            settings.ForEach(setting => _result.Add(setting.ToBaseSetting()));
            return _result;
        }

        public static BaseSettingModel ToBaseSetting(this Setting setting)
        {
            BaseSettingModel _result = new BaseSettingModel();
            _result.Id = setting.Id;
            _result.SettingsName = setting.SettingsName;
            _result.Status = setting.Status;
            _result.CreatedDate = setting.CreatedDate;
            _result.ModifiedDate = setting.ModifiedDate;
            return _result;
        }
        #endregion

        #region SuffixPrifix
        public static IList<BaseSuffixPrefixModel> ToBaseSuffixPrefixes(this List<SuffixPrefix> suffixPrifixes)
        {
            IList<BaseSuffixPrefixModel> _result = new List<BaseSuffixPrefixModel>();
            suffixPrifixes.ForEach(suffixPrefix => _result.Add(suffixPrefix.ToBaseSuffixPrefix()));
            return _result;
        }

        public static BaseSuffixPrefixModel ToBaseSuffixPrefix(this SuffixPrefix suffixPrefix)
        {
            BaseSuffixPrefixModel _result = new BaseSuffixPrefixModel();
            _result.Id = suffixPrefix.Id;
            _result.FromDate = suffixPrefix.FromDate;
            _result.ToDate = suffixPrefix.ToDate;
            _result.StartIndex = suffixPrefix.StartIndex;
            _result.Prefix = suffixPrefix.Prefix;
            _result.Suffix = suffixPrefix.Suffix;
            _result.WidthOfNumericalPart = suffixPrefix.WidthOfNumericalPart;
            _result.PrefillWithZero = suffixPrefix.PrefillWithZero;
            _result.Narration = suffixPrefix.Narration;
            _result.VoucherTypeId = suffixPrefix.VoucherTypeId;
            _result.CreatedDate = suffixPrefix.CreatedDate;
            _result.ModifiedDate = suffixPrefix.ModifiedDate;
            return _result;
        }
        #endregion

        #region User
        public static IList<BaseUserModel> ToBaseUsers(this List<User> users)
        {
            IList<BaseUserModel> _result = new List<BaseUserModel>();
            users.ForEach(user => _result.Add(user.ToBaseUser()));
            return _result;
        }

        public static BaseUserModel ToBaseUser(this User user)
        {
            BaseUserModel _result = new BaseUserModel();
            _result.Id = user.Id;
            _result.UserName = user.UserName;
            _result.Password = user.Password;
            _result.Active = user.Active;
            _result.RoleId = user.RoleId;
            _result.Narration = user.Narration;
            _result.CreatedDate = user.CreatedDate;
            _result.ModifiedDate = user.ModifiedDate;
            return _result;
        }
        #endregion
    }
}
