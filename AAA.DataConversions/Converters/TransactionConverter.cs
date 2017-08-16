using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AAA.DataModels;
using AAA.Entities;

namespace AAA.DataConversions
{
    public static class TransactionConverter
    {
        
        #region BankReconciliation
        public static BankReconciliation ToBankReconciliation(this BaseBankReconciliationModel bankReconciliation)
        {
            BankReconciliation _result = new BankReconciliation();
            if (user.Id.HasValue) { _result.Id = user.Id.GetValueOrDefault(); }
            _result.LedgerPostingId = bankReconciliation.LedgerPostingId;
            _result.StatementDate = bankReconciliation.StatementDate;
            
            return _result;
        }
        #endregion

        #region Detail
        public static Detail ToDetail(this BaseDetailModel detail)
        {
            Detail _result = new Detail();
            if (detail.Id.HasValue) { _result.Id = detail.Id.GetValueOrDefault(); }
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
            
            
            
            return _result;
        }
        #endregion

        #region LedgerPosting
        public static LedgerPosting ToLedgerPosting(this BaseLedgerPostingModel ledgerPosting)
        {
            LedgerPosting _result = new LedgerPosting();
            if (ledgerPosting.Id.HasValue) { _result.Id = ledgerPosting.Id.GetValueOrDefault(); }
            _result.Date = ledgerPosting.Date;
            _result.VoucherTypeId = ledgerPosting.VoucherTypeId;
            _result.LedgerId = ledgerPosting.LedgerId;
            _result.Debit = ledgerPosting.Debit;
            _result.Credit = ledgerPosting.Credit;
            _result.DetailsId = ledgerPosting.DetailsId;
            _result.FinancialYearId = ledgerPosting.FinancialYearId;
            _result.InvoiceNumber = ledgerPosting.InvoiceNumber;
            _result.Text = ledgerPosting.Text;
            _result.ChequeNumber = ledgerPosting.ChequeNumber;
            _result.ChequeDate = ledgerPosting.ChequeDate;
                     
            return _result;
        }
        #endregion
    }
}
