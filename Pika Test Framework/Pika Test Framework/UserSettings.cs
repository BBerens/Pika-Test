using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Pika_Test_Framework
{
    public class UserSettings : ApplicationSettingsBase
    {
        [UserScopedSetting()]
        [DefaultSettingValue("")]
        public int preferredBaseline
        {
            get
            {
                return (int)this["preferredBaseline"];
            }
            set
            {
                this["preferredBaseline"] = (int)value;
            }
        }
    }
}
