using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationFramework.Base;
using TestAutomationFramework.Extensions;

namespace WebsiteTest.Pages
{
    public class MyAccountPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//h1[contains(text(),'My account')]")]
        public IWebElement myAccountLabel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@title='Women']")]
        public IWebElement womenMenu { get; set; }

        public WomenPage clickOnWomenMenu()
        {
            womenMenu.Click();
            return GetInstance<WomenPage>();
        }

        public void IsPageLoaded()
        {
            myAccountLabel.AssertElementPresent();
        }
    }
    
    
}
