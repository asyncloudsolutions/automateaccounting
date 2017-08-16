using AAA.ReqResp;
using AAA.ReqResp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.DataProviders
{
    public interface IMasterProvider
    {
        #region Master
        #region Get
        Task<GetBaseMastersRequest> GetBaseMastersAsync(GetBaseMastersRequest request);
        #endregion

        #region Upsert
        Task<UpsertBaseMasterResponse> UpsertBaseMasterAsync(UpsertBaseMasterRequest request);
        #endregion
        #endregion

        #region Currency
        #region Get
        Task<GetBaseCurrenciesResponse> GetBaseCurrenciesAsync(GetBaseCurrenciesRequest request);
        #endregion

        #region Upsert
        Task<UpsertBaseCurrencyResponse> UpsertBaseCurrencyAsync(UpsertBaseCurrencyRequest request);
        #endregion
        #endregion

       
        #region Tax
        #region Get
        Task<GetBaseTaxesResponse> GetBaseTaxesAsync(GetBaseTaxesRequest request);
        #endregion

        #region Upsert
        Task<UpsertBaseTaxResponse> UpsertBaseTaxAsync(UpsertBaseTaxRequest request);
        #endregion
        #endregion

        
        #region VoucherType
        #region Get
        Task<GetBaseVoucherTypesResponse> GetBaseVoucherTypesAsync(GetBaseVoucherTypesRequest request);
        #endregion

        #region Upsert
        Task<UpsertBaseVoucherTypeResponse> UpsertBaseVoucherTypeAsync(UpsertBaseVoucherTypeRequest request);
        #endregion
        #endregion

        
        #region AccountGroup
        #region Get
        Task<GetBaseAccountGroupsResponse> GetBaseAccountGroupsAsync(GetBaseAccountGroupsRequest request);
        #endregion

        #region Upsert
        Task<UpsertBaseAccountGroupResponse> UpsertBaseAccountGroupAsync(UpsertBaseAccountGroupRequest request);
        #endregion
        #endregion

        
        #region AccountLedger
        #region Get
        Task<GetBaseAccountLedgersResponse> GetBaseAccountLedgersAsync(GetBaseAccountLedgersRequest request);
        #endregion

        #region Upsert
        Task<UpsertBaseAccountLedgerResponse> UpsertBaseAccountLedgerAsync(UpsertBaseAccountLedgerRequest request);
        #endregion
        #endregion

        
        #region AdditionalCost
        #region Get
        Task<GetBaseAdditionalCostsResponse> GetBaseAdditionalCostsAsync(GetBaseAdditionalCostsRequest request);
        #endregion

        #region Upsert
        Task<UpsertBaseAdditionalCostResponse> UpsertBaseAdditionalCostAsync(UpsertBaseAdditionalCostRequest request);
        #endregion
        #endregion

        
        #region AdvancePayment
        #region Get
        Task<GetBaseAdvancePaymentsResponse> GetBaseAdvancePaymentsAsync(GetBaseAdvancePaymentsRequest request);
        #endregion

        #region Upsert
        Task<UpsertBaseAdvancePaymentResponse> UpsertBaseAdvancePaymentAsync(UpsertBaseAdvancePaymentRequest request);
        #endregion
        #endregion

        
        #region Area
        #region Get
        Task<GetBaseAreasResponse> GetBaseAreasAsync(GetBaseAreasRequest request);
        #endregion

        #region Upsert
        Task<UpsertBaseAreaResponse> UpsertBaseAreaAsync(UpsertBaseAreaRequest request);
        #endregion
        #endregion

        
        #region  Batch
        #region Get
        Task<GetBaseBatchesResponse> GetBaseBatchesAsync(GetBaseBatchesRequestrequest);
        #endregion

        #region Upsert
        Task<UpsertBaseBatchResponse> UpsertBaseBatchAsync(UpsertBaseBatchRequest request);
        #endregion
        #endregion

        
        #region Brand
        #region Get
        Task<GetBaseBrandsResponse> GetBaseBrandsAsync(GetBaseBrandsRequest request);
        #endregion

        #region UpsertBrandResponse> UpsertBaseBrandAsync(UpsertBaseBrandRequest request);
        #endregion
        #endregion

        
        #region ExchangeRate
        #region Get
        Task<GetBaseExchangeRatesResponse> GetBaseExchangeRatesAsync(GetBaseExchangeRatesRequest request);
        #endregion

        #region Upsert
        Task<UpsertBaseExchangeRateResponse> UpsertBaseExchangeRateAsync(UpsertBaseExchangeRateRequest request);
        #endregion
        #endregion

        
        #region Godown
        #region Get
        Task<GetBaseGodownsResponse> GetBaseGodownsAsync(GetBaseGodownsRequest request);
        #endregion

        #region Upsert
        Task<UpsertBaseGodownResponse> UpsertBaseGodownAsync(UpsertBaseGodownRequest request);
        #endregion
        #endregion

        
        #region ModelNumber
        #region Get
        Task<GetBaseModelNumbersResponse> GetBaseModelNumbersAsync(GetBaseModelNumbersRequest request);
        #endregion

        #region Upsert
        Task<UpsertBaseModelNumberResponse> UpsertBaseModelNumberAsync(UpsertBaseModelNumberRequest request);
        #endregion
        #endregion

        
        #region PricingLevel
        #region Get
        Task<GetBasePricingLevelsResponse> GetBasePricingLevelsAsync(GetBasePricingLevelsRequest request);
        #endregion

        #region Upsert
        Task<UpsertBasePricingLevelResponse> UpsertBasePricingLevelAsync(UpsertBasePricingLevelRequest request);
        #endregion
        #endregion

        
        #region ProductGroup
        #region Get
        Task<GetBaseProductGroupsResponse> GetBaseProductGroupsAsync(GetBaseProductGroupsRequest request);
        #endregion

        #region Upsert
        Task<UpsertBaseProductGroupResponse> UpsertBaseProductGroupAsync(UpsertBaseProductGroupRequest request);
        #endregion
        #endregion

        
        #region Product
        #region Get
        Task<GetBaseProductsResponse> GetBaseProductsAsync(GetBaseProductsRequest request);
        #endregion

        #region Upsert
        Task<UpsertBaseProductResponse> UpsertBaseProductAsync(UpsertBaseProductRequest request);
        #endregion
        #endregion

        
        #region Rack
        #region Get
        Task<GetBaseRacksResponse> GetBaseRacksAsync(GetBaseRacksRequest request);
        #endregion

        #region Upsert
        Task<UpsertBaseRackResponse> UpsertBaseRackAsync(UpsertBaseRackRequest request);
        #endregion
        #endregion

        
        #region Route
        #region Get
        Task<GetBaseRoutesResponse> GetBaseRoutesAsync(GetBaseRoutesRequest request);
        #endregion

        #region Upsert
        Task<UpsertBaseRouteResponse> UpsertBaseRouteAsync(UpsertBaseRouteRequest request);
        #endregion
        #endregion

        
        #region Size
        #region Get
        Task<GetBaseSizesResponse> GetBaseSizesAsync(GetBaseSizesRequest request);
        #endregion

        #region Upsert
        Task<UpsertBaseSizeResponse> UpsertBaseSizeAsync(UpsertBaseSizeRequest request);
        #endregion
        #endregion

        
        #region Unit
        #region Get
        Task<GetBaseUnitsResponse> GetBaseUnitsAsync(GetBaseUnitsRequest request);
        #endregion

        #region Upsert
        Task<UpsertBaseUnitResponse> UpsertBaseUnitAsync(UpsertBaseUnitRequest request);
        #endregion
        #endregion
    }
}
