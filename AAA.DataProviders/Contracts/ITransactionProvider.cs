using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.DataProviders
{
    public interface ITransactionProvider
    {
        
        #region LedgerPosting
        #region Get
        Task<GetBaseLedgerPostingsResponse> GetBaseLedgerPostingsAsync(GetBaseLedgerPostingsRequest request);
        #endregion

        #region Upsert
        Task<UpsertBaseLedgerPostingResponse> UpsertBaseLedgerPostingAsync(UpsertBaseLedgerPostingRequest request);
        #endregion
        #endregion

        
        #region BankReconciliation
        #region Get
        Task<GetBaseBankReconciliationsResponse> GetBaseBankReconciliationsAsync(GetBaseBankReconciliationsRequest request);
        #endregion

        #region Upsert
        Task<UpsertBaseBankReconciliationResponse> UpsertBaseBankReconciliationAsync(UpsertBaseBankReconciliationRequest request);
        #endregion
        #endregion

        
        #region Detail
        #region Get
        Task<GetBaseDetailsResponse> GetBaseDetailsAsync(GetBaseDetailsRequest request);
        #endregion

        #region Upsert
        Task<UpsertBaseDetailResponse> UpsertBaseDetailAsync(UpsertBaseDetailRequest request);
        #endregion
        #endregion
    }
}
