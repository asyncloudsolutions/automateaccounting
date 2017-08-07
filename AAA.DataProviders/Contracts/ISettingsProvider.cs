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
        #endregion
    }
}
