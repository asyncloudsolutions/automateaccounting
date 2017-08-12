using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AAA.Entities;
using AAA.DataModels;

namespace AAA.DataConversions
{
    public static class MasterConverter
    {
        #region Master
         public static Master ToUser(this BaseMasterModel master)
        {
            Master _result = new Master();
            if (master.Id.HasValue) { _result.Id = master.Id.GetValueOrDefault(); }
                 
          _result.FormName = master.FormName;
            _result.IsTwoLineForHedder = master.IsTwoLineForHedder;
            _result.IsTwoLineForDetails = master.IsTwoLineForDetails;
            _result.PageSize= master.PageSize;
            _result.PageSizeOther = master.PageSizeOther;
            _result.BlankLineForFooter = master.BlankLineForFooter;
            _result.FooterLocation = master.FooterLocation;
            _result.LineCountBetweenTwo = master.LineCountBetweenTwo;
            _result.Pitch = master.Pitch;
            _result.Condensed = master.Condensed;
            _result.LineCountAfterPrint = master.LineCountAfterPrint;

             return _result;
        }
        #endregion
       
         
        #region Currency
         public static Currency ToUser(this BaseCurrencyModel currency)
        {
            Currency _result = new Currency();
            if (currency.Id.HasValue) { _result.Id = currency.Id.GetValueOrDefault(); }
            
      
             _result.CurrencySymbol = currency.CurrencySymbol;
             _result.CurrencyName = currency.CurrencyName;
             _result.SubUnitName = currency.SubUnitName;
             _result.NoOfDecimalPlaces = currency.NoOfDecimalPlaces;
             _result.Narration = currency.Narration;
             _result.IsDefault = currency.IsDefault;
             
            
            return _result;
        }
        #endregion

        

        #region Tax
         public static Tax ToUser(this BaseTaxModel tax)
        {
            Tax _result = new Tax();
            if (tax.Id.HasValue) { _result.Id = tax.Id.GetValueOrDefault(); }
           
           
            _result.TaxName = tax.TaxName;
            _result.ApplicableOn = tax.ApplicableOn;
            _result.Rate = tax.Rate;
            _result.CalculatingMode = tax.CalculatingMode;
            _result.Narration = tax.Narration;
            _result.IsActive = tax.IsActive;
           
            
            return _result;
        }

        #endregion

        #region VoucherType
         public static VoucherType ToUser(this BaseVoucherTypeModel vouchertype)
        {
            VoucherType _result = new VoucherType();
            if (vouchertype.Id.HasValue) { _result.Id = vouchertype.Id.GetValueOrDefault(); }
            
        
           _result.VoucherTypeName = vouchertype.VoucherTypeName;
            _result.TypeOfVoucher = vouchertype.TypeOfVoucher;
            _result.MethodOfVoucherNumbering = vouchertype.MethodOfVoucherNumbering;
            _result.IsTaxApplicable = vouchertype.IsTaxApplicable;
            _result.Narration = vouchertype.Narration;
            _result.IsActive = vouchertype.IsActive;
            _result.IsDefault = vouchertype.IsDefault;
            _result.Declaration = vouchertype.IdDeclaration;
            _result.HeadingOne = vouchertype.HeadingOne;
            _result.HeadingTwo = vouchertype.HeadingTwo;
            _result.HeadingThree = vouchertype.HeadingThree;
            _result.HeadingFour = vouchertype.HeadingFour;
             _result.MasterId = vouchertype.MasterId;
            return _result;
        }

        #endregion
        #region AccountGroup
        public static AccountGroup ToAccountGroup(this BaseAccountGroupModel accountgroup)
        {
            AccountGroup _result = new AccountGroup();
            if (accountgroup.Id.HasValue) { _result.Id = accountgroup.Id.GetValueOrDefault(); }
            
            
             _result.AccountGroupName = accountgroup.AccountGroupName;
             _result.GroupUnder = accountgroup.GroupUnder;
             _result.Narration = accountgroup.Narration;
             _result.IsDefault = accountgroup.IsDefault;
             _result.Nature = accountgroup.Nature;
            _result.AffectGrossProfit = accountgroup.AffectGrossProfit;
            
            return _result;
        }
        #endregion
        #region AccountLedger
        public static AccountLedger ToAccountLedger(this BaseAccountLedgerModel accountledger)
        {
            AccountLedger _result = new AccountLedger();
            if (accountledger.Id.HasValue) { _result.Id = accountledger.Id.GetValueOrDefault(); }
       
       
           _result.AccountGroupId = accountledger.AccountGroupId;
            _result.PricingLevelId = accountledger.PricingLevelId;
            _result.AreaId = accountledger.AreaId;
            _result.RouteId = accountledger.RouteId;
            _result.LedgerName = accountledger.LedgerName;
            _result.OpeningBalance = accountledger.OpeningBalance;
            _result.IsDefault = accountledger.IsDefault;
            _result.CrOrDr = accountledger.CrOrDr;
            _result.AffectGrossProfit = accountledger.AffectGrossProfit;
            _result.MailingName = accountledger.MailingName;
            _result.Narration = accountledger.Narration;
            _result.Address = accountledger.Address;
            _result.Phone = accountledger.Phone;
            _result.Mobile = accountledger.Mobile;
            _result.Email = accountledger.Email;
            _result.CreditPeriod = accountledger.CreditPeriod;
            _result.CreditLimit = accountledger.CreditLimit;
            _result.BillByBill = accountledger.BillByBill;
            _result.TIN = accountledger.TIN;
            _result.CST = accountledger.CST;
            _result.PAN = accountledger.PAN;
            _result.BankAccountNumber = accountledger.BankAccountNumber;
            _result.BranchName = accountledger.BranchName;
            _result.BranchCode = accountledger.BranchCode;
            
             
            
            return _result;
        }
        #endregion
        #region AdditionalCost
        public static AdditionalCost ToAdditionalCost(this BaseAdditionalCostModel additionalcost)
        {
            AdditionalCost _result = new AdditionalCost();
            if (additionalcost.Id.HasValue) { _result.Id = additionalcost.Id.GetValueOrDefault(); }
    
 
              _result.VoucherTypeId = additionalmodel.VoucherTypeId;
            _result.LedgerId = additionalmodel.LedgerId;
            _result.VoucherNumber = additionalmodel.VoucherNumber;
            _result.Debit = additionalmodel.Debit;
            _result.Credit = additionalmodel.Credit;
           
            return _result;
        }
        #endregion
        #region AdvancePayment
        public static AdvancePayment ToAdvancePayment(this BaseAdvancePaymentModel advancepayment)
        {
            AdvancePayment _result = new AdvancePayment();
            if (advancepayment.Id.HasValue) { _result.Id = advancepayment.Id.GetValueOrDefault(); }

      
               _result.EmployeeId = advancepayment.EmployeeId;
               _result.LedgerId = advancepayment.ILedgerIdd;
               _result.SuffixPrefixId = advancepayment.SuffixPrefixId;
               _result.VoucherTypeId = advancepayment.VoucherTypeId;
               _result.FinancialYearId = advancepayment.FinancialYearId;
               _result.VoucherNumber = advancepayment.VoucherNumber;
               _result.InvoiceNumber = advancepayment.InvoiceNumber;
               _result.Date = advancepayment.Date;
               _result.Amount = advancepayment.Amount;
               _result.SalaryMonth = advancepayment.SalaryMonth;
               _result.ChequeNumber = advancepayment.ChequeNumber;
               _result.ChequeDate = advancepayment.ChequeDate;
               _result.Narration = advancepayment.Narration;
              
            return _result;
        }
        #endregion
        #region Area
        public static Area ToArea(this BaseAreaModel area)
        {
            Area _result = new Area();
            if (area.Id.HasValue) { _result.Id = area.Id.GetValueOrDefault(); }
            
                      _result.AreaName = area.AreaName;
                    _result.Narration = area.Narration;
                    
            return _result;
        }
        #endregion
        #region Batch
        public static Batch ToBatch(this BaseBatchModel batch)
        {
            Batch _result = new Batch();
            if (batch.Id.HasValue) { _result.Id = batch.Id.GetValueOrDefault(); }
     
        _result.ProductId = batch.ProductId;
        _result.BatchNumber = batch.BatchNumber;
        _result.Barcode = batch.Barcode;
        _result.PartNumber = batch.PartNumber;
        _result.ManufacturingDate = batch.ManufacturingDate;
        _result.ExpiryDate = batch.ExpiryDate;
        _result.Narration = batch.Narration;
       
        return _result;
        }
        #endregion

        #region Brand
        public static Brand ToBrand(this BaseBrandModel brand)
        {
            Brand _result = new Brand();
            if (brand.Id.HasValue) { _result.Id = brand.Id.GetValueOrDefault(); }
            
             _result.BrandName = brand.BrandName;
             _result.Manufacturer = brand.Manufacturer;
             _result.Narration = brand.Narration;
             
                     
            return _result;
        }
        #endregion
        #region ExchangeRate
        public static ExchangeRate ToExchangeRate(this BaseExchangeRateModel exchangerate)
        {
            ExchangeRate _result = new ExchangeRate();
            if (exchangerate.Id.HasValue) { _result.Id = exchangerate.Id.GetValueOrDefault(); }
    
             _result.CurrencyId = exchangerate.CurrencyId;
             _result.Date = exchangerate.Date;
             _result.Rate = exchangerate.Rate;
             _result.Narration = exchangerate.Narration;
             
            
            return _result;
        }
        #endregion

       #region Godown
        public static Godown ToGodown(this BaseGodownModel godown)
        {
            Godown _result = new Godown();
            if (godown.Id.HasValue) { _result.Id = godown.Id.GetValueOrDefault(); }
           
         
              _result.GodownName = godown.GodownName;
              _result.Narration = godown.Narration;
             
              
            return _result;
        }
        #endregion
        #region ModelNumber
        public static ModelNumber ToModelNumber(this BaseModelNumberModel modelnumber)
        {
            ModelNumber _result = new ModelNumber();
            if (modelnumber.Id.HasValue) { _result.Id = modelnumber.Id.GetValueOrDefault(); }
            
            _result.ModelNo = modelnumber.ModelNo;
            _result.Narration = modelnumber.Narration;
   
            return _result;
        }
        #endregion
        #region PricingLevel
        public static PricingLevel ToPricingLevel(this BasePricingLevelModel pricinglevel)
        {
            PricingLevel _result = new PricingLevel();
            if (pricinglevel.Id.HasValue) { _result.Id = pricinglevel.Id.GetValueOrDefault(); }
            _result.PricingLevelName = pricinglevel.PricingLevelName;
            _result.Narration = pricinglevel.Narration;
           
            return _result;
        }
        #endregion
        #region ProductGroup
        public static ProductGroup ToProductGroup(this BaseProductGroupModel productgroup)
        {
            ProductGroup _result = new ProductGroup();
            if (productgroup.Id.HasValue) { _result.Id = productgroup.Id.GetValueOrDefault(); }
            
                
             _result.GroupName = productgroup.GroupName;
             _result.GroupUnder = productgroup.GroupUnder;
             _result.Narration = productgroup.Narration;
             
            return _result;
        }
        #endregion
        #region Product
        public static Product ToProduct(this BaseProductModel product)
        {
            Product _result = new Product();
            if (product.Id.HasValue) { _result.Id = product.Id.GetValueOrDefault(); }
            
         
            _result.ProductCode = product.ProductCode;
            _result.ProductName = product.ProductName;
            _result.ProductGroupId = product.ProductGroupId;
            _result.BrandId = product.BrandId;
            _result.UnitId = product.UnitId;
           _result.SizeId = product.SizeId;
            _result.ModelNumberId = product.ModelNumberId;
            _result.TaxId = product.TaxId;
            _result.TaxApplicableOn = product.TaxApplicableOn;
            _result.PurchaseRate = product.PurchaseRate;
            _result.SalesRate = product.SalesRate;
            _result.MRP = product.MRP;
            _result.MinimumStock = product.MinimumStock;
            _result.MaximumStock = product.MaximumStock;
            _result.ReOrderLevel = product.ReOrderLevel;
           _result.GodownId = product.GodownId;
            _result.RackId = product.RackId;
            _result.IsAllowBatch = product.IsAllowBatch;
            _result.IsMultipleUnit = product.IsMultipleUnit;
            _result.IsBOM = product.IsBOM;
            _result.IsOpeningStock = product.IsOpeningStock;
         _result.Narration = product.Narration;
         _result.IsActive = product.IsActive;
         _result.IsShowRemember = product.IsShowRemember;
            _result.PartNumber = product.PartNumber;
            
         
            return _result;
        }
        #endregion
        #region Rack
        public static Rack ToRack(this BaseRackModel rack)
        {
            Rack _result = new Rack();
            if (rack.Id.HasValue) { _result.Id = rack.Id.GetValueOrDefault(); }
                 
            _result.RackName = rack.RackName;
            _result.GodownId = rack.GodownId;
            _result.Narration = rack.Narration;
            
            
            return _result;
        }
        #endregion

        #region Route
        public static Route ToRoute(this BaseRouteModel route)
        {
            Route _result = new Route();
            if (route.Id.HasValue) { _result.Id = route.Id.GetValueOrDefault(); }
          
         
            _result.RouteName = route.RouteName;
            _result.AreaId = route.AreaId;
            _result.Narration = route.Narration;
            
            return _result;
        }
        #endregion

        #region Size
        public static Size ToSize(this BaseSizeModel size)
        {
            Size _result = new Size();
            if (size.Id.HasValue) { _result.Id = size.Id.GetValueOrDefault(); }
              _result.Size1 = size.Size1;
            _result.Narration = size.Narration;
           
            return _result;
        }
        #endregion
        #region Unit
        public static Unit ToUnit(this BaseUnitModel unit)
        {
            Unit _result = new Unit();
            if (unit.Id.HasValue) { _result.Id = unit.Id.GetValueOrDefault(); }
       
        
              _result.UnitName = unit.UnitName;
          _result.Narration = unit.Narration;
          _result.NumberOfDecimalPlaces = unit.NumberOfDecimalPlaces;
          _result.FormalName = unit.FormalName;
                      
            return _result;
        }
        #endregion
        
    }
}
