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
    public class HomePage:BasePage
    {
        [FindsBy(How = How.XPath, Using = "//*[@title='Log in to your customer account']")]
        public IWebElement loginLink { get; set; }

        public LoginPage ClickLogin()
        {
            loginLink.Click();
            return GetInstance<LoginPage>();
        }

        internal void CheckIfElementExist()
        {
            loginLink.AssertElementPresent();
        }
    }
}
