using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TestAutomationFramework.Base;

namespace WebsiteTest
{
    [Binding]
    public class HookInitialize: TestInitializeHook
    {
        public HookInitialize():base(BrowserType.Chrome)
        {
            IntializeSettings();
            NavigateSite();
        }

        [BeforeFeature]
        public static void TestStart()
        {
            HookInitialize hookInit = new HookInitialize();
        }

        [AfterFeature]
        public static void TearDown()
        {
            DriverContext.Driver.Quit();
        }

    }
}
