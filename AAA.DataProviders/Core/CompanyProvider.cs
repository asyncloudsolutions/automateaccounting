using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AAA.ReqResp;
using AAA.Entities;
using LinqKit;
using AAA.DataConversions;

namespace AAA.DataProviders
{
    public class CompanyProvider : ICompanyProvider
    {
        #region Company
        #region Get
        public async Task<GetBaseCompaniesResponse> GetBaseCompaniesAsync(GetBaseCompaniesRequest request)
        {
            return await Task.Run(() =>
            {
                GetBaseCompaniesResponse _response = new GetBaseCompaniesResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    ExpressionStarter<Company> _predicateCompany = PredicateBuilder.New<Company>(true);
                    if (request.Id.HasValue) { _predicateCompany = _predicateCompany.And(p => p.Id == request.Id); }
                    List<Company> _companies = _dbContext.Companies.AsExpandable().Where(_predicateCompany).ToList();
                    if (_companies.Any()) { _response.BaseObjects = _companies.ToBaseCompanies(); }
                }
                return _response;
            });
        }
        #endregion

        #region Upsert
        public async Task<UpsertBaseCompanyResponse> UpsertBaseCompanyAsync(UpsertBaseCompanyRequest request)
        {
            return await Task.Run(() =>
            {
                UpsertBaseCompanyResponse _response = new UpsertBaseCompanyResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    if (request.BaseObject != null)
                    {
                        try
                        {
                            Company _company = request.BaseObject.ToCompany();
                            if (request.BaseObject.Id.HasValue) { _dbContext.Entry(_company).State = System.Data.Entity.EntityState.Modified; }
                            else { _dbContext.Companies.Add(_company); }
                            _dbContext.SaveChanges();
                            _response.BaseObject = _company.ToBaseCompany();
                        }
                        catch (Exception ex)
                        {
                            _response.Status = false;
                            _response.StatusMessage = string.Format("Some error occurred during DB interaction. Message is something like : \n{0}", ex.Message);
                        }
                    }
                    else
                    {
                        _response.Status = false;
                        _response.StatusMessage = "No entity data recieved to insert/update.";
                    }
                }
                return _response;
            });
        }
        #endregion
        #endregion
    }
}
