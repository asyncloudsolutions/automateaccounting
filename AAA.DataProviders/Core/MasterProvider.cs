using AAA.ReqResp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.DataProviders
{
    public class MasterProvider : ProviderHelper, IMasterProvider
    {
        #region Master
        #region Get
        public async Task<GetBaseMastersResponse> GetBaseMastersAsync(GetBaseMastersRequest request)
        {
            return await Task.Run(() =>
            {
                GetBaseMastersResponse _response = new GetBaseMastersResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    ExpressionStarter<Master> _predicateMaster = PredicateBuilder.New<Master>(true);
                    if (request.Id.HasValue) { _predicateCompany = _predicateMaster.And(p => p.Id == request.Id); }
                    List<Master> _masters = _dbContext.Masters.AsExpandable().Where(_predicateMaster).ToList();
                    if (_masters.Any()) { _response.BaseObjects = _masters.ToBaseMasters(); }
                }
                return _response;
            });
        }
        #endregion

        #region Upsert
        public async Task<UpsertBaseMasterResponse> UpsertBaseMasterAsync(UpsertBaseMasterRequest request)
        {
            return await Task.Run(() =>
            {
                UpsertBaseMasterResponse _response = new UpsertBaseMasterResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    if (request.BaseObject != null)
                    {
                        try
                        {
                            Master _master = request.BaseObject.ToMaster();
                            UpsertEntity<Master>(request.BaseObject.Id, ref _master, _dbContext);
                            _response.BaseObject = _master.ToBaseMaster();
                        }
                        catch (Exception ex) { AssignStatusData(_response, false, string.Format("Some error occurred during DB interaction. Message is something like : \n{0}", ex.Message)); }
                    }
                    else { AssignStatusData(_response, false, "No entity data recieved to insert/update."); }
                }
                return _response;
            });
        }
        #endregion
        #endregion

        #region Currency
        #region Get
        public async Task<GetBaseCurrenciesResponse> GetBaseCurrenciesAsync(GetBaseCurrenciesRequest request)
        {
            return await Task.Run(() =>
            {
                GetBaseCurrenciesResponse _response = new GetBaseCurrenciesResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    ExpressionStarter<Currency> _predicateCurrency = PredicateBuilder.New<Currency>(true);
                    if (request.Id.HasValue) { _predicateCurrency = _predicateCurrency.And(p => p.Id == request.Id); }
                    List<Currency> _currencies = _dbContext.Currencies.AsExpandable().Where(_predicateCurrency).ToList();
                    if (_currencies.Any()) { _response.BaseObjects = _currencies.ToBaseCurrency(); }
                }
                return _response;
            });
        }
        #endregion

        #region Upsert
        public async Task<UpsertBaseCurrencyResponse> UpsertBaseCurrencyAsync(UpsertBaseCurrencyRequest request)
        {
            return await Task.Run(() =>
            {
                UpsertBaseCurrencyResponse _response = new UpsertBaseCurrencyResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    if (request.BaseObject != null)
                    {
                        try
                        {
                            Currency _currency = request.BaseObject.ToCurrency();
                            UpsertEntity<Currency>(request.BaseObject.Id, ref _currency, _dbContext);
                            _response.BaseObject = _currency.ToBaseCompany();
                        }
                        catch (Exception ex) { AssignStatusData(_response, false, string.Format("Some error occurred during DB interaction. Message is something like : \n{0}", ex.Message)); }
                    }
                    else { AssignStatusData(_response, false, "No entity data recieved to insert/update."); }
                }
                return _response;
            });
        }
        #endregion
        #endregion

        
        #region Tax
        #region Get
        public async Task<GetBaseTaxesResponse> GetBaseTaxesAsync(GetBaseTaxesRequest request)
        {
            return await Task.Run(() =>
            {
                GetBaseTaxesResponse _response = new GetBaseTaxesResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    ExpressionStarter<Tax> _predicateTax = PredicateBuilder.New<Tax>(true);
                    if (request.Id.HasValue) { _predicateTax = _predicateTax.And(p => p.Id == request.Id); }
                    List<Tax> _taxes = _dbContext.Taxes.AsExpandable().Where(_predicateTax).ToList();
                    if (_taxes.Any()) { _response.BaseObjects = _taxes.ToBaseTaxes(); }
                }
                return _response;
            });
        }
        #endregion

        #region Upsert
        public async Task<UpsertBaseTaxResponse> UpsertBaseTaxAsync(UpsertBaseTaxRequest request)
        {
            return await Task.Run(() =>
            {
                UpsertBaseTaxResponse _response = new UpsertBaseTaxResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    if (request.BaseObject != null)
                    {
                        try
                        {
                            Tax _taxes = request.BaseObject.ToTax();
                            UpsertEntity<Tax>(request.BaseObject.Id, ref _tax, _dbContext);
                            _response.BaseObject = _tax.ToBaseTax();
                        }
                        catch (Exception ex) { AssignStatusData(_response, false, string.Format("Some error occurred during DB interaction. Message is something like : \n{0}", ex.Message)); }
                    }
                    else { AssignStatusData(_response, false, "No entity data recieved to insert/update."); }
                }
                return _response;
            });
        }
        #endregion
        #endregion

    

        #region VoucherType
        #region Get
        public async Task<GetBaseVoucherTypesResponse> GetBaseVoucherTypesAsync(GetBaseVoucherTypesRequest request)
        {
            return await Task.Run(() =>
            {
                GetBaseVoucherTypesResponse _response = new GetBaseVoucherTypesResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    ExpressionStarter<VoucherType> _predicateVoucherType = PredicateBuilder.New<VoucherType>(true);
                    if (request.Id.HasValue) { _predicateVoucherType = _predicateVoucherType.And(p => p.Id == request.Id); }
                    List<VoucherType> _voucherTypes = _dbContext.VoucherTypes.AsExpandable().Where(_predicateVoucherType).ToList();
                    if (_voucherTypes.Any()) { _response.BaseObjects = _voucherTypes.ToBaseVoucherTypes(); }
                }
                return _response;
            });
        }
        #endregion

        #region Upsert
        public async Task<UpsertBaseVoucherTypeResponse> UpsertBaseVoucherTypeAsync(UpsertBaseVoucherTypeRequest request)
        {
            return await Task.Run(() =>
            {
                UpsertBaseVoucherTypeResponse _response = new UpsertBaseVoucherTypeResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    if (request.BaseObject != null)
                    {
                        try
                        {
                            VoucherType _voucherType = request.BaseObject.ToVoucherType();
                            UpsertEntity<VoucherType>(request.BaseObject.Id, ref _voucherType, _dbContext);
                            _response.BaseObject = _voucherType.ToBaseVoucherType();
                        }
                        catch (Exception ex) { AssignStatusData(_response, false, string.Format("Some error occurred during DB interaction. Message is something like : \n{0}", ex.Message)); }
                    }
                    else { AssignStatusData(_response, false, "No entity data recieved to insert/update."); }
                }
                return _response;
            });
        }
        #endregion
        #endregion

        #region AccountGroup
        #region Get
        public async Task<GetBaseAccountGroupsResponse> GetBaseAccountGroupsAsync(GetBaseAccountGroupsRequest request)
        {
            return await Task.Run(() =>
            {
                GetBaseAccountGroupsResponse _response = new GetBaseAccountGroupsResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    ExpressionStarter<AccountGroup> _predicateAccountGroup = PredicateBuilder.New<AccountGroup>(true);
                    if (request.Id.HasValue) { _predicateAccountGroup = _predicateAccountGroup.And(p => p.Id == request.Id); }
                    List<AccountGroup> _accountGroups = _dbContext.AccountGroups.AsExpandable().Where(_predicateAccountGroup).ToList();
                    if (_accountGroups.Any()) { _response.BaseObjects = _accountGroups.ToBaseAccountGroups(); }
                }
                return _response;
            });
        }
        #endregion

        #region Upsert
        public async Task<UpsertBaseAccountGroupResponse> UpsertBaseAccountGroupAsync(UpsertBaseAccountGroupRequest request)
        {
            return await Task.Run(() =>
            {
                UpsertBaseAccountGroupResponse _response = new UpsertBaseAccountGroupResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    if (request.BaseObject != null)
                    {
                        try
                        {
                            AccountGroup _accountGroup = request.BaseObject.ToAccountGroup();
                            UpsertEntity<AccountGroup>(request.BaseObject.Id, ref _accountGroup, _dbContext);
                            _response.BaseObject = _accountGroup.ToBaseAccountGroup();
                        }
                        catch (Exception ex) { AssignStatusData(_response, false, string.Format("Some error occurred during DB interaction. Message is something like : \n{0}", ex.Message)); }
                    }
                    else { AssignStatusData(_response, false, "No entity data recieved to insert/update."); }
                }
                return _response;
            });
        }
        #endregion
        #endregion

        #region AccountLedger
        #region Get
        public async Task<GetBaseAccountLedgersResponse> GetBaseAccountLedgersAsync(GetBaseAccountLedgersRequest request)
        {
            return await Task.Run(() =>
            {
                GetBaseAccountLedgersResponse _response = new GetBaseAccountLedgersResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    ExpressionStarter<AccountLedger> _predicateAccountLedger = PredicateBuilder.New<AccountLedger>(true);
                    if (request.Id.HasValue) { _predicateAccountLedger = _predicateAccountLedger.And(p => p.Id == request.Id); }
                    List<AccountLedger> _accountLedgers = _dbContext.AccountLedgers.AsExpandable().Where(_predicateAccountLedger).ToList();
                    if (_accountLedgers.Any()) { _response.BaseObjects = _accountLedgers.ToBaseAccountLedgers(); }
                }
                return _response;
            });
        }
        #endregion

        #region Upsert
        public async Task<UpsertBaseAccountLedgerResponse> UpsertBaseAccountLedgerAsync(UpsertBaseAccountLedgerRequest request)
        {
            return await Task.Run(() =>
            {
                UpsertBaseAccountLedgerResponse _response = new UpsertBaseAccountLedgerResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    if (request.BaseObject != null)
                    {
                        try
                        {
                            AccountLedger _accountLedger = request.BaseObject.ToAccountLedger();
                            UpsertEntity<AccountLedger>(request.BaseObject.Id, ref _accountLedger, _dbContext);
                            _response.BaseObject = _accountLedger.ToBaseAccountLedger();
                        }
                        catch (Exception ex) { AssignStatusData(_response, false, string.Format("Some error occurred during DB interaction. Message is something like : \n{0}", ex.Message)); }
                    }
                    else { AssignStatusData(_response, false, "No entity data recieved to insert/update."); }
                }
                return _response;
            });
        }
        #endregion
        #endregion

        #region AdditionalCost
        #region Get
        public async Task<GetBaseAdditionalCostsResponse> GetBaseAdditionalCostsAsync(GetBaseAdditionalCostsRequest request)
        {
            return await Task.Run(() =>
            {
                GetBaseAdditionalCostsResponse _response = new GetBaseAdditionalCostsResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    ExpressionStarter<AdditionalCost> _predicateAdditionalCost = PredicateBuilder.New<AdditionalCost>(true);
                    if (request.Id.HasValue) { _predicateAdditionalCost = _predicateAdditionalCost.And(p => p.Id == request.Id); }
                    List<AdditionalCost> _additionalCosts = _dbContext.AdditionalCosts.AsExpandable().Where(_predicateAdditionalCost).ToList();
                    if (_additionalCosts.Any()) { _response.BaseObjects = _additionalCosts.ToBaseAdditionalCosts(); }
                }
                return _response;
            });
        }
        #endregion

        #region Upsert
        public async Task<UpsertBaseAdditionalCostResponse> UpsertBaseAdditionalCostAsync(UpsertBaseAdditionalCostRequest request)
        {
            return await Task.Run(() =>
            {
                UpsertBaseAdditionalCostResponse _response = new UpsertBaseAdditionalCostResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    if (request.BaseObject != null)
                    {
                        try
                        {
                            AdditionalCost _additionalCost = request.BaseObject.ToAdditionalCost();
                            UpsertEntity<AdditionalCost>(request.BaseObject.Id, ref _additionalCost, _dbContext);
                            _response.BaseObject = _additionalCost.ToBaseAdditionalCost();
                        }
                        catch (Exception ex) { AssignStatusData(_response, false, string.Format("Some error occurred during DB interaction. Message is something like : \n{0}", ex.Message)); }
                    }
                    else { AssignStatusData(_response, false, "No entity data recieved to insert/update."); }
                }
                return _response;
            });
        }
        #endregion
        #endregion

        #region AdvancePayment
        #region Get
        public async Task<GetBaseAdvancePaymentsResponse> GetBaseAdvancePaymentsAsync(GetBaseAdvancePaymentsRequest request)
        {
            return await Task.Run(() =>
            {
                GetBaseAdvancePaymentsResponse _response = new GetBaseAdvancePaymentsResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    ExpressionStarter<AdvancePayment> _predicateAdvancePayment = PredicateBuilder.New<AdvancePayment>(true);
                    if (request.Id.HasValue) { _predicateAdvancePayment = _predicateAdvancePayment.And(p => p.Id == request.Id); }
                    List<AdvancePayment> _advancePayments = _dbContext.AdvancePayments.AsExpandable().Where(_predicateAdvancePayment).ToList();
                    if (_advancePayments.Any()) { _response.BaseObjects = _advancePayments.ToBaseAdvancePayments(); }
                }
                return _response;
            });
        }
        #endregion

        #region Upsert
        public async Task<UpsertBaseAdvancePaymentResponse> UpsertBaseAdvancePaymentAsync(UpsertBaseAdvancePaymentRequest request)
        {
            return await Task.Run(() =>
            {
                UpsertBaseAdvancePaymentResponse _response = new UpsertBaseAdvancePaymentResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    if (request.BaseObject != null)
                    {
                        try
                        {
                            AdvancePayment _advancePayment = request.BaseObject.ToAdvancePayment();
                            UpsertEntity<AdvancePayment>(request.BaseObject.Id, ref _advancePayment, _dbContext);
                            _response.BaseObject = _advancePayment.ToBaseAdvancePayment();
                        }
                        catch (Exception ex) { AssignStatusData(_response, false, string.Format("Some error occurred during DB interaction. Message is something like : \n{0}", ex.Message)); }
                    }
                    else { AssignStatusData(_response, false, "No entity data recieved to insert/update."); }
                }
                return _response;
            });
        }
        #endregion
        #endregion

        #region Area
        #region Get
        public async Task<GetBaseAreasResponse> GetBaseAreasAsync(GetBaseAreasRequest request)
        {
            return await Task.Run(() =>
            {
                GetBaseAreasResponse _response = new GetBaseAreasResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    ExpressionStarter<Area> _predicateArea = PredicateBuilder.New<Area>(true);
                    if (request.Id.HasValue) { _predicateArea = _predicateArea.And(p => p.Id == request.Id); }
                    List<Area> _areas = _dbContext.Areas.AsExpandable().Where(_predicateArea).ToList();
                    if (_areas.Any()) { _response.BaseObjects = _areas.ToBaseAreas(); }
                }
                return _response;
            });
        }
        #endregion

        #region Upsert
        public async Task<UpsertBaseAreaResponse> UpsertBaseAreaAsync(UpsertBaseAreaRequest request)
        {
            return await Task.Run(() =>
            {
                UpsertBaseAreaResponse _response = new UpsertBaseAreaResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    if (request.BaseObject != null)
                    {
                        try
                        {
                            Area _area = request.BaseObject.ToArea();
                            UpsertEntity<Area>(request.BaseObject.Id, ref _area, _dbContext);
                            _response.BaseObject = _area.ToBaseArea();
                        }
                        catch (Exception ex) { AssignStatusData(_response, false, string.Format("Some error occurred during DB interaction. Message is something like : \n{0}", ex.Message)); }
                    }
                    else { AssignStatusData(_response, false, "No entity data recieved to insert/update."); }
                }
                return _response;
            });
        }
        #endregion
        #endregion

        #region Batch
        #region Get
        public async Task<GetBaseBatchesResponse> GetBaseBatchesAsync(GetBaseBatchesRequest request)
        {
            return await Task.Run(() =>
            {
                GetBaseBatchesResponse _response = new GetBaseBatchesResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    ExpressionStarter<Batch> _predicateBatch = PredicateBuilder.New<Batch>(true);
                    if (request.Id.HasValue) { _predicateBatch = _predicateBatch.And(p => p.Id == request.Id); }
                    List<Batch> _batches = _dbContext.Batches.AsExpandable().Where(_predicateBatch).ToList();
                    if (_batches.Any()) { _response.BaseObjects = _batches.ToBaseBatches(); }
                }
                return _response;
            });
        }
        #endregion

        #region Upsert
        public async Task<UpsertBaseBatchResponse> UpsertBaseBatchAsync(UpsertBaseBatchRequest request)
        {
            return await Task.Run(() =>
            {
                UpsertBaseBatchResponse _response = new UpsertBaseBatchResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    if (request.BaseObject != null)
                    {
                        try
                        {
                            Batch _batch = request.BaseObject.ToBatch();
                            UpsertEntity<Batch>(request.BaseObject.Id, ref _batch, _dbContext);
                            _response.BaseObject = _batch.ToBaseBatch();
                        }
                        catch (Exception ex) { AssignStatusData(_response, false, string.Format("Some error occurred during DB interaction. Message is something like : \n{0}", ex.Message)); }
                    }
                    else { AssignStatusData(_response, false, "No entity data recieved to insert/update."); }
                }
                return _response;
            });
        }
        #endregion
        #endregion

        #region Brand
        #region Get
        public async Task<GetBaseBrandsResponse> GetBaseBrandsAsync(GetBaseBrandsRequest request)
        {
            return await Task.Run(() =>
            {
                GetBaseBrandsResponse _response = new GetBaseBrandsResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    ExpressionStarter<Brand> _predicateBrand = PredicateBuilder.New<Brand>(true);
                    if (request.Id.HasValue) { _predicateBrand = _predicateBrand.And(p => p.Id == request.Id); }
                    List<Brand> _brands = _dbContext.Brands.AsExpandable().Where(_predicateBrand).ToList();
                    if (_brands.Any()) { _response.BaseObjects = _brands.ToBaseBrands(); }
                }
                return _response;
            });
        }
        #endregion

        #region Upsert
        public async Task<UpsertBaseBrandResponse> UpsertBaseBrandAsync(UpsertBaseBrandRequest request)
        {
            return await Task.Run(() =>
            {
                UpsertBaseBrandResponse _response = new UpsertBaseBrandResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    if (request.BaseObject != null)
                    {
                        try
                        {
                            Brand _brand = request.BaseObject.ToBrand();
                            UpsertEntity<Brand>(request.BaseObject.Id, ref _brand, _dbContext);
                            _response.BaseObject = _brand.ToBaseBrand();
                        }
                        catch (Exception ex) { AssignStatusData(_response, false, string.Format("Some error occurred during DB interaction. Message is something like : \n{0}", ex.Message)); }
                    }
                    else { AssignStatusData(_response, false, "No entity data recieved to insert/update."); }
                }
                return _response;
            });
        }
        #endregion
        #endregion

        #region ExchangeRate
        #region Get
        public async Task<GetBaseExchangeRatesResponse> GetBaseExchangeRatesAsync(GetBaseExchangeRatesRequest request)
        {
            return await Task.Run(() =>
            {
                GetBaseExchangeRatesResponse _response = new GetBaseExchangeRatesResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    ExpressionStarter<ExchangeRate> _predicateExchangeRate = PredicateBuilder.New<ExchangeRate>(true);
                    if (request.Id.HasValue) { _predicateExchangeRate = _predicateExchangeRate.And(p => p.Id == request.Id); }
                    List<ExchangeRate> _exchangeRates = _dbContext.ExchangeRates.AsExpandable().Where(_predicateExchangeRate).ToList();
                    if (_exchangeRates.Any()) { _response.BaseObjects = _exchangeRates.ToBaseExchangeRates(); }
                }
                return _response;
            });
        }
        #endregion

        #region Upsert
        public async Task<UpsertBaseExchangeRateResponse> UpsertBaseExchangeRateAsync(UpsertBaseExchangeRateRequest request)
        {
            return await Task.Run(() =>
            {
                UpsertBaseExchangeRateResponse _response = new UpsertBaseExchangeRateResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    if (request.BaseObject != null)
                    {
                        try
                        {
                            ExchangeRate _exchangeRate = request.BaseObject.ToExchangeRate();
                            UpsertEntity<ExchangeRate>(request.BaseObject.Id, ref _exchangeRate, _dbContext);
                            _response.BaseObject = _exchangeRate.ToBaseExchangeRate();
                        }
                        catch (Exception ex) { AssignStatusData(_response, false, string.Format("Some error occurred during DB interaction. Message is something like : \n{0}", ex.Message)); }
                    }
                    else { AssignStatusData(_response, false, "No entity data recieved to insert/update."); }
                }
                return _response;
            });
        }
        #endregion
        #endregion

        #region Godown
        #region Get
        public async Task<GetBaseGodownsResponse> GetBaseGodownsAsync(GetBaseGodownsRequest request)
        {
            return await Task.Run(() =>
            {
                GetBaseGodownsResponse _response = new GetBaseGodownsResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    ExpressionStarter<Godown> _predicateGodown = PredicateBuilder.New<Godown>(true);
                    if (request.Id.HasValue) { _predicateGodown = _predicateGodown.And(p => p.Id == request.Id); }
                    List<Godown> _godowns = _dbContext.Godowns.AsExpandable().Where(_predicateGodown).ToList();
                    if (_godowns.Any()) { _response.BaseObjects = _godowns.ToBaseGodowns(); }
                }
                return _response;
            });
        }
        #endregion

        #region Upsert
        public async Task<UpsertBaseGodownResponse> UpsertBaseGodownAsync(UpsertBaseGodownRequest request)
        {
            return await Task.Run(() =>
            {
                UpsertBaseGodownResponse _response = new UpsertBaseGodownResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    if (request.BaseObject != null)
                    {
                        try
                        {
                            Godown _godown = request.BaseObject.ToGodown();
                            UpsertEntity<Godown>(request.BaseObject.Id, ref _godown, _dbContext);
                            _response.BaseObject = _godown.ToBaseGodown();
                        }
                        catch (Exception ex) { AssignStatusData(_response, false, string.Format("Some error occurred during DB interaction. Message is something like : \n{0}", ex.Message)); }
                    }
                    else { AssignStatusData(_response, false, "No entity data recieved to insert/update."); }
                }
                return _response;
            });
        }
        #endregion
        #endregion

        #region ModelNumber
        #region Get
        public async Task<GetBaseModelNumbersResponse> GetBaseModelNumbersAsync(GetBaseModelNumbersRequest request)
        {
            return await Task.Run(() =>
            {
                GetBaseModelNumbersResponse _response = new GetBaseModelNumbersResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    ExpressionStarter<ModelNumber> _predicateModelNumber = PredicateBuilder.New<ModelNumber>(true);
                    if (request.Id.HasValue) { _predicateModelNumber = _predicateModelNumber.And(p => p.Id == request.Id); }
                    List<ModelNumber> _modelNumbers = _dbContext.ModelNumbers.AsExpandable().Where(_predicateModelNumber).ToList();
                    if (_modelNumbers.Any()) { _response.BaseObjects = _modelNumbers.ToBaseModelNumbers(); }
                }
                return _response;
            });
        }
        #endregion

        #region Upsert
        public async Task<UpsertBaseModelNumberResponse> UpsertBaseModelNumberAsync(UpsertBaseModelNumberRequest request)
        {
            return await Task.Run(() =>
            {
                UpsertBaseModelNumberResponse _response = new UpsertBaseModelNumberResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    if (request.BaseObject != null)
                    {
                        try
                        {
                            ModelNumber _modelNumber = request.BaseObject.ToModelNumber();
                            UpsertEntity<ModelNumber>(request.BaseObject.Id, ref _modelNumber, _dbContext);
                            _response.BaseObject = _modelNumber.ToBaseModelNumber();
                        }
                        catch (Exception ex) { AssignStatusData(_response, false, string.Format("Some error occurred during DB interaction. Message is something like : \n{0}", ex.Message)); }
                    }
                    else { AssignStatusData(_response, false, "No entity data recieved to insert/update."); }
                }
                return _response;
            });
        }
        #endregion
        #endregion

        #region PricingLevel
        #region Get
        public async Task<GetBasePricingLevelsResponse> GetBasePricingLevelsAsync(GetBasePricingLevelsRequest request)
        {
            return await Task.Run(() =>
            {
                GetBasePricingLevelsResponse _response = new GetBasePricingLevelsResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    ExpressionStarter<PricingLevel> _predicatePricingLevel = PredicateBuilder.New<PricingLevel>(true);
                    if (request.Id.HasValue) { _predicatePricingLevel = _predicatePricingLevel.And(p => p.Id == request.Id); }
                    List<PricingLevel> _pricingLevels = _dbContext.PricingLevels.AsExpandable().Where(_predicatePricingLevel).ToList();
                    if (_pricingLevels.Any()) { _response.BaseObjects = _pricingLevels.ToBasePricingLevels(); }
                }
                return _response;
            });
        }
        #endregion

        #region Upsert
        public async Task<UpsertBasePricingLevelResponse> UpsertBasePricingLevelAsync(UpsertBasePricingLevelRequest request)
        {
            return await Task.Run(() =>
            {
                UpsertBasePricingLevelResponse _response = new UpsertBasePricingLevelResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    if (request.BaseObject != null)
                    {
                        try
                        {
                            PricingLevel _pricingLevel = request.BaseObject.ToPricingLevel();
                            UpsertEntity<PricingLevel>(request.BaseObject.Id, ref _pricingLevel, _dbContext);
                            _response.BaseObject = _pricingLevel.ToBasePricingLevel();
                        }
                        catch (Exception ex) { AssignStatusData(_response, false, string.Format("Some error occurred during DB interaction. Message is something like : \n{0}", ex.Message)); }
                    }
                    else { AssignStatusData(_response, false, "No entity data recieved to insert/update."); }
                }
                return _response;
            });
        }
        #endregion
        #endregion

        #region ProductGroup
        #region Get
        public async Task<GetBaseProductGroupsResponse> GetBaseProductGroupsAsync(GetBaseProductGroupsRequest request)
        {
            return await Task.Run(() =>
            {
                GetBaseProductGroupsResponse _response = new GetBaseProductGroupsResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    ExpressionStarter<ProductGroup> _predicateProductGroup = PredicateBuilder.New<ProductGroup>(true);
                    if (request.Id.HasValue) { _predicateProductGroup = _predicateProductGroup.And(p => p.Id == request.Id); }
                    List<ProductGroup> _productGroups = _dbContext.ProductGroups.AsExpandable().Where(_predicateProductGroup).ToList();
                    if (_productGroups.Any()) { _response.BaseObjects = _productGroups.ToBaseProductGroups(); }
                }
                return _response;
            });
        }
        #endregion

        #region Upsert
        public async Task<UpsertBaseProductGroupResponse> UpsertBaseProductGroupAsync(UpsertBaseProductGroupRequest request)
        {
            return await Task.Run(() =>
            {
                UpsertBaseProductGroupResponse _response = new UpsertBaseProductGroupResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    if (request.BaseObject != null)
                    {
                        try
                        {
                            ProductGroup _productGroup = request.BaseObject.ToProductGroup();
                            UpsertEntity<ProductGroup>(request.BaseObject.Id, ref _productGroup, _dbContext);
                            _response.BaseObject = _productGroup.ToBaseProductGroup();
                        }
                        catch (Exception ex) { AssignStatusData(_response, false, string.Format("Some error occurred during DB interaction. Message is something like : \n{0}", ex.Message)); }
                    }
                    else { AssignStatusData(_response, false, "No entity data recieved to insert/update."); }
                }
                return _response;
            });
        }
        #endregion
        #endregion

        #region Product
        #region Get
        public async Task<GetBaseProductsResponse> GetBaseProductsAsync(GetBaseProductsRequest request)
        {
            return await Task.Run(() =>
            {
                GetBaseProductsResponse _response = new GetBaseProductsResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    ExpressionStarter<Product> _predicateProduct = PredicateBuilder.New<Product>(true);
                    if (request.Id.HasValue) { _predicateProduct = _predicateProduct.And(p => p.Id == request.Id); }
                    List<Product> _products = _dbContext.Products.AsExpandable().Where(_predicateProduct).ToList();
                    if (_products.Any()) { _response.BaseObjects = _products.ToBaseProducts(); }
                }
                return _response;
            });
        }
        #endregion

        #region Upsert
        public async Task<UpsertBaseProductResponse> UpsertBaseProductAsync(UpsertBaseProductRequest request)
        {
            return await Task.Run(() =>
            {
                UpsertBaseProductResponse _response = new UpsertBaseProductResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    if (request.BaseObject != null)
                    {
                        try
                        {
                            Product _product = request.BaseObject.ToProduct();
                            UpsertEntity<Product>(request.BaseObject.Id, ref _product, _dbContext);
                            _response.BaseObject = _product.ToBaseProduct();
                        }
                        catch (Exception ex) { AssignStatusData(_response, false, string.Format("Some error occurred during DB interaction. Message is something like : \n{0}", ex.Message)); }
                    }
                    else { AssignStatusData(_response, false, "No entity data recieved to insert/update."); }
                }
                return _response;
            });
        }
        #endregion
        #endregion

        #region Rack
        #region Get
        public async Task<GetBaseRacksResponse> GetBaseRacksAsync(GetBaseRacksRequest request)
        {
            return await Task.Run(() =>
            {
                GetBaseRacksResponse _response = new GetBaseRacksResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    ExpressionStarter<Rack> _predicateRack = PredicateBuilder.New<Rack>(true);
                    if (request.Id.HasValue) { _predicateRack = _predicateRack.And(p => p.Id == request.Id); }
                    List<Rack> _racks = _dbContext.Racks.AsExpandable().Where(_predicateRack).ToList();
                    if (_racks.Any()) { _response.BaseObjects = _racks.ToBaseRacks(); }
                }
                return _response;
            });
        }
        #endregion

        #region Upsert
        public async Task<UpsertBaseRackResponse> UpsertBaseRackAsync(UpsertBaseRackRequest request)
        {
            return await Task.Run(() =>
            {
                UpsertBaseRackResponse _response = new UpsertBaseRackResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    if (request.BaseObject != null)
                    {
                        try
                        {
                            Rack _rack = request.BaseObject.ToRack();
                            UpsertEntity<Rack>(request.BaseObject.Id, ref _rack, _dbContext);
                            _response.BaseObject = _rack.ToBaseRack();
                        }
                        catch (Exception ex) { AssignStatusData(_response, false, string.Format("Some error occurred during DB interaction. Message is something like : \n{0}", ex.Message)); }
                    }
                    else { AssignStatusData(_response, false, "No entity data recieved to insert/update."); }
                }
                return _response;
            });
        }
        #endregion
        #endregion

        #region Route
        #region Get
        public async Task<GetBaseRoutesResponse> GetBaseRoutesAsync(GetBaseRoutesRequest request)
        {
            return await Task.Run(() =>
            {
                GetBaseRoutesResponse _response = new GetBaseRoutesResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    ExpressionStarter<Route> _predicateRoute = PredicateBuilder.New<Route>(true);
                    if (request.Id.HasValue) { _predicateRoute = _predicateRoute.And(p => p.Id == request.Id); }
                    List<Route> _routes = _dbContext.Routes.AsExpandable().Where(_predicateRoute).ToList();
                    if (_routes.Any()) { _response.BaseObjects = _routes.ToBaseRoutes(); }
                }
                return _response;
            });
        }
        #endregion

        #region Upsert
        public async Task<UpsertBaseRouteResponse> UpsertBaseRouteAsync(UpsertBaseRouteRequest request)
        {
            return await Task.Run(() =>
            {
                UpsertBaseRouteResponse _response = new UpsertBaseRouteResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    if (request.BaseObject != null)
                    {
                        try
                        {
                            Route _route = request.BaseObject.ToRoute();
                            UpsertEntity<Route>(request.BaseObject.Id, ref _route, _dbContext);
                            _response.BaseObject = _route.ToBaseRoute();
                        }
                        catch (Exception ex) { AssignStatusData(_response, false, string.Format("Some error occurred during DB interaction. Message is something like : \n{0}", ex.Message)); }
                    }
                    else { AssignStatusData(_response, false, "No entity data recieved to insert/update."); }
                }
                return _response;
            });
        }
        #endregion
        #endregion

        #region Size
        #region Get
        public async Task<GetBaseSizesResponse> GetBaseSizesAsync(GetBaseSizesRequest request)
        {
            return await Task.Run(() =>
            {
                GetBaseSizesResponse _response = new GetBaseSizesResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    ExpressionStarter<Size> _predicateSize = PredicateBuilder.New<Size>(true);
                    if (request.Id.HasValue) { _predicateSize = _predicateSize.And(p => p.Id == request.Id); }
                    List<Size> _sizes = _dbContext.Sizes.AsExpandable().Where(_predicateSize).ToList();
                    if (_sizes.Any()) { _response.BaseObjects = _sizes.ToBaseSizes(); }
                }
                return _response;
            });
        }
        #endregion

        #region Upsert
        public async Task<UpsertBaseSizeResponse> UpsertBaseSizeAsync(UpsertBaseSizeRequest request)
        {
            return await Task.Run(() =>
            {
                UpsertBaseSizeResponse _response = new UpsertBaseSizeResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    if (request.BaseObject != null)
                    {
                        try
                        {
                            Size _size = request.BaseObject.ToSize();
                            UpsertEntity<Size>(request.BaseObject.Id, ref _size, _dbContext);
                            _response.BaseObject = _size.ToBaseSize();
                        }
                        catch (Exception ex) { AssignStatusData(_response, false, string.Format("Some error occurred during DB interaction. Message is something like : \n{0}", ex.Message)); }
                    }
                    else { AssignStatusData(_response, false, "No entity data recieved to insert/update."); }
                }
                return _response;
            });
        }
        #endregion
        #endregion

        #region Unit
        #region Get
        public async Task<GetBaseUnitsResponse> GetBaseUnitsAsync(GetBaseUnitsRequest request)
        {
            return await Task.Run(() =>
            {
                GetBaseUnitsResponse _response = new GetBaseUnitsResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    ExpressionStarter<Unit> _predicateUnit = PredicateBuilder.New<Unit>(true);
                    if (request.Id.HasValue) { _predicateUnit = _predicateUnit.And(p => p.Id == request.Id); }
                    List<Unit> _units = _dbContext.Units.AsExpandable().Where(_predicateUnit).ToList();
                    if (_units.Any()) { _response.BaseObjects = _units.ToBaseUnits(); }
                }
                return _response;
            });
        }
        #endregion

        #region Upsert
        public async Task<UpsertBaseUnitResponse> UpsertBaseUnitAsync(UpsertBaseUnitRequest request)
        {
            return await Task.Run(() =>
            {
                UpsertBaseUnitResponse _response = new UpsertBaseUnitResponse();
                using (AsyncAutomateAccountingEntities _dbContext = new AsyncAutomateAccountingEntities())
                {
                    if (request.BaseObject != null)
                    {
                        try
                        {
                            Unit _unit = request.BaseObject.ToUnit();
                            UpsertEntity<Unit>(request.BaseObject.Id, ref _unit, _dbContext);
                            _response.BaseObject = _unit.ToBaseUnit();
                        }
                        catch (Exception ex) { AssignStatusData(_response, false, string.Format("Some error occurred during DB interaction. Message is something like : \n{0}", ex.Message)); }
                    }
                    else { AssignStatusData(_response, false, "No entity data recieved to insert/update."); }
                }
                return _response;
            });
        }
        #endregion
        #endregion


















    }
}
