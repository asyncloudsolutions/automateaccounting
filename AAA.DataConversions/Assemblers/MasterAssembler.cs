using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AAA.DataModels;
using AAA.Entities;

namespace AAA.DataConversions
{
    public static class MasterAssembler
    {
        #region Master
        public static IList<BaseMasterModel> ToBaseMasters(this List<Master> masters)
        {
            IList<BaseMasterModel> _result = new List<BaseMasterModel>();
            masters.ForEach(master => _result.Add(master.ToBaseMaster()));
            return _result;
        }

        public static BaseMasterModel ToBaseMaster(this Master master)
        {
            BaseMasterModel _result = new BaseMasterModel();
            _result.Id = master.Id;
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
        public static IList<BaseCurrencyModel> ToBaseCurrencies(this List<Currency> currencies)
        {
            IList<BaseCurrencyModel> _result = new List<BaseCurrencyModel>();
            currencies.ForEach(currency => _result.Add(currency.ToBaseCurrency()));
            return _result;
        }

        public static BaseCurrencyModel ToBaseCurrency(this Currency currency)
        {
            BaseCurrencyModel _result = new BaseCurrencyModel();
            _result.Id = currency.Id;
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
        public static IList<BaseTaxModel> ToBaseTaxes(this List<Tax> taxes)
        {
            IList<BaseTaxModel> _result = new List<BaseTaxModel>();
            taxes.ForEach(tax => _result.Add(tax.ToBaseTax()));
            return _result;
        }

        public static BaseTaxModel ToBaseTax(this Tax tax)
        {
            BaseTaxModel _result = new BaseTaxModel();
            _result.Id = tax.Id;
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
        public static IList<BaseVoucherTypeModel> ToBaseVoucherTypes(this List<VoucherType> vocherTypes)
        {
            IList<BaseVoucherTypeModel> _result = new List<BaseVoucherTypeModel>();
            vocherTypes.ForEach(voucherType => _result.Add(voucherType.ToBaseVoucherType()));
            return _result;
        }

        public static BaseVoucherTypeModel ToBaseVoucherType(this VoucherType voucherType)
        {
            BaseVoucherTypeModel _result = new BaseVoucherTypeModel();
            _result.Id = voucherType.Id;
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
        public static IList<BaseAccountGroupModel> ToBaseAccountGroups(this List<AccountGroup> accountGroups)
        {
            IList<BaseAccountGroupModel> _result = new List<BaseAccountGroupModel>();
            accountGroups.ForEach(accountGroup => _result.Add(accountGroup.ToBaseAccountGroup()));
            return _result;
        }

        public static BaseAccountGroupModel ToBaseAccountGroup(this AccountGroup accountGroup)
        {
            BaseAccountGroupModel _result = new BaseAccountGroupModel();
            _result.Id = accountGroup.Id;
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
        public static IList<BaseAccountLedgerModel> ToBaseAccountLedgers(this List<AccountLedger> accountLedgers)
        {
            IList<BaseAccountLedgerModel> _result = new List<BaseAccountLedgerModel>();
            accountLedgers.ForEach(accountLedger => _result.Add(accountLedger.ToBaseAccountLedger()));
            return _result;
        }

        public static BaseAccountLedgerModel ToBaseAccountLedger(this AccountLedger accountLedger)
        {
            BaseAccountLedgerModel _result = new BaseAccountLedgerModel();
            _result.Id = accountLedger.Id;
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
        public static IList<BaseAdditionalCostModel> ToBaseAdditionalCosts(this List<AdditionalCost> additionalCosts)
        {
            IList<BaseAdditionalCostModel> _result = new List<BaseAdditionalCostModel>();
            additionalCosts.ForEach(additionalCost => _result.Add(additionalCost.ToBaseAdditionalCost()));
            return _result;
        }

        public static BaseAdditionalCostModel ToBaseAdditionalCost(this AdditionalCost additionalCost)
        {
            BaseAdditionalCostModel _result = new BaseAdditionalCostModel();
            _result.Id = additionalCost.Id;
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
        public static IList<BaseAdvancePaymentModel> ToBaseAdvancePayments(this List<AdvancePayment> advancePayments)
        {
            IList<BaseAdvancePaymentModel> _result = new List<BaseAdvancePaymentModel>();
            advancePayments.ForEach(advancePayment => _result.Add(advancePayment.ToBaseAdvancePayment()));
            return _result;
        }

        public static BaseAdvancePaymentModel ToBaseAdvancePayment(this AdvancePayment advancePayment)
        {
            BaseAdvancePaymentModel _result = new BaseAdvancePaymentModel();
            _result.Id = advancePayment.Id;
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
        public static IList<BaseAreaModel> ToBaseAreas(this List<Area> areas)
        {
            IList<BaseAreaModel> _result = new List<BaseAreaModel>();
            areas.ForEach(area => _result.Add(area.ToBaseArea()));
            return _result;
        }

        public static BaseAreaModel ToBaseArea(this Area area)
        {
            BaseAreaModel _result = new BaseAreaModel();
            _result.Id = area.Id;
            _result.AreaName = area.AreaName;
            _result.Narration = area.Narration;
            _result.CreatedDate = area.CreatedDate;
            _result.ModifiedDate = area.ModifiedDate;
            return _result;
        }
        #endregion

        #region Batch
        public static IList<BaseBatchModel> ToBaseBatches(this List<Batch> batches)
        {
            IList<BaseBatchModel> _result = new List<BaseBatchModel>();
            batches.ForEach(batch => _result.Add(batch.ToBaseBatch()));
            return _result;
        }

        public static BaseBatchModel ToBaseBatch(this Batch batch)
        {
            BaseBatchModel _result = new BaseBatchModel();
            _result.Id = batch.Id;
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
        public static IList<BaseBrandModel> ToBaseBrands(this List<Brand> brands)
        {
            IList<BaseBrandModel> _result = new List<BaseBrandModel>();
            brands.ForEach(brand => _result.Add(brand.ToBaseBrand()));
            return _result;
        }

        public static BaseBrandModel ToBaseBrand(this Brand brand)
        {
            BaseBrandModel _result = new BaseBrandModel();
            _result.Id = brand.Id;
            _result.BrandName = brand.BrandName;
            _result.Manufacturer = brand.Manufacturer;
            _result.Narration = brand.Narration;
            _result.CreatedDate = brand.CreatedDate;
            _result.ModifiedDate = brand.ModifiedDate;
            return _result;
        }
        #endregion

        #region ExchangeRate
        public static IList<BaseExchangeRateModel> ToBaseExchangeRates(this List<ExchangeRate> exchangeRates)
        {
            IList<BaseExchangeRateModel> _result = new List<BaseExchangeRateModel>();
            exchangeRates.ForEach(exchangeRate => _result.Add(exchangeRate.ToBaseExchangeRate()));
            return _result;
        }

        public static BaseExchangeRateModel ToBaseExchangeRate(this ExchangeRate exchangeRate)
        {
            BaseExchangeRateModel _result = new BaseExchangeRateModel();
            _result.Id = exchangeRate.Id;
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
        public static IList<BaseGodownModel> ToBaseGodowns(this List<Godown> godowns)
        {
            IList<BaseGodownModel> _result = new List<BaseGodownModel>();
            godowns.ForEach(godown => _result.Add(godown.ToBaseGodown()));
            return _result;
        }

        public static BaseGodownModel ToBaseGodown(this Godown godown)
        {
            BaseGodownModel _result = new BaseGodownModel();
            _result.Id = godown.Id;
            _result.GodownName = godown.GodownName;
            _result.Narration = godown.Narration;
            _result.CreatedDate = godown.CreatedDate;
            _result.ModifiedDate = godown.ModifiedDate;
            return _result;
        }
        #endregion

        #region ModelNumber
        public static IList<BaseModelNumberModel> ToBaseModelNumbers(this List<ModelNumber> modelNumbers)
        {
            IList<BaseModelNumberModel> _result = new List<BaseModelNumberModel>();
            modelNumbers.ForEach(modelNumber => _result.Add(modelNumber.ToBaseModelNumber()));
            return _result;
        }

        public static BaseModelNumberModel ToBaseModelNumber(this ModelNumber modelNumber)
        {
            BaseModelNumberModel _result = new BaseModelNumberModel();
            _result.Id = modelNumber.Id;
            _result.ModelNo = modelNumber.ModelNo;
            _result.Narration = modelNumber.Narration;
            _result.CreatedDate = modelNumber.CreatedDate;
            _result.ModifiedDate = modelNumber.ModifiedDate;
            return _result;
        }
        #endregion

        #region PricingLevel
        public static IList<BasePricingLevelModel> ToBasePricingLevels(this List<PricingLevel> pricingLevels)
        {
            IList<BasePricingLevelModel> _result = new List<BasePricingLevelModel>();
            pricingLevels.ForEach(pricingLevel => _result.Add(pricingLevel.ToBasePricingLevel()));
            return _result;
        }

        public static BasePricingLevelModel ToBasePricingLevel(this PricingLevel pricingLevel)
        {
            BasePricingLevelModel _result = new BasePricingLevelModel();
            _result.Id = pricingLevel.Id;
            _result.PricingLevelName = pricingLevel.PricingLevelName;
            _result.Narration = pricingLevel.Narration;
            _result.CreatedDate = pricingLevel.CreatedDate;
            _result.ModifiedDate = pricingLevel.ModifiedDate;
            return _result;
        }
        #endregion

        #region ProductGroup
        public static IList<BaseProductGroupModel> ToBaseProductGroups(this List<ProductGroup> productGroups)
        {
            IList<BaseProductGroupModel> _result = new List<BaseProductGroupModel>();
            productGroups.ForEach(productGroup => _result.Add(productGroup.ToBaseProductGroup()));
            return _result;
        }

        public static BaseProductGroupModel ToBaseProductGroup(this ProductGroup productGroup)
        {
            BaseProductGroupModel _result = new BaseProductGroupModel();
            _result.Id = productGroup.Id;
            _result.GroupName = productGroup.GroupName;
            _result.GroupUnder = productGroup.GroupUnder;
            _result.Narration = productGroup.Narration;
            _result.CreatedDate = productGroup.CreatedDate;
            _result.ModifiedDate = productGroup.ModifiedDate;
            return _result;
        }
        #endregion

        #region Product
        public static IList<BaseProductModel> ToBaseProducts(this List<Product> products)
        {
            IList<BaseProductModel> _result = new List<BaseProductModel>();
            products.ForEach(product => _result.Add(product.ToBaseProduct()));
            return _result;
        }

        public static BaseProductModel ToBaseProduct(this Product product)
        {
            BaseProductModel _result = new BaseProductModel();
            _result.Id = product.Id;
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
        public static IList<BaseRackModel> ToBaseRacks(this List<Rack> racks)
        {
            IList<BaseRackModel> _result = new List<BaseRackModel>();
            racks.ForEach(rack => _result.Add(rack.ToBaseRack()));
            return _result;
        }

        public static BaseRackModel ToBaseRack(this Rack rack)
        {
            BaseRackModel _result = new BaseRackModel();
            _result.Id = rack.Id;
            _result.RackName = rack.RackName;
            _result.GodownId = rack.GodownId;
            _result.Narration = rack.Narration;
            _result.CreatedDate = rack.CreatedDate;
            _result.ModifiedDate = rack.ModifiedDate;
            return _result;
        }
        #endregion

        #region Route
        public static IList<BaseRouteModel> ToBaseRoutes(this List<Route> routes)
        {
            IList<BaseRouteModel> _result = new List<BaseRouteModel>();
            routes.ForEach(route => _result.Add(route.ToBaseRoute()));
            return _result;
        }

        public static BaseRouteModel ToBaseRoute(this Route route)
        {
            BaseRouteModel _result = new BaseRouteModel();
            _result.Id = route.Id;
            _result.RouteName = route.RouteName;
            _result.AreaId = route.AreaId;
            _result.Narration = route.Narration;
            _result.CreatedDate = route.CreatedDate;
            _result.ModifiedDate = route.ModifiedDate;
            return _result;
        }
        #endregion

        #region Size
        public static IList<BaseSizeModel> ToBaseSizes(this List<Size> sizes)
        {
            IList<BaseSizeModel> _result = new List<BaseSizeModel>();
            sizes.ForEach(size => _result.Add(size.ToBaseSize()));
            return _result;
        }

        public static BaseSizeModel ToBaseSize(this Size size)
        {
            BaseSizeModel _result = new BaseSizeModel();
            _result.Id = size.Id;
            _result.Size1 = size.Size1;
            _result.Narration = size.Narration;
            _result.CreatedDate = size.CreatedDate;
            _result.ModifiedDate = size.ModifiedDate;
            return _result;
        }
        #endregion

        #region Unit
        public static IList<BaseUnitModel> ToBaseUnits(this List<Unit> units)
        {
            IList<BaseUnitModel> _result = new List<BaseUnitModel>();
            units.ForEach(unit => _result.Add(unit.ToBaseUnit()));
            return _result;
        }

        public static BaseUnitModel ToBaseUnit(this Unit unit)
        {
            BaseUnitModel _result = new BaseUnitModel();
            _result.Id = unit.Id;
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
