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
    }
}
