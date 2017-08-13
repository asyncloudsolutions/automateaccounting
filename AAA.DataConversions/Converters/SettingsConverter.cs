using AAA.DataModels;
using AAA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.DataConversions
{
    public static class SettingsConverter
    {
        #region User
        public static User ToUser(this BaseUserModel user)
        {
            User _result = new User();
            if (user.Id.HasValue) { _result.Id = user.Id.GetValueOrDefault(); }
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

        #region SuffixPrifix
        public static SuffixPrefix ToSuffixPrifix(this BaseSuffixPrifixModel suffixPrifix)
        {
            SuffixPrefix _result = new SuffixPrefix();
            if (suffixPrifix.Id.HasValue) { _result.Id = suffixPrifix.Id.GetValueOrDefault(); }
            _result.FromDate = suffixPrifix.FromDate;
            _result.ToDate = suffixPrifix.ToDate;
            _result.StartIndex = suffixPrifix.StartIndex;
            _result.Prefix = suffixPrifix.Prefix;
            _result.Suffix = suffixPrifix.Suffix;
            _result.WidthOfNumericalPart = suffixPrifix.WidthOfNumericalPart;
            _result.PrefillWithZero = suffixPrifix.PrefillWithZero;
            _result.Narration = suffixPrifix.Narration;
            _result.VoucherTypeId = suffixPrifix.VoucherTypeId;
            _result.CreatedDate = suffixPrifix.CreatedDate;
            _result.ModifiedDate = suffixPrifix.ModifiedDate;
            return _result;
        }
        #endregion

        #region Setting
        public static Setting ToSetting(this BaseSettingModel setting)
        {
            Setting _result = new Setting();
            if (setting.Id.HasValue) { _result.Id = setting.Id.GetValueOrDefault(); }
            _result.SettingsName = setting.SettingsName;
            _result.Status = setting.Status;
            _result.CreatedDate = setting.CreatedDate;
            _result.ModifiedDate = setting.ModifiedDate;
            return _result;
        }
        #endregion

        #region Role
        public static Role ToRole(this BaseRoleModel role)
        {
            Role _result = new Role();
            if (role.Id.HasValue) { _result.Id = role.Id.GetValueOrDefault(); }
            _result.RoleName = role.RoleName;
            _result.Narration = role.Narration;
            _result.CreatedDate = role.CreatedDate;
            _result.ModifiedDate = role.ModifiedDate;
            return _result;
        }
        #endregion

        #region Privilege
        public static Privilege ToPrivelege(this BasePrivilegeModel privilege)
        {
            Privilege _result = new Privilege();
            if (privilege.Id.HasValue) { _result.Id = privilege.Id.GetValueOrDefault(); }
            _result.Action = privilege.Action;
            _result.RoleId = privilege.RoleId;
            _result.Narration = privilege.Narration;
            _result.FormName = privilege.FormName;
            _result.CreatedDate = privilege.CreatedDate;
            _result.ModifiedDate = privilege.ModifiedDate;
            return _result;
        }
        #endregion

        #region Form
        public static Form ToForm(this BaseFormModel form)
        {
            Form _result = new Form();
            if (form.Id.HasValue) { _result.Id = form.Id.GetValueOrDefault(); }
            _result.FormName = form.FormName;
            _result.CreatedDate = form.CreatedDate;
            _result.ModifiedDate = form.ModifiedDate;
            return _result;
        }
        #endregion

        #region FinancialYear
        public static FinancialYear ToFinancialYear(this BaseFinancialYearModel financialYear)
        {
            FinancialYear _result = new FinancialYear();
            if (financialYear.Id.HasValue) { _result.Id = financialYear.Id.GetValueOrDefault(); }
            _result.FromDate = financialYear.FromDate;
            _result.ToDate = financialYear.ToDate;
            _result.CreatedDate = financialYear.CreatedDate;
            _result.ModifiedDate = financialYear.ModifiedDate;
            return _result;
        }
        #endregion

        #region Field
        public static Field ToField(this BaseFieldModel field)
        {
            Field _result = new Field();
            if (field.Id.HasValue) { _result.Id = field.Id.GetValueOrDefault(); }
            _result.FormId = field.FormId;
            _result.FieldName = field.FieldName;
            _result.CreatedDate = field.CreatedDate;
            _result.ModifiedDate = field.ModifiedDate;
            return _result;
        }
        #endregion

        #region BarcodeSetting
        public static BarcodeSetting ToBarCodeSetting(this BaseBarcodeSettingModel barCodeSetting)
        {
            BarcodeSetting _result = new BarcodeSetting();
            if (barCodeSetting.Id.HasValue) { _result.Id = barCodeSetting.Id.GetValueOrDefault(); }
            _result.ShowProductCode = barCodeSetting.ShowProductCode;
            _result.ShowCompanyName = barCodeSetting.ShowCompanyName;
            _result.ShowPurchaseRate = barCodeSetting.ShowPurchaseRate;
            _result.ShowMRP = barCodeSetting.ShowMRP;
            _result.CompanyName = barCodeSetting.CompanyName;
            _result.Point = barCodeSetting.Point;
            _result.Zero = barCodeSetting.Zero;
            _result.One = barCodeSetting.One;
            _result.Two = barCodeSetting.Two;
            _result.Three = barCodeSetting.Three;
            _result.Four = barCodeSetting.Four;
            _result.Five = barCodeSetting.Five;
            _result.Six = barCodeSetting.Six;
            _result.Seven = barCodeSetting.Seven;
            _result.Eight = barCodeSetting.Eight;
            _result.Nine = barCodeSetting.Nine;
            _result.CreatedDate = barCodeSetting.CreatedDate;
            _result.ModifiedDate = barCodeSetting.ModifiedDate;
            return _result;
        }
        #endregion


    }
}
