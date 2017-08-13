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
            budgetMasters.ForEach(BudgetMaster => _result.Add(BudgetMaster.ToBaseBudgetMaster()));
            return _result;
        }

        public static BaseBudgetMasterModel ToBaseBudgetMaster(this BudgetMaster BudgetMaster)
        {
            BaseBudgetMasterModel _result = new BaseBudgetMasterModel();
            _result.BudgetName = BudgetMaster.BudgetName;
            _result.Type = BudgetMaster.Type;
            _result.FromDate = BudgetMaster.FromDate;
            _result.ToDate = BudgetMaster.ToDate;
            _result.TotalDr = BudgetMaster.TotalDr;
            _result.TotalCr = BudgetMaster.TotalCr;
            _result.Narration = BudgetMaster.Narration;
            return _result;
        }
        #endregion

        #region BudgetDetail
        public static IList<BaseBudgetDetailModel> ToBaseBudgetDetail(this List<BudgetDetail> budgetDetails)
        {
            IList<BaseBudgetDetailModel> _result = new List<BaseBudgetDetailModel>();
            budgetDetails.ForEach(BudgetDetail => _result.Add(BudgetDetail.ToBaseBudgetDetail()));
            return _result;
        }

        public static BaseBudgetDetailModel ToBaseBudgetDetail(this BudgetDetail BudgetDetail)
        {
            BaseBudgetDetailModel _result = new BaseBudgetDetailModel();
            _result.BudgetMasterId = BudgetDetail.BudgetMasterId;
            _result.Particular = BudgetDetail.Particular;
            _result.ExtraDate = BudgetDetail.ExtraDate;
            _result.Credit = BudgetDetail.Credit;
            _result.Debit = BudgetDetail.Debit;
            return _result;
        }
        #endregion
    }
}
