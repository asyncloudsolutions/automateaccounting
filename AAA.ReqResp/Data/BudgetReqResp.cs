using AAA.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.ReqResp
{
    #region BudgetMaster
    #region Get
    public class GetBaseBudgetMastersRequest : CommonGetRequest { }

    public class GetBaseBudgetMastersResponse : CommonGetResponse<BaseBudgetMasterModel> { }
    #endregion

    #region Upsert
    public class UpsertBaseBudgetMasterRequest : CommonUpsertRequest<BaseBudgetMasterModel> { }

    public class UpsertBaseBudgetMasterResponse : CommonUpsertResponse<BaseBudgetMasterModel> { }
    #endregion
    #endregion

    #region BudgetDetail
    #region Get
    public class GetBaseBudgetDetailsRequest : CommonGetRequest { }

    public class GetBaseBudgetDetailsResponse : CommonGetResponse<BaseBudgetDetailModel> { }
    #endregion

    #region Upsert
    public class UpsertBaseBudgetDetailRequest : CommonUpsertRequest<BaseBudgetDetailModel> { }

    public class UpsertBaseBudgetDetailResponse : CommonUpsertResponse<BaseBudgetDetailModel> { }
    #endregion
    #endregion
}
