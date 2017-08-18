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
    public class BudgetProvider : ProviderHelper, IBudgetProvider
    {
        #region BudgetMaster
        #region Get
        public async Task<GetBaseBudgetMastersResponse> GetBaseBudgetMastersAsync(GetBaseBudgetMastersRequest request)
        {
            return await Task.Run(() =>
            {
                GetBaseBudgetMastersResponse _response = new GetBaseBudgetMastersResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    ExpressionStarter<BudgetMaster> _predicateBudgetMaster = PredicateBuilder.New<BudgetMaster>(true);
                    if (request.Id.HasValue) { _predicateBudgetMaster = _predicateBudgetMaster.And(p => p.Id == request.Id); }
                    List<BudgetMaster> _BudgetMasters = _dbContext.BudgetMasters.AsExpandable().Where(_predicateBudgetMaster).ToList();
                    if (_BudgetMasters.Any()) { _response.BaseObjects = _BudgetMasters.ToBaseBudgetMasters(); }
                }
                return _response;
            });
        }
        #endregion

        #region Upsert
        public async Task<UpsertBaseBudgetMasterResponse> UpsertBaseBudgetMasterAsync(UpsertBaseBudgetMasterRequest request)
        {
            return await Task.Run(() =>
            {
                UpsertBaseBudgetMasterResponse _response = new UpsertBaseBudgetMasterResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    if (request.BaseObject != null)
                    {
                        try
                        {
                            BudgetMaster _BudgetMaster = request.BaseObject.ToBudgetMaster();
                            UpsertEntity<BudgetMaster>(request.BaseObject.Id, ref _BudgetMaster, _dbContext);
                            _response.BaseObject = _BudgetMaster.ToBaseBudgetMaster();
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

        #region BudgetDetail
        #region Get
        public async Task<GetBaseBudgetDetailsResponse> GetBaseBudgetDetailsAsync(GetBaseBudgetDetailsRequest request)
        {
            return await Task.Run(() =>
            {
                GetBaseBudgetDetailsResponse _response = new GetBaseBudgetDetailsResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    ExpressionStarter<BudgetDetail> _predicateBudgetDetail = PredicateBuilder.New<BudgetDetail>(true);
                    if (request.Id.HasValue) { _predicateBudgetDetail = _predicateBudgetDetail.And(p => p.Id == request.Id); }
                    List<BudgetDetail> _BudgetDetails = _dbContext.BudgetDetails.AsExpandable().Where(_predicateBudgetDetail).ToList();
                    if (_BudgetDetails.Any()) { _response.BaseObjects = _BudgetDetails.ToBaseBudgetDetail(); }
                }
                return _response;
            });
        }
        #endregion

        #region Upsert
        public async Task<UpsertBaseBudgetDetailResponse> UpsertBaseBudgetDetailAsync(UpsertBaseBudgetDetailRequest request)
        {
            return await Task.Run(() =>
            {
                UpsertBaseBudgetDetailResponse _response = new UpsertBaseBudgetDetailResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    if (request.BaseObject != null)
                    {
                        try
                        {
                            BudgetDetail _BudgetDetail = request.BaseObject.ToBudgetDetail();
                            UpsertEntity<BudgetDetail>(request.BaseObject.Id, ref _BudgetDetail, _dbContext);
                            _response.BaseObject = _BudgetDetail.ToBaseBudgetDetail();
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
