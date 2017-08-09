using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.DataModels
{
    public class BaseRouteModel : CommonAuditDatesModel
    {
        public string RouteName { get; set; }
        public int AreaId { get; set; }
        public string Narration { get; set; }
    }
}
