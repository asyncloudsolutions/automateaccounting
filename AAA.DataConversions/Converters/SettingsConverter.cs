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
    }
}
