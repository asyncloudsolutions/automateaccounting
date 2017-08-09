using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AAA.ReqResp;
using AAA.Entities;
using AAA.DataConversions;
using AAA.DataModels;
using LinqKit;

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
                    if (!string.IsNullOrEmpty(request.UserName)) { _predicateUser = _predicateUser.And(p => p.UserName == request.UserName); }
                    if (!string.IsNullOrEmpty(request.Password)) { _predicateUser = _predicateUser.And(p => p.Password == request.Password); }
                    List<User> _users = _dbContext.Users.AsExpandable().Where(_predicateUser).ToList();
                    if (_users.Any()) { _response.BaseObjects = _users.ToBaseUsers(); }
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
                            User _user = request.BaseObject.ToUser();
                            UpsertEntity<User>(request.BaseObject.Id, ref _user, _dbContext);
                            _response.BaseObject = _user.ToBaseUser();
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
                    List<Role> _roles = _dbContext.Roles.AsExpandable().Where(_predicateRole).ToList();
                    if (_roles.Any()) { _response.BaseObjects = _roles.ToBaseRoles(); }
                }
                return _response;
            });
        }
        #endregion
        #endregion
    }
}
