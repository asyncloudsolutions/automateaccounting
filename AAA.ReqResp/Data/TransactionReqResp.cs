using AAA.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.ReqResp
{
    #region LedgerPosting
    #region Get
    public class GetBaseLedgerPostingsRequest : CommonGetRequest { }

    public class GetBaseLedgerPostingsResponse : CommonGetResponse<BaseLedgerPostingModel> { }
    #endregion

    #region Upsert
    public class UpsertBaseLedgerPostingRequest : CommonUpsertRequest<BaseLedgerPostingModel> { }

    public class UpsertBaseLedgerPostingResponse : CommonUpsertResponse<BaseLedgerPostingModel> { }
    #endregion
    #endregion

    #region BankReconciliation
    #region Get
    public class GetBaseBankReconciliationsRequest : CommonGetRequest { }

    public class GetBaseBankReconciliationsResponse : CommonGetResponse<BaseLedgerPostingModel> { }
    #endregion

    #region Upsert
    public class UpsertBaseBankReconciliationRequest : CommonUpsertRequest<BaseBankReconciliationModel> { }

    public class UpsertBaseBankReconciliationResponse : CommonUpsertResponse<BaseBankReconciliationModel> { }
    #endregion
    #endregion

    #region Detail
    #region Get
    public class GetBaseDetailsRequest : CommonGetRequest { }

    public class GetBaseDetailsResponse : CommonGetResponse<BaseDetailModel> { }
    #endregion

    #region Upsert
    public class UpsertBaseDetailRequest : CommonUpsertRequest<BaseDetailModel> { }

    public class UpsertBaseDetailResponse : CommonUpsertResponse<BaseDetailModel> { }
    #endregion
    #endregion
}
