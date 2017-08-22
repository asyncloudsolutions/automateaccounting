using AAA.DataModels;
using AAA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.DataConversions
{
    public static class TransactionAssembler
    {
        #region BankReconciliation
        public static IList<BaseBankReconciliationModel> ToBaseBankReconciliations(this List<BankReconciliation> bankReconciliations)
        {
            IList<BaseBankReconciliationModel> _result = new List<BaseBankReconciliationModel>();
            bankReconciliations.ForEach(bankReconciliation => _result.Add(bankReconciliation.ToBaseBankReconciliation()));
            return _result;
        }

        public static BaseBankReconciliationModel ToBaseBankReconciliation(this BankReconciliation bankReconciliation)
        {
            BaseBankReconciliationModel _result = new BaseBankReconciliationModel();
            _result.Id = bankReconciliation.Id;
            _result.LedgerPostingId = bankReconciliation.LedgerPostingId;
            _result.StatementDate = bankReconciliation.StatementDate;
            _result.CreatedDate = bankReconciliation.CreatedDate;
            _result.ModifiedDate = bankReconciliation.ModifiedDate;
            return _result;
        }
        #endregion

        #region Detail
        public static IList<BaseDetailModel> ToBaseDetails(this List<Detail> details)
        {
            IList<BaseDetailModel> _result = new List<BaseDetailModel>();
            details.ForEach(detail => _result.Add(detail.ToBaseDetail()));
            return _result;
        }

        public static BaseDetailModel ToBaseDetail(this Detail detail)
        {
            BaseDetailModel _result = new BaseDetailModel();
            _result.Id = detail.Id;
            _result.MasterId = detail.MasterId;
            _result.Name = detail.Name;
            _result.Text = detail.Text;
            _result.Row = detail.Row;
            _result.Columns = detail.Columns;
            _result.Width = detail.Width;
            _result.DBF = detail.DBF;
            _result.DorH = detail.DorH;
            _result.Repeat = detail.Repeat;
            _result.Align = detail.Align;
            _result.RepeatAll = detail.RepeatAll;
            _result.FooterRepeatAll = detail.FooterRepeatAll;
            _result.TextWrap = detail.TextWrap;
            _result.WrapLineCount = detail.WrapLineCount;
            _result.ExtraFieldName = detail.ExtraFieldName;
            _result.FieldsForExtra = detail.FieldsForExtra;
            _result.CreatedDate = detail.CreatedDate;
            _result.ModifiedDate = detail.ModifiedDate;
            return _result;
        }
        #endregion

        #region LedgerPosting
        public static IList<BaseLedgerPostingModel> ToBaseLedgerPostings(this List<LedgerPosting> ledgerPostings)
        {
            IList<BaseLedgerPostingModel> _result = new List<BaseLedgerPostingModel>();
            ledgerPostings.ForEach(ledgerPosting => _result.Add(ledgerPosting.ToBaseLedgerPosting()));
            return _result;
        }

        public static BaseLedgerPostingModel ToBaseLedgerPosting(this LedgerPosting ledgerPosting)
        {
            BaseLedgerPostingModel _result = new BaseLedgerPostingModel();
            _result.Id = ledgerPosting.Id;
            _result.Date = ledgerPosting.Date;
            _result.VoucherTypeId = ledgerPosting.VoucherTypeId;
            _result.VoucherNumber = ledgerPosting.VoucherNumber;
            _result.LedgerId = ledgerPosting.LedgerId;
            _result.Debit = ledgerPosting.Debit;
            _result.Credit = ledgerPosting.Credit;
            _result.DetailsId = ledgerPosting.DetailsId;
            _result.FinancialYearId = ledgerPosting.FinancialYearId;
            _result.InvoiceNumber = ledgerPosting.InvoiceNumber;
            _result.Text = ledgerPosting.Text;
            _result.ChequeNumber = ledgerPosting.ChequeNumber;
            _result.ChequeDate = ledgerPosting.ChequeDate;
            _result.CreatedDate = ledgerPosting.CreatedDate;
            _result.ModifiedDate = ledgerPosting.ModifiedDate;
            return _result;
        }
        #endregion
    }
}
