using AAA.DataModels;
using AAA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.DataConversions
{
    public static class BudgetConverter
    {
        #region BudgetMaster

        public static BudgetMaster ToBudgetMaster(this BaseBudgetMasterModel budgetMaster)
        {
            BudgetMaster _result = new BudgetMaster();
            if (budgetMaster.Id.HasValue) { _result.Id = budgetMaster.Id.GetValueOrDefault(); }
            _result.BudgetName = budgetMaster.BudgetName;
            _result.Type = budgetMaster.Type;
            _result.FromDate = budgetMaster.FromDate;
            _result.ToDate = budgetMaster.ToDate;
            _result.TotalDr = budgetMaster.TotalDr;
            _result.TotalCr = budgetMaster.TotalCr;
            _result.Narration = budgetMaster.Narration;
            _result.CreatedDate = budgetMaster.CreatedDate;
            _result.ModifiedDate = budgetMaster.ModifiedDate;
            return _result;
        }
        #endregion

        #region BudgetDetail
        public static BudgetDetail ToBudgetDetail(this BaseBudgetDetailModel budgetDetail)
        {
            BudgetDetail _result = new BudgetDetail();
            if (budgetDetail.Id.HasValue) { _result.Id = budgetDetail.Id.GetValueOrDefault(); }
            _result.BudgetMasterId = budgetDetail.BudgetMasterId;
            _result.Particular = budgetDetail.Particular;
            _result.ExtraDate = budgetDetail.ExtraDate;
            _result.Credit = budgetDetail.Credit;
            _result.Debit = budgetDetail.Debit;
            _result.CreatedDate = budgetDetail.CreatedDate;
            _result.ModifiedDate = budgetDetail.ModifiedDate;
            return _result;
        }
        #endregion

    }
}
