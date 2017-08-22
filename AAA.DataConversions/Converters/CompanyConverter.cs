using AAA.DataModels;
using AAA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.DataConversions
{
    public static class CompanyConverter
    {
        #region Company
        public static Company ToCompany(this BaseCompanyModel company)
        {
            Company _result = new Company();
            if (company.Id.HasValue) { _result.Id = company.Id.GetValueOrDefault(); }
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

        #region CompanyPath
        public static CompanyPath ToCompanyPath(this BaseCompanyPathModel companyPath)
        {
            CompanyPath _result = new CompanyPath();
            if (companyPath.Id.HasValue) { _result.Id = companyPath.Id.GetValueOrDefault(); }
            _result.CompanyName = companyPath.CompanyName;
            _result.CompanyPath1 = companyPath.CompanyPath1;
            _result.IsDefault = companyPath.IsDefault;
            _result.CreatedDate = companyPath.CreatedDate;
            _result.ModifiedDate = companyPath.ModifiedDate;
            return _result;
        }
        #endregion
    }
}
