using AAA.DataModels;
using AAA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.DataConversions
{
    public static class BudgetAssembler
    {
        #region BudgetMaster
        public static IList<BaseBudgetMasterModel> ToBaseBudgetMasters(this List<BudgetMaster> budgetMasters)
        {
            IList<BaseBudgetMasterModel> _result = new List<BaseBudgetMasterModel>();
            budgetMasters.ForEach(budgetMaster => _result.Add(budgetMaster.ToBaseBudgetMaster()));
            return _result;
        }

        public static BaseBudgetMasterModel ToBaseBudgetMaster(this BudgetMaster budgetMaster)
        {
            BaseBudgetMasterModel _result = new BaseBudgetMasterModel();
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
        public static IList<BaseBudgetDetailModel> ToBaseBudgetDetail(this List<BudgetDetail> budgetDetails)
        {
            IList<BaseBudgetDetailModel> _result = new List<BaseBudgetDetailModel>();
            budgetDetails.ForEach(budgetDetail => _result.Add(budgetDetail.ToBaseBudgetDetail()));
            return _result;
        }

        public static BaseBudgetDetailModel ToBaseBudgetDetail(this BudgetDetail budgetDetail)
        {
            BaseBudgetDetailModel _result = new BaseBudgetDetailModel();
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
