using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomationFramework.ConfigElement
{
    public class FrameworkElement:ConfigurationElement
    {
        [ConfigurationProperty("name", IsRequired =true)]
        public string Name
        {
            get
            {
                return (string)base["name"];
            }
        }

        [ConfigurationProperty("aut", IsRequired = true)]
        public string AUT
        {
            get
            {
                return (string)base["aut"];
            }
        }

        [ConfigurationProperty("browser", IsRequired = true)]
        public string Browser
        {
            get
            {
                return (string)base["browser"];
            }
        }

    }
}
