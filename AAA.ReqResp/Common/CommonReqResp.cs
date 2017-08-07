using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.ReqResp
{
    #region Get
    public class CommonGetRequest
    {
        public int? Id { get; set; }
    }

    public class CommonGetResponse<T> where T : class, new()
    {
        public CommonGetResponse()
        {
            BaseObjects = new List<T>();
        }
        public IList<T> BaseObjects { get; set; }
    }
    #endregion

    #region Upsert
    public class CommonBaseObject<T> where T : class
    {
        public T BaseObject { get; set; }
    }

    public class CommonUpsertRequest<T> : CommonBaseObject<T> where T : class { }

    public class CommonUpsertResponse<T> : CommonBaseObject<T> where T : class
    {
        public CommonUpsertResponse()
        {
            Status = true;
            StatusMessage = "Task completed successfully.";
        }
        public bool Status { get; set; }
        public string StatusMessage { get; set; }
    }
    #endregion
}
