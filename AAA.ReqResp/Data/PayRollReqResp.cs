using AAA.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.ReqResp
{
    #region Employee
    #region Get
    public class GetBaseEmployeesRequest : CommonGetRequest { }

    public class GetBaseEmployeesResponse : CommonGetResponse<BaseEmployeeModel> { }
    #endregion

    #region Upsert
    public class UpsertBaseEmployeeRequest : CommonUpsertRequest<BaseEmployeeModel> { }

    public class UpsertBaseEmployeeResponse : CommonUpsertResponse<BaseEmployeeModel> { }
    #endregion
    #endregion
}
