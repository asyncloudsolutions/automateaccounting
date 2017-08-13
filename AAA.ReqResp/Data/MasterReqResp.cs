using AAA.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.ReqResp.Data
{
    #region Master
    #region Get
    public class GetBaseMastersRequest : CommonGetRequest { }

    public class GetBaseMastersResponse : CommonGetResponse<BaseMasterModel> { }
    #endregion

    #region Upsert
    public class UpsertBaseMasterRequest : CommonUpsertRequest<BaseMasterModel> { }

    public class UpsertBaseMasterResponse : CommonUpsertResponse<BaseMasterModel> { }
    #endregion
    #endregion

    #region Currency
    #region Get
    public class GetBaseCurrenciesRequest : CommonGetRequest { }

    public class GetBaseCurrenciesResponse : CommonGetResponse<BaseCurrencyModel> { }
    #endregion

    #region Upsert
    public class UpsertBaseCurrencyRequest : CommonUpsertRequest<BaseCurrencyModel> { }

    public class UpsertBaseCurrencyResponse : CommonUpsertResponse<BaseCurrencyModel> { }
    #endregion
    #endregion

    #region Tax
    #region Get
    public class GetBaseTaxesRequest : CommonGetRequest { }

    public class GetBaseTaxesResponse : CommonGetResponse<BaseTaxModel> { }
    #endregion

    #region Upsert
    public class UpsertBaseTaxRequest : CommonUpsertRequest<BaseTaxModel> { }

    public class UpsertBaseTaxResponse : CommonUpsertResponse<BaseTaxModel> { }
    #endregion
    #endregion

    #region VoucherType
    #region Get
    public class GetBaseVoucherTypesRequest : CommonGetRequest { }

    public class GetBaseVoucherTypesResponse : CommonGetResponse<BaseVoucherTypeModel> { }
    #endregion

    #region Upsert
    public class UpsertBaseVoucherTypeRequest : CommonUpsertRequest<BaseVoucherTypeModel> { }

    public class UpsertBaseVoucherTypeResponse : CommonUpsertResponse<BaseVoucherTypeModel> { }
    #endregion
    #endregion

    #region AccountGroup
    #region Get
    public class GetBaseAccountGroupsRequest : CommonGetRequest { }

    public class GetBaseAccountGroupsResponse : CommonGetResponse<BaseAccountGroupModel> { }
    #endregion

    #region Upsert
    public class UpsertBaseAccountGroupRequest : CommonUpsertRequest<BaseAccountGroupModel> { }

    public class UpsertBaseAccountGroupResponse : CommonUpsertResponse<BaseAccountGroupModel> { }
    #endregion
    #endregion

    #region AccountLedger
    #region Get
    public class GetBaseAccountLedgersRequest : CommonGetRequest { }

    public class GetBaseAccountLedgersResponse : CommonGetResponse<BaseAccountLedgerModel> { }
    #endregion

    #region Upsert
    public class UpsertBaseAccountLedgerRequest : CommonUpsertRequest<BaseAccountLedgerModel> { }

    public class UpsertBaseAccountLedgerResponse : CommonUpsertResponse<BaseAccountLedgerModel> { }
    #endregion
    #endregion

    #region AdditionalCost
    #region Get
    public class GetBaseAdditionalCostsRequest : CommonGetRequest { }

    public class GetBaseAdditionalCostsResponse : CommonGetResponse<BaseAdditionalCostModel> { }
    #endregion

    #region Upsert
    public class UpsertBaseAdditionalCostRequest : CommonUpsertRequest<BaseAdditionalCostModel> { }

    public class UpsertBaseAdditionalCostResponse : CommonUpsertResponse<BaseAdditionalCostModel> { }
    #endregion
    #endregion

    #region AdvancePayment
    #region Get
    public class GetBaseAdvancePaymentsRequest : CommonGetRequest { }

    public class GetBaseAdvancePaymentsResponse : CommonGetResponse<BaseAdvancePaymentModel> { }
    #endregion

    #region Upsert
    public class UpsertBaseAdvancePaymentRequest : CommonUpsertRequest<BaseAdvancePaymentModel> { }

    public class UpsertBaseAdvancePaymentResponse : CommonUpsertResponse<BaseAdvancePaymentModel> { }
    #endregion
    #endregion

    #region Area
    #region Get
    public class GetBaseAreasRequest : CommonGetRequest { }

    public class GetBaseAreasResponse : CommonGetResponse<BaseAreaModel> { }
    #endregion

    #region Upsert
    public class UpsertBaseAreaRequest : CommonUpsertRequest<BaseAreaModel> { }

    public class UpsertBaseAreaResponse : CommonUpsertResponse<BaseAreaModel> { }
    #endregion
    #endregion

    #region Batch
    #region Get
    public class GetBaseBatchesRequest : CommonGetRequest { }

    public class GetBaseBatchesResponse : CommonGetResponse<BaseBatchModel> { }
    #endregion

    #region Upsert
    public class UpsertBaseBatchRequest : CommonUpsertRequest<BaseBatchModel> { }

    public class UpsertBaseBatchResponse : CommonUpsertResponse<BaseBatchModel> { }
    #endregion
    #endregion

    #region Brand
    #region Get
    public class GetBaseBrandsRequest : CommonGetRequest { }

    public class GetBaseBrandsResponse : CommonGetResponse<BaseBrandModel> { }
    #endregion

    #region Upsert
    public class UpsertBaseBrandRequest : CommonUpsertRequest<BaseBrandModel> { }

    public class UpsertBaseBrandResponse : CommonUpsertResponse<BaseBrandModel> { }
    #endregion
    #endregion

    #region ExchangeRate
    #region Get
    public class GetBaseExchangeRatesRequest : CommonGetRequest { }

    public class GetBaseExchangeRatesResponse : CommonGetResponse<BaseExchangeRateModel> { }
    #endregion

    #region Upsert
    public class UpsertBaseExchangeRateRequest : CommonUpsertRequest<BaseExchangeRateModel> { }

    public class UpsertBaseExchangeRateResponse : CommonUpsertResponse<BaseExchangeRateModel> { }
    #endregion
    #endregion

    #region Godown
    #region Get
    public class GetBaseGodownsRequest : CommonGetRequest { }

    public class GetBaseGodownsResponse : CommonGetResponse<BaseGodownModel> { }
    #endregion

    #region Upsert
    public class UpsertBaseGodownRequest : CommonUpsertRequest<BaseGodownModel> { }

    public class UpsertBaseGodownResponse : CommonUpsertResponse<BaseGodownModel> { }
    #endregion
    #endregion

    #region ModelNumber
    #region Get
    public class GetBaseModelNumbersRequest : CommonGetRequest { }

    public class GetBaseModelNumbersResponse : CommonGetResponse<BaseModelNumberModel> { }
    #endregion

    #region Upsert
    public class UpsertBaseModelNumberRequest : CommonUpsertRequest<BaseModelNumberModel> { }

    public class UpsertBaseModelNumberResponse : CommonUpsertResponse<BaseModelNumberModel> { }
    #endregion
    #endregion

    #region PricingLevel
    #region Get
    public class GetBasePricingLevelsRequest : CommonGetRequest { }

    public class GetBasePricingLevelsResponse : CommonGetResponse<BasePricingLevelModel> { }
    #endregion

    #region Upsert
    public class UpsertPricingLevelRequest : CommonUpsertRequest<BasePricingLevelModel> { }

    public class UpsertBasePricingLevelResponse : CommonUpsertResponse<BasePricingLevelModel> { }
    #endregion
    #endregion

    #region ProductGroup
    #region Get
    public class GetBaseProductGroupsRequest : CommonGetRequest { }

    public class GetBaseProductGroupsResponse : CommonGetResponse<BaseProductGroupModel> { }
    #endregion

    #region Upsert
    public class UpsertProductGroupRequest : CommonUpsertRequest<BaseProductGroupModel> { }

    public class UpsertProductGroupResponse : CommonUpsertResponse<BaseProductGroupModel> { }
    #endregion
    #endregion

    #region Product
    #region Get
    public class GetBaseProductsRequest : CommonGetRequest { }

    public class GetBaseProductsResponse : CommonGetResponse<BaseProductModel> { }
    #endregion

    #region Upsert
    public class UpsertBaseProductRequest : CommonUpsertRequest<BaseProductModel> { }

    public class UpsertBaseProductResponse : CommonUpsertResponse<BaseProductModel> { }
    #endregion
    #endregion

    #region Rack
    #region Get
    public class GetBaseRacksRequest : CommonGetRequest { }

    public class GetBaseRacksResponse : CommonGetResponse<BaseRackModel> { }
    #endregion

    #region Upsert
    public class UpsertBaseRackRequest : CommonUpsertRequest<BaseRackModel> { }

    public class UpsertBaseRackResponse : CommonUpsertResponse<BaseRackModel> { }
    #endregion
    #endregion

    #region Route
    #region Get
    public class GetBaseRoutesRequest : CommonGetRequest { }

    public class GetBaseRoutesResponse : CommonGetResponse<BaseRouteModel> { }
    #endregion

    #region Upsert
    public class UpsertBaseRouteRequest : CommonUpsertRequest<BaseRouteModel> { }

    public class UpsertBaseRouteResponse : CommonUpsertResponse<BaseRouteModel> { }
    #endregion
    #endregion

    #region Size
    #region Get
    public class GetBaseSizesRequest : CommonGetRequest { }

    public class GetBaseSizesResponse : CommonGetResponse<BaseSizeModel> { }
    #endregion

    #region Upsert
    public class UpsertBaseSizeRequest : CommonUpsertRequest<BaseSizeModel> { }

    public class UpsertBaseSizeResponse : CommonUpsertResponse<BaseSizeModel> { }
    #endregion
    #endregion

    #region Unit
    #region Get
    public class GetBaseUnitsRequest : CommonGetRequest { }

    public class GetBaseUnitsResponse : CommonGetResponse<BaseUnitModel> { }
    #endregion

    #region Upsert
    public class UpsertBaseUnitRequest : CommonUpsertRequest<BaseUnitModel> { }

    public class UpsertBaseUnitResponse : CommonUpsertResponse<BaseUnitModel> { }
    #endregion
    #endregion
}
