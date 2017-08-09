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
}
