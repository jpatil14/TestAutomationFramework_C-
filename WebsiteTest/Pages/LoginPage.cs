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
    public class LoginPage:BasePage
    {

        [FindsBy(How=How.XPath, Using = "//*[@title='Log in to your customer account']")]    
        public IWebElement loginLink { get; set; }

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement userName { get; set; }

        [FindsBy(How = How.Id, Using = "passwd")]
        public IWebElement passWd { get; set; }

        [FindsBy(How = How.Id, Using = "SubmitLogin")]
        public IWebElement loginButton { get; set; }

       

        public void Login(string uName, string passWord)
        {
            userName.SendKeys(uName);
            passWd.SendKeys(passWord);
            
        }

       /* public WomenPage clickOnWomenMenu()
        {
            womenMenu.Click();
            DriverContext.Driver.WaitForDocumentLoaded();
            return GetInstance<WomenPage>();
        }*/

        public MyAccountPage ClickLoginBUtton()
        {
            loginButton.Click();
            return GetInstance<MyAccountPage>();
        }

        
    }
}
