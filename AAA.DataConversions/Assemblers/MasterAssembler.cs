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
            _result.PageSize= master.PageSize;
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
          BaseCurrencyModel _result=new BaseCurrencyModel();
             
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

        public static BaseTaxModel ToBasetax(this Tax tax)
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
         public static IList<BaseVoucherTypeModel> ToBaseVoucherTypes(this List<VoucherType> vochertypes)
        {
            IList<BaseVoucherTypeModel> _result = new List<BaseVoucherTypeModel>();
            vouchertypes.ForEach(voucher => _result.Add(voucher.ToBaseVoucherType()));
            return _result;
        }

        public static BaseVoucherTypeModel ToBaseVoucherType(this VoucherType vouchertype)
        {
            BaseVoucherTypeModel _result = new BaseVoucherTypeModel();
             
            _result.Id = vouchertype.Id;
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
            _result.CreatedDate = vouchertype.CreatedDate;
            _result.ModifiedDate = vouchertype.ModifiedDate;
             _result.MasterId = vouchertype.MasterId;
            return _result;
        }

        #endregion
        #region AccountGroup
        public static IList<BaseAccountGroupModel> ToBaseAccountGroups(this List<AccountGroup> accountgroups)
        {
            IList<BaseAccountGroupModel> _result = new List<BaseAccountGroupModel>();
            accountgroups.ForEach(accountgroup => _result.Add(accountgroup.ToBaseAccountGroupModel()));
            return _result;
        }

        public static BaseAccountGroupModel ToBaseAccountGroup(this AccountGroup accountgroup)
        {
            BaseAccountGroupModel _result = new BaseAccountGroupModel();
        
            
            _result.Id = accountgroup.Id;
             _result.AccountGroupName = accountgroup.AccountGroupName;
             _result.GroupUnder = accountgroup.GroupUnder;
             _result.Narration = accountgroup.Narration;
             _result.IsDefault = accountgroup.IsDefault;
             _result.Nature = accountgroup.Nature;
            _result.AffectGrossProfit = accountgroup.AffectGrossProfit;
             _result.CreatedDate = accountgroup.CreatedDate;
            _result.ModifiedDate = accountgroup.ModifiedDate;
            return _result;
        }
        #endregion
         #region AccountLedger
        public static IList<BaseAccountLedgerModel> ToBaseAccountLedgers(this List<AccountLedger> accountledgers)
        {
            IList<BaseAccountLedgerModel> _result = new List<BaseAccountLedgerModel>();
            accountledgers.ForEach(accountledger => _result.Add(accountledger.ToBaseAccountLedger()));
            return _result;
        }

        public static BaseAccountLedgerModel ToBaseAccountLedger(this AccountLedger accountledger)
        {
            BaseAccountLedgerModel _result = new BaseAccountLedgerModel();
           
            _result.Id = accountledger.Id;
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
            _result.CreatedDate = accountledger.CreatedDate;
            _result.ModifiedDate = accountledger.ModifiedDate;
             _result.AccountGroup = accountledger.AccountGroup;
             _result.Area = accountledger.Area;
             _result.PricingLevel = accountledger.PricingLevel;
             _result.Route = accountledger.Route;
            return _result;
        }
        #endregion
        #region AdditionalCost
         public static IList<BaseAdditionalCostModel> ToBaseAdditionalCosts(this List<AdditionalCost> additionalcosts)
        {
            IList<BaseAdditionalCostModel> _result = new List<BaseAdditionalCostModel>();
            additionalcosts.ForEach(additionalcost => _result.Add(additionalcost.ToBaseAdditionalCostModel()));
            return _result;
        }

        public static BaseAdditionalCostModel ToBaseAdditionalCost(this AdditionalCost master)
        {
            BaseAdditionalCostModel _result = new BaseAdditionalCostModel();
            
         _result.Id = additionalmodel.Id;
            _result.VoucherTypeId = additionalmodel.VoucherTypeId;
            _result.LedgerId = additionalmodel.LedgerId;
            _result.VoucherNumber = additionalmodel.VoucherNumber;
            _result.Debit = additionalmodel.Debit;
            _result.Credit = additionalmodel.Credit;
            _result.CreatedDate = additionalmodel.CreatedDate;
            _result.ModifiedDate = additionalmodel.ModifiedDate;
            _result.AccountLedger = additionalmodel.AccountLedger;
             _result.VoucherType = additionalmodel.VoucherType;
            
            
            
            return _result;
        }
        #endregion
        #region AdvancePayment
         public static IList<BaseAdvancePaymentModel> ToBaseAdvancePayments(this List<AdvancePayment> advancepayments)
        {
            IList<BaseAdvancePaymentModel> _result = new List<BaseAdvancePaymentModel>();
            advancepayments.ForEach(advancepayment => _result.Add(advancepayment.ToBaseAdvancePayment()));
            return _result;
        }

        public static BaseAdvancePaymentModel ToBaseAdvancePayment(this AdvancePayment advancepayment)
        {
            BaseAdvancePaymentModel _result = new BaseAdvancePaymentModel();
        
            
         _result.Id = advancepayment.Id;
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
               _result.CreatedDate = advancepayment.CreatedDate;
               _result.ModifiedDate = advancepayment.ModifiedDate;
               _result.AccountLedger = advancepayment.AccountLedger;
               _result.Employee = advancepayment.Employee;
               _result.FinancialYear = advancepayment.FinancialYear;
               _result.SuffixPrefix = advancepayment.SuffixPrefix;
               _result.VoucherType = advancepayment.VoucherTypeVoucherType;
              
            
            
            
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
        _result.Product = batch.Product;
        
       
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

        public static BaseBrandModel ToBaseBrand(this Brand area)
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
         public static IList<BaseExchangeRateModel> ToBaseExchangeRates(this List<ExchangeRate> exchangerates)
        {
            IList<BaseExchangeRateModel> _result = new List<BaseExchangeRateModel>();
            exchangerates.ForEach(exchangerate => _result.Add(exchangerate.ToBaseExchangeRate()));
            return _result;
        }

        public static BaseExchangeRateModel ToBaseExchangeRate(this ExchangeRate exchangerate)
        {
            BaseExchangeRateModel _result = new BaseExchangeRateModel();
          
           
        
         
      _result.Id = exchangerate.Id;
             _result.CurrencyId = exchangerate.CurrencyId;
             _result.Date = exchangerate.Date;
             _result.Rate = exchangerate.Rate;
             _result.Narration = exchangerate.Narration;
             _result.CreatedDate = exchangerate.CreatedDate;
             _result.ModifiedDate = exchangerate.ModifiedDate;
            _result.Currency = exchangerate.Currency;
            
       
       
            return _result;
        }
        #endregion

          #region Godown
         public static IList<BaseGodownModel> ToBaseBaseGodowns(this List<Godown> godowns)
        {
            IList<BaseGodownModel> _result = new List<BaseGodownModel>();
            godowns.ForEach(godown => _result.Add(godown.ToBaseBaseGodown()));
            return _result;
        }

        public static BaseGodownModel ToBaseBaseGodown(this Godown godown)
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
         public static IList<BaseModelNumberModel> ToBaseBaseModelNumbers(this List<ModelNumber> modelnumbers)
        {
            IList<BaseModelNumberModel> _result = new List<BaseModelNumberModel>();
            modelnumbers.ForEach(modelnumber => _result.Add(modelnumber.ToBaseBrand()));
            return _result;
        }

        public static BaseModelNumberModel ToBaseBaseModelNumber(this ModelNumber modelnumber)
        {
            BaseModelNumberModel _result = new BaseModelNumberModel();
           
        
         _result.Id = modelnumber.Id;
            _result.ModelNo = modelnumber.ModelNo;
            _result.Narration = modelnumber.Narration;
            _result.CreatedDate = modelnumber.CreatedDate;
            _result.ModifiedDate = modelnumber.ModifiedDate;
             
            
           
            return _result;
        }
        #endregion
         #region PricingLevel
         public static IList<BasePricingLevelModel> ToBaseBasePricingLevels(this List<PricingLevel> pricinglevels)
        {
            IList<BasePricingLevelModel> _result = new List<BasePricingLevelModel>();
            pricinglevels.ForEach(pricinglevel => _result.Add(pricinglevel.ToBaseBasePricingLevel()));
            return _result;
        }

        public static BasePricingLevelModel ToBaseBasePricingLevel(this PricingLevel pricinglevel)
        {
            BasePricingLevelModel _result = new BasePricingLevelModel();
            
        
         _result.Id = pricinglevel.Id;
            _result.PricingLevelName = pricinglevel.PricingLevelName;
            _result.Narration = pricinglevel.Narration;
            _result.CreatedDate = pricinglevel.CreatedDate;
            _result.ModifiedDate = pricinglevel.ModifiedDate;
            
           
            return _result;
        }
        #endregion
        #region ProductGroup
         public static IList<BaseProductGroupModel> ToBaseBaseProductGroups(this List<ProductGroup> productgroups)
        {
            IList<BaseProductGroupModel> _result = new List<BaseProductGroupModel>();
            productgroups.ForEach(productgroup => _result.Add(productgroup.ToBaseBaseProductGroup()));
            return _result;
        }

        public static BaseProductGroupModel ToBaseBaseProductGroup(this ProductGroup productgroup)
        {
            BaseProductGroupModel _result = new BaseProductGroupModel();
            
         
         _result.Id = productgroup.Id;
             _result.GroupName = productgroup.GroupName;
             _result.GroupUnder = productgroup.GroupUnder;
             _result.Narration = productgroup.Narration;
             _result.CreatedDate = productgroup.CreatedDate;
             _result.ModifiedDate = productgroup.ModifiedDate;
            
           
            return _result;
        }
        #endregion
         #region Product
         public static IList<BaseProductModel> ToBaseBaseProducts(this List<Product> products)
        {
            IList<BaseProductModel> _result = new List<BaseProductModel>();
            products.ForEach(product => _result.Add(product.ToBaseBaseProduct()));
            return _result;
        }

        public static BaseProductModel ToBaseBaseProduct(this Product product)
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
         public static IList<BaseRackModel> ToBaseBaseRacks(this List<Rack> racks)
        {
            IList<BaseRackModel> _result = new List<BaseRackModel>();
            racks.ForEach(rack => _result.Add(rack.ToBaseBaseRack()));
            return _result;
        }

        public static BaseRackModel ToBaseBaseRack(this Rack rack)
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
         public static IList<BaseSizeModel> ToBaseBaseSizes(this List<Size> sizes)
        {
            IList<BaseSizeModel> _result = new List<BaseSizeModel>();
            sizes.ForEach(size => _result.Add(size.ToBaseBaseSize()));
            return _result;
        }

        public static BaseSizeModel ToBaseBaseSize(this Size size)
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
         public static IList<BaseUnitModel> ToBaseBaseUnits(this List<Unit> units)
        {
            IList<BaseUnitModel> _result = new List<BaseUnitModel>();
            units.ForEach(unit => _result.Add(unit.ToBaseBaseRack()));
            return _result;
        }

        public static BaseUnitModel ToBaseBaseUnit(this Unit unit)
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
