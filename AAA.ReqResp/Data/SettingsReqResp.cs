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
    #endregion
}
