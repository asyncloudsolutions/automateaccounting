using AAA.ReqResp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.DataProviders
{
    public interface ICompanyProvider
    {
        #region Company
        #region Get
        Task<GetBaseCompaniesResponse> GetBaseCompaniesAsync(GetBaseCompaniesRequest request);
        #endregion

        #region Upsert
        Task<UpsertBaseCompanyResponse> UpsertBaseCompanyAsync(UpsertBaseCompanyRequest request);
        #endregion
        #endregion
    }
}
