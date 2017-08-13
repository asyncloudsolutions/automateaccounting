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

        public static IList<BaseBarcodeSettingModel> ToBaseBarcodeSetting(this List<BarcodeSetting> barcodeSettings)
        {
            IList<BaseBarcodeSettingModel> _result = new List<BaseBarcodeSettingModel>();
            barcodeSettings.ForEach(BarcodeSetting => _result.Add(BarcodeSetting.ToBaseBarcodeSetting()));
            return _result;
        }

        public static BaseBarcodeSettingModel ToBaseBarcodeSetting(this BarcodeSetting BarcodeSetting)
        {
            BaseBarcodeSettingModel _result = new BaseBarcodeSettingModel();
            _result.ShowProductCode = BarcodeSetting.ShowProductCode;
            _result.ShowCompanyName = BarcodeSetting.ShowCompanyName;
            _result.ShowPurchaseRate = BarcodeSetting.ShowPurchaseRate;
            _result.ShowMRP = BarcodeSetting.ShowMRP;
            _result.CompanyName = BarcodeSetting.CompanyName;
            _result.Point = BarcodeSetting.Point;
            _result.Zero = BarcodeSetting.Zero;
            _result.One = BarcodeSetting.One;
            _result.Two = BarcodeSetting.Two;
            _result.Three = BarcodeSetting.Three;
            _result.Four = BarcodeSetting.Four;
            _result.Five = BarcodeSetting.Five;
            _result.Six = BarcodeSetting.Six;
            _result.Seven = BarcodeSetting.Seven;
            _result.Eight = BarcodeSetting.Eight;
            _result.Nine = BarcodeSetting.Nine;

            return _result;
        }

        #endregion

        #region Field
        public static IList<BaseFieldModel> ToBaseField(this List<Field> Fields)
        {
            IList<BaseFieldModel> _result = new List<BaseFieldModel>();
            Fields.ForEach(Field => _result.Add(Field.ToBaseField()));
            return _result;
        }

        public static BaseFieldModel ToBaseField(this Field Field)
        {
            BaseFieldModel _result = new BaseFieldModel();
            _result.FormId = Field.Id;
            _result.FieldName = Field.FieldName;
            return _result;
        }
        #endregion

        #region FinancialYear
        public static IList<BaseFinancialYearModel> ToBaseFinancialYear(this List<FinancialYear> financialYears)
        {
            IList<BaseFinancialYearModel> _result = new List<BaseFinancialYearModel>();
            financialYears.ForEach(FinancialYear => _result.Add(FinancialYear.ToBaseFinancialYear()));
            return _result;
        }

        public static BaseFinancialYearModel ToBaseFinancialYear(this FinancialYear FinancialYear)
        {
            BaseFinancialYearModel _result = new BaseFinancialYearModel();
            _result.FromDate = FinancialYear.FromDate;
            _result.ToDate = FinancialYear.ToDate;
            return _result;
        }
        #endregion

        #region Form
        public static IList<BaseFormModel> ToBaseForm(this List<Form> Forms)
        {
            IList<BaseFormModel> _result = new List<BaseFormModel>();
            Forms.ForEach(Form => _result.Add(Form.ToBaseForm()));
            return _result;
        }

        public static BaseFormModel ToBaseForm(this Form Form)
        {
            BaseFormModel _result = new BaseFormModel();
            _result.FormName = Form.FormName;
            return _result;
        }
        #endregion

        #region Privilege
        public static IList<BasePrivilegeModel> ToBasePrivilege(this List<Privilege> privileges)
        {
            IList<BasePrivilegeModel> _result = new List<BasePrivilegeModel>();
            privileges.ForEach(Privilege => _result.Add(Privilege.ToBasePrivilege()));
            return _result;
        }

        public static BasePrivilegeModel ToBasePrivilege(this Privilege Privilege)
        {
            BasePrivilegeModel _result = new BasePrivilegeModel();
            _result.Action = Privilege.Action;
            _result.RoleId = Privilege.RoleId;
            _result.Narration = Privilege.Narration;
            _result.FormName = Privilege.FormName;

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
        public static IList<BaseSettingModel> ToBaseSetting(this List<Setting> settings)
        {
            IList<BaseSettingModel> _result = new List<BaseSettingModel>();
            settings.ForEach(Setting => _result.Add(Setting.ToBaseSetting()));
            return _result;
        }

        public static BaseSettingModel ToBaseSetting(this Setting Setting)
        {
            BaseSettingModel _result = new BaseSettingModel();
            _result.SettingsName = Setting.SettingsName;
            _result.Status = Setting.Status;
            return _result;
        }
        #endregion



        #region SuffixPrifix

        public static IList<BaseSuffixPrifixModel> ToBaseSuffixPrifix(this List<SuffixPrefix> suffixPrifixs)
        {
            IList<BaseSuffixPrifixModel> _result = new List<BaseSuffixPrifixModel>();
            suffixPrifixs.ForEach(SuffixPrifix => _result.Add(SuffixPrifix.ToBaseSuffixPrifix()));
            return _result;
        }

        public static BaseSuffixPrifixModel ToBaseSuffixPrifix(this SuffixPrefix SuffixPrifix)
        {
            BaseSuffixPrifixModel _result = new BaseSuffixPrifixModel();
            _result.FromDate = SuffixPrifix.FromDate;
            _result.ToDate = SuffixPrifix.ToDate;
            _result.StartIndex = SuffixPrifix.StartIndex;
            _result.Prefix = SuffixPrifix.Prefix;
            _result.Suffix = SuffixPrifix.Suffix;
            _result.WidthOfNumericalPart = SuffixPrifix.WidthOfNumericalPart;
            _result.PrefillWithZero = SuffixPrifix.PrefillWithZero;
            _result.Narration = SuffixPrifix.Narration;
            _result.VoucherTypeId = SuffixPrifix.VoucherTypeId;
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
