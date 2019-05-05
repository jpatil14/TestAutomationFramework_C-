using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Xml.XPath;
using System.IO;
using TestAutomationFramework.ConfigElement;

namespace TestAutomationFramework.Config
{
    public class ConfigReader
    {
        public static void SetFrameworkSettings()
        {
            //XPathItem aut;
            //XPathItem browserType;
            //XPathItem timeout;

            //string strFileName = "C:\\Users\\Minal\\Desktop\\TestAutomationFramework\\TestAutomationFramework\\Config\\GlobalConfig.xml";
            //FileStream stream = new FileStream(strFileName, FileMode.Open);
            //XPathDocument doc = new XPathDocument(stream);
            //XPathNavigator navigator = doc.CreateNavigator();

            //aut = navigator.SelectSingleNode("TestAutomationFramework/RunSettings/AUT");
            //browserType = navigator.SelectSingleNode("TestAutomationFramework/RunSettings/Browser");
            //timeout= navigator.SelectSingleNode("TestAutomationFramework/RunSettings/Timeout");
            Settings.AUT = TestConfiguration.Settings.TestSettings["staging"].AUT;
            //Settings.Timeout = TestConfiguration.Settings.TestSettings["time"].AUT;


        }
    }
}
