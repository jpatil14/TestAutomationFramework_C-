using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationFramework.Config;
using TestAutomationFramework.Helpers;

namespace TestAutomationFramework.Base
{
    public abstract class TestInitializeHook:Base
    {

        private readonly BrowserType Browser;

        public TestInitializeHook(BrowserType browser)
        {
            Browser = browser;
        }

        public void IntializeSettings()
        {
            //set settings for framework
            ConfigReader.SetFrameworkSettings();

            //set log
            LogHelpers.CreateLogFile();

            OpenBrowser(Browser);
            LogHelpers.WriteToLogFile("Opened the browser");
        }

        private void OpenBrowser(BrowserType browserType = BrowserType.Chrome)//default case would be chrome
        {
            switch (browserType)
            {
                case BrowserType.InternetExplorer:
                    DriverContext.Driver = new InternetExplorerDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.FireFox:
                    DriverContext.Driver = new FirefoxDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.Chrome:
                    DriverContext.Driver = new ChromeDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;

            }
        }

        public virtual void NavigateSite()
        {
            DriverContext.Browser.GoToUrl(Settings.AUT);
            DriverContext.Driver.Manage().Window.Maximize();
        }

    }
}
