using AAA.DataModels;
using AAA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.DataConversions
{
    public static class CompanyAssembler
    {
        #region Company
        public static IList<BaseCompanyModel> ToBaseCompanies(this List<Company> companies)
        {
            IList<BaseCompanyModel> _result = new List<BaseCompanyModel>();
            companies.ForEach(company => _result.Add(company.ToBaseCompany()));
            return _result;
        }

        public static BaseCompanyModel ToBaseCompany(this Company company)
        {
            BaseCompanyModel _result = new BaseCompanyModel();
            _result.Id = company.Id;
            _result.CompanyName = company.CompanyName;
            _result.Address = company.Address;
            _result.Phone = company.Phone;
            _result.Mobile = company.Mobile;
            _result.Email = company.Email;
            _result.Web = company.Web;
            _result.Country = company.Country;
            _result.State = company.State;
            _result.Pin = company.Pin;
            _result.FinancialYearFrom = company.FinancialYearFrom;
            _result.BooksBeginingFrom = company.BooksBeginingFrom;
            _result.TIN = company.TIN;
            _result.CST = company.CST;
            _result.PAN = company.PAN;
            _result.CurrentDate = company.CurrentDate;
            _result.Logo = company.Logo;
            _result.CurrencyId = company.CurrencyId;
            _result.CreatedDate = company.CreatedDate;
            _result.ModifiedDate = company.ModifiedDate;
            return _result;
        }
        #endregion
    }
}
