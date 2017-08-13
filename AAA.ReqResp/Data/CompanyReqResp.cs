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

    #region CompanyPath
    #region Get
    public class GetBaseCompanyPathsRequest : CommonGetRequest { }

    public class GetBaseCompanyPathsResponse : CommonGetResponse<BaseCompanyPathModel> { }
    #endregion

    #region Upsert
    public class UpsertBaseCompanyPathRequest : CommonUpsertRequest<BaseCompanyPathModel> { }

    public class UpsertBaseCompanyPathResponse : CommonUpsertResponse<BaseCompanyPathModel> { }
    #endregion
    #endregion

}

