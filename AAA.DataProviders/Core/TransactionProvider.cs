using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.DataProviders
{
    public class TransactionProvider : ProviderHelper, ITransactionProvider
    {
        #region LedgerPosting
        #region Get
        public async Task<GetBaseLedgerPostingsResponse> GetBaseLedgerPostingsAsync(GetBaseLedgerPostingsRequest request)
        {
            return await Task.Run(() =>
            {
                GetBaseLedgerPostingsResponse _response = new GetBaseLedgerPostingsResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    ExpressionStarter<LedgerPosting> _predicateLedgerPosting = PredicateBuilder.New<LedgerPosting>(true);
                    if (request.Id.HasValue) { _predicateLedgerPosting = _predicateLedgerPosting.And(p => p.Id == request.Id); }
                    List<LedgerPosting> _ledgerPostings = _dbContext.LedgerPostings.AsExpandable().Where(_predicateLedgerPosting).ToList();
                    if (_ledgerPostings.Any()) { _response.BaseObjects = _ledgerPostings.ToBaseLedgerPostings(); }
                }
                return _response;
            });
        }
        #endregion

        #region Upsert
        public async Task<UpsertBaseLedgerPostingResponse> UpsertBaseLedgerPostingAsync(UpsertBaseLedgerPostingRequest request)
        {
            return await Task.Run(() =>
            {
                UpsertBaseLedgerPostingResponse _response = new UpsertBaseLedgerPostingResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    if (request.BaseObject != null)
                    {
                        try
                        {
                            LedgerPosting _ledgerPosting = request.BaseObject.ToLedgerPosting();
                            UpsertEntity<LedgerPosting>(request.BaseObject.Id, ref _ledgerPosting, _dbContext);
                            _response.BaseObject = _ledgerPosting.ToBaseLedgerPosting();
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

        #region BankReconciliation
        #region Get
        public async Task<GetBaseBankReconciliationsResponse> GetBaseBankReconciliationsAsync(GetBaseBankReconciliationsRequest request)
        {
            return await Task.Run(() =>
            {
                GetBaseBankReconciliationsResponse _response = new GetBaseBankReconciliationsResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    ExpressionStarter<BankReconciliation> _predicateBankReconciliation = PredicateBuilder.New<BankReconciliation>(true);
                    if (request.Id.HasValue) { _predicateBankReconciliation = _predicateBankReconciliation.And(p => p.Id == request.Id); }
                    List<BankReconciliation> _bankReconciliations = _dbContext.BankReconciliations.AsExpandable().Where(_predicateBankReconciliation).ToList();
                    if (_bankReconciliations.Any()) { _response.BaseObjects = _bankReconciliations.ToBaseBankReconciliations(); }
                }
                return _response;
            });
        }
        #endregion

        #region Upsert
        public async Task<UpsertBaseBankReconciliationResponse> UpsertBaseBankReconciliationAsync(UpsertBaseBankReconciliationRequest request)
        {
            return await Task.Run(() =>
            {
                UpsertBaseBankReconciliationResponse _response = new UpsertBaseBankReconciliationResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    if (request.BaseObject != null)
                    {
                        try
                        {
                            BankReconciliation _bankReconciliation = request.BaseObject.ToBankReconciliation();
                            UpsertEntity<BankReconciliation>(request.BaseObject.Id, ref _bankReconciliation, _dbContext);
                            _response.BaseObject = _bankReconciliation.ToBaseBankReconciliation();
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

        #region Detail
        #region Get
        public async Task<GetBaseDetailsResponse> GetBaseDetailsAsync(GetBaseDetailsRequest request)
        {
            return await Task.Run(() =>
            {
                GetBaseDetailsResponse _response = new GetBaseDetailsResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    ExpressionStarter<Detail> _predicateDetail = PredicateBuilder.New<Detail>(true);
                    if (request.Id.HasValue) { _predicateDetail = _predicateDetail.And(p => p.Id == request.Id); }
                    List<Detail> _details = _dbContext.Details.AsExpandable().Where(_predicateDetail).ToList();
                    if (_details.Any()) { _response.BaseObjects = _details.ToBaseDetails(); }
                }
                return _response;
            });
        }
        #endregion

        #region Upsert
        public async Task<UpsertBaseDetailResponse> UpsertBaseDetailAsync(UpsertBaseDetailRequest request)
        {
            return await Task.Run(() =>
            {
                UpsertBaseDetailResponse _response = new UpsertBaseDetailResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    if (request.BaseObject != null)
                    {
                        try
                        {
                            Detail _detail = request.BaseObject.ToDetail();
                            UpsertEntity<Detail>(request.BaseObject.Id, ref _detail, _dbContext);
                            _response.BaseObject = _detail.ToBaseDetail();
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
