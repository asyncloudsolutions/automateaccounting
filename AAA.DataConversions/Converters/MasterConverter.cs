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
        public static Master ToMaster(this BaseMasterModel master)
        {
            Master _result = new Master();
            if (master.Id.HasValue) { _result.Id = master.Id.GetValueOrDefault(); }
            _result.FormName = master.FormName;
            _result.IsTwoLineForHedder = master.IsTwoLineForHedder;
            _result.IsTwoLineForDetails = master.IsTwoLineForDetails;
            _result.PageSize = master.PageSize;
            _result.PageSizeOther = master.PageSizeOther;
            _result.BlankLineForFooter = master.BlankLineForFooter;
            _result.FooterLocation = master.FooterLocation;
            _result.LineCountBetweenTwo = master.LineCountBetweenTwo;
            _result.Pitch = master.Pitch;
            _result.Condensed = master.Condensed;
            _result.LineCountAfterPrint = master.LineCountAfterPrint;
            _result.CreatedDate = master.CreatedDate;
            _result.ModifiedDate = master.ModifiedDate;
            return _result;
        }
        #endregion

        #region Currency
        public static Currency ToCurrency(this BaseCurrencyModel currency)
        {
            Currency _result = new Currency();
            if (currency.Id.HasValue) { _result.Id = currency.Id.GetValueOrDefault(); }
            _result.CurrencySymbol = currency.CurrencySymbol;
            _result.CurrencyName = currency.CurrencyName;
            _result.SubUnitName = currency.SubUnitName;
            _result.NoOfDecimalPlaces = currency.NoOfDecimalPlaces;
            _result.Narration = currency.Narration;
            _result.IsDefault = currency.IsDefault;
            _result.CreatedDate = currency.CreatedDate;
            _result.ModifiedDate = currency.ModifiedDate;
            return _result;
        }
        #endregion

        #region Tax
        public static Tax ToTax(this BaseTaxModel tax)
        {
            Tax _result = new Tax();
            if (tax.Id.HasValue) { _result.Id = tax.Id.GetValueOrDefault(); }
            _result.TaxName = tax.TaxName;
            _result.ApplicableOn = tax.ApplicableOn;
            _result.Rate = tax.Rate;
            _result.CalculatingMode = tax.CalculatingMode;
            _result.Narration = tax.Narration;
            _result.IsActive = tax.IsActive;
            _result.CreatedDate = tax.CreatedDate;
            _result.ModifiedDate = tax.ModifiedDate;
            return _result;
        }
        #endregion

        #region VoucherType
        public static VoucherType ToVoucherType(this BaseVoucherTypeModel voucherType)
        {
            VoucherType _result = new VoucherType();
            if (voucherType.Id.HasValue) { _result.Id = voucherType.Id.GetValueOrDefault(); }
            _result.VoucherTypeName = voucherType.VoucherTypeName;
            _result.TypeOfVoucher = voucherType.TypeOfVoucher;
            _result.MethodOfVoucherNumbering = voucherType.MethodOfVoucherNumbering;
            _result.IsTaxApplicable = voucherType.IsTaxApplicable;
            _result.Narration = voucherType.Narration;
            _result.IsActive = voucherType.IsActive;
            _result.IsDefault = voucherType.IsDefault;
            _result.Declaration = voucherType.Declaration;
            _result.HeadingOne = voucherType.HeadingOne;
            _result.HeadingTwo = voucherType.HeadingTwo;
            _result.HeadingThree = voucherType.HeadingThree;
            _result.HeadingFour = voucherType.HeadingFour;
            _result.CreatedDate = voucherType.CreatedDate;
            _result.ModifiedDate = voucherType.ModifiedDate;
            _result.MasterId = voucherType.MasterId;
            return _result;
        }
        #endregion

        #region AccountGroup
        public static AccountGroup ToAccountGroup(this BaseAccountGroupModel accountGroup)
        {
            AccountGroup _result = new AccountGroup();
            if (accountGroup.Id.HasValue) { _result.Id = accountGroup.Id.GetValueOrDefault(); }
            _result.AccountGroupName = accountGroup.AccountGroupName;
            _result.GroupUnder = accountGroup.GroupUnder;
            _result.Narration = accountGroup.Narration;
            _result.IsDefault = accountGroup.IsDefault;
            _result.Nature = accountGroup.Nature;
            _result.AffectGrossProfit = accountGroup.AffectGrossProfit;
            _result.CreatedDate = accountGroup.CreatedDate;
            _result.ModifiedDate = accountGroup.ModifiedDate;
            return _result;
        }
        #endregion

        #region AccountLedger
        public static AccountLedger ToAccountLedger(this BaseAccountLedgerModel accountLedger)
        {
            AccountLedger _result = new AccountLedger();
            if (accountLedger.Id.HasValue) { _result.Id = accountLedger.Id.GetValueOrDefault(); }
            _result.AccountGroupId = accountLedger.AccountGroupId;
            _result.PricingLevelId = accountLedger.PricingLevelId;
            _result.AreaId = accountLedger.AreaId;
            _result.RouteId = accountLedger.RouteId;
            _result.LedgerName = accountLedger.LedgerName;
            _result.OpeningBalance = accountLedger.OpeningBalance;
            _result.IsDefault = accountLedger.IsDefault;
            _result.CrOrDr = accountLedger.CrOrDr;
            _result.AffectGrossProfit = accountLedger.AffectGrossProfit;
            _result.MailingName = accountLedger.MailingName;
            _result.Narration = accountLedger.Narration;
            _result.Address = accountLedger.Address;
            _result.Phone = accountLedger.Phone;
            _result.Mobile = accountLedger.Mobile;
            _result.Email = accountLedger.Email;
            _result.CreditPeriod = accountLedger.CreditPeriod;
            _result.CreditLimit = accountLedger.CreditLimit;
            _result.BillByBill = accountLedger.BillByBill;
            _result.TIN = accountLedger.TIN;
            _result.CST = accountLedger.CST;
            _result.PAN = accountLedger.PAN;
            _result.BankAccountNumber = accountLedger.BankAccountNumber;
            _result.BranchName = accountLedger.BranchName;
            _result.BranchCode = accountLedger.BranchCode;
            _result.CreatedDate = accountLedger.CreatedDate;
            _result.ModifiedDate = accountLedger.ModifiedDate;
            return _result;
        }
        #endregion

        #region AdditionalCost
        public static AdditionalCost ToAdditionalCost(this BaseAdditionalCostModel additionalCost)
        {
            AdditionalCost _result = new AdditionalCost();
            if (additionalCost.Id.HasValue) { _result.Id = additionalCost.Id.GetValueOrDefault(); }
            _result.VoucherTypeId = additionalCost.VoucherTypeId;
            _result.LedgerId = additionalCost.LedgerId;
            _result.VoucherNumber = additionalCost.VoucherNumber;
            _result.Debit = additionalCost.Debit;
            _result.Credit = additionalCost.Credit;
            _result.CreatedDate = additionalCost.CreatedDate;
            _result.ModifiedDate = additionalCost.ModifiedDate;
            return _result;
        }
        #endregion

        #region AdvancePayment
        public static AdvancePayment ToAdvancePayment(this BaseAdvancePaymentModel advancePayment)
        {
            AdvancePayment _result = new AdvancePayment();
            if (advancePayment.Id.HasValue) { _result.Id = advancePayment.Id.GetValueOrDefault(); }
            _result.EmployeeId = advancePayment.EmployeeId;
            _result.LedgerId = advancePayment.LedgerId;
            _result.SuffixPrefixId = advancePayment.SuffixPrefixId;
            _result.VoucherTypeId = advancePayment.VoucherTypeId;
            _result.FinancialYearId = advancePayment.FinancialYearId;
            _result.VoucherNumber = advancePayment.VoucherNumber;
            _result.InvoiceNumber = advancePayment.InvoiceNumber;
            _result.Date = advancePayment.Date;
            _result.Amount = advancePayment.Amount;
            _result.SalaryMonth = advancePayment.SalaryMonth;
            _result.ChequeNumber = advancePayment.ChequeNumber;
            _result.ChequeDate = advancePayment.ChequeDate;
            _result.Narration = advancePayment.Narration;
            _result.CreatedDate = advancePayment.CreatedDate;
            _result.ModifiedDate = advancePayment.ModifiedDate;
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
            _result.CreatedDate = area.CreatedDate;
            _result.ModifiedDate = area.ModifiedDate;
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
            _result.CreatedDate = batch.CreatedDate;
            _result.ModifiedDate = batch.ModifiedDate;
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
            _result.CreatedDate = brand.CreatedDate;
            _result.ModifiedDate = brand.ModifiedDate;
            return _result;
        }
        #endregion

        #region ExchangeRate
        public static ExchangeRate ToExchangeRate(this BaseExchangeRateModel exchangeRate)
        {
            ExchangeRate _result = new ExchangeRate();
            if (exchangeRate.Id.HasValue) { _result.Id = exchangeRate.Id.GetValueOrDefault(); }
            _result.CurrencyId = exchangeRate.CurrencyId;
            _result.Date = exchangeRate.Date;
            _result.Rate = exchangeRate.Rate;
            _result.Narration = exchangeRate.Narration;
            _result.CreatedDate = exchangeRate.CreatedDate;
            _result.ModifiedDate = exchangeRate.ModifiedDate;
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
            _result.CreatedDate = godown.CreatedDate;
            _result.ModifiedDate = godown.ModifiedDate;
            return _result;
        }
        #endregion

        #region ModelNumber
        public static ModelNumber ToModelNumber(this BaseModelNumberModel modelNumber)
        {
            ModelNumber _result = new ModelNumber();
            if (modelNumber.Id.HasValue) { _result.Id = modelNumber.Id.GetValueOrDefault(); }
            _result.ModelNo = modelNumber.ModelNo;
            _result.Narration = modelNumber.Narration;
            _result.CreatedDate = modelNumber.CreatedDate;
            _result.ModifiedDate = modelNumber.ModifiedDate;
            return _result;
        }
        #endregion

        #region PricingLevel
        public static PricingLevel ToPricingLevel(this BasePricingLevelModel pricingLevel)
        {
            PricingLevel _result = new PricingLevel();
            if (pricingLevel.Id.HasValue) { _result.Id = pricingLevel.Id.GetValueOrDefault(); }
            _result.PricingLevelName = pricingLevel.PricingLevelName;
            _result.Narration = pricingLevel.Narration;
            _result.CreatedDate = pricingLevel.CreatedDate;
            _result.ModifiedDate = pricingLevel.ModifiedDate;
            return _result;
        }
        #endregion

        #region ProductGroup
        public static ProductGroup ToProductGroup(this BaseProductGroupModel productGroup)
        {
            ProductGroup _result = new ProductGroup();
            if (productGroup.Id.HasValue) { _result.Id = productGroup.Id.GetValueOrDefault(); }
            _result.GroupName = productGroup.GroupName;
            _result.GroupUnder = productGroup.GroupUnder;
            _result.Narration = productGroup.Narration;
            _result.CreatedDate = productGroup.CreatedDate;
            _result.ModifiedDate = productGroup.ModifiedDate;
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
            _result.CreatedDate = product.CreatedDate;
            _result.ModifiedDate = product.ModifiedDate;
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
            _result.CreatedDate = rack.CreatedDate;
            _result.ModifiedDate = rack.ModifiedDate;
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
            _result.CreatedDate = route.CreatedDate;
            _result.ModifiedDate = route.ModifiedDate;
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
            _result.CreatedDate = size.CreatedDate;
            _result.ModifiedDate = size.ModifiedDate;
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
            _result.CreatedDate = unit.CreatedDate;
            _result.ModifiedDate = unit.ModifiedDate;
            return _result;
        }
        #endregion
    }
}
