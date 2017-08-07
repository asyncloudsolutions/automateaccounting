using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.DataModels
{
    public class BaseSettingModel : CommonAuditDatesModel
    {
        public string SettingsName { get; set; }
        public string Status { get; set; }
    }
}
