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
        public static IList<BaseBankReconciliationModel> ToBaseBankReconciliations(this List<BankReconciliation> bankreconciliations)
        {
            IList<BaseBankReconciliationModel> _result = new List<BaseBankReconciliationModel>();
            bankreconciliations.ForEach(bankreconciliation => _result.Add(bankreconciliation.ToBaseBankReconciliation()));
            return _result;
        }

        public static BaseBankReconciliationModel ToBaseBankReconciliation(this BankReconciliation bankreconciliation)
        {
            BaseBankReconciliationModel _result = new BaseBankReconciliationModel();
           

        _result.Id = bankreconciliation.Id;
            _result.LedgerPostingId = bankreconciliation.LedgerPostingId;
            _result.StatementDate = bankreconciliation.StatementDate;
            _result.CreatedDate = bankreconciliation.CreatedDate;
            _result.ModifiedDate = bankreconciliation.ModifiedDate;
            
            
            return _result;
        }
        #endregion

        #region Detail
        public static IList<BaseDetailModel> ToBaseBaseDetails(this List<Detail> details)
        {
            IList<BaseDetailModel> _result = new List<BaseDetailModel>();
            details.ForEach(detail => _result.Add(detail.ToBaseBaseDetail()));
            return _result;
        }

        public static BaseDetailModel ToBaseBaseDetail(this Detail detail)
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
            _result.Master = detail.Master;
            _result.LedgerPostings = detail.LedgerPostings;



            return _result;
        }
        #endregion
        #region LedgerPosting
        public static IList<BaseLedgerPostingModel> ToBaseLedgerPostings(this List<LedgerPosting> ledgerpostings)
        {
            IList<BaseLedgerPostingModel> _result = new List<BaseLedgerPostingModel>();
            ledgerpostings.ForEach(ledgerposting => _result.Add(ledgerposting.ToBaseLedgerPosting()));
            return _result;
        }

        public static BaseLedgerPostingModel ToBaseLedgerPosting(this LedgerPosting ledgerposting)
        {
            BaseLedgerPostingModel _result = new BaseLedgerPostingModel();
           

        _result.Id = ledgerposting.Id;
            _result.Date = ledgerposting.Date;
            _result.VoucherTypeId = ledgerposting.VoucherTypeId;
            _result.VoucherNumber = ledgerposting.VoucherNumber;
            _result.LedgerId = ledgerposting.LedgerId;
            _result.Debit = ledgerposting.Debit;
            _result.Credit = ledgerposting.Credit;
            _result.DetailsId = ledgerposting.DetailsId;
            _result.FinancialYearId = ledgerposting.FinancialYearId;
            _result.InvoiceNumber = ledgerposting.InvoiceNumber;
            _result.Text = ledgerposting.Text;
            _result.ChequeNumber = ledgerposting.ChequeNumber;
            _result.ChequeDate = ledgerposting.ChequeDate;
            _result.CreatedDate = ledgerposting.CreatedDate;
            _result.ModifiedDate = ledgerposting.ModifiedDate;
           
            





            return _result;
        }
        #endregion

    }
}
