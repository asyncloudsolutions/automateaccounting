using AAA.ReqResp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.DataProviders
{
    public interface IBudgetProvider
    {
        #region BudgetMaster
        #region Get
        Task<GetBaseBudgetMastersResponse> GetBaseBudgetMastersAsync(GetBaseBudgetMastersRequest request);
        #endregion

        #region Upsert
        Task<UpsertBaseBudgetMasterResponse> UpsertBaseBudgetMasterAsync(UpsertBaseBudgetMasterRequest request);
        #endregion
        #endregion

        #region BudgetDetail

        #region Get
        Task<GetBaseBudgetDetailsResponse> GetBaseBudgetDetailsAsync(GetBaseBudgetDetailsRequest request);
        #endregion

        #region Upsert
        Task<UpsertBaseBudgetDetailResponse> UpsertBaseBudgetDetailAsync(UpsertBaseBudgetDetailRequest request);
        #endregion
        #endregion
     }
}
