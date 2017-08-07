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
}
