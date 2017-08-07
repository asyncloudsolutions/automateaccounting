using AAA.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.ReqResp
{
    #region Company
    #region Get
    public class GetBaseCompaniesRequest : CommonGetRequest { }

    public class GetBaseCompaniesResponse : CommonGetResponse<BaseCompanyModel> { }
    #endregion

    #region Upsert
    public class UpsertBaseCompanyRequest : CommonUpsertRequest<BaseCompanyModel> { }

    public class UpsertBaseCompanyResponse : CommonUpsertResponse<BaseCompanyModel> { }
    #endregion
    #endregion
}

