using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestAutomationFramework.Base;
using TestAutomationFramework.Extensions;

namespace WebsiteTest.Pages
{
   public class WomenPage:BasePage
    {
      
        [FindsBy(How = How.XPath, Using = "//ul[contains(@class,'product_list grid row')]/li")]
        public IList<IWebElement> WomenProductsList { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[contains(@class,'product_list grid row')]/li//span[contains(text(),'Add to cart')]")]
        public IList<IWebElement> AddToCartButtons { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@title='Women']")]
        public IWebElement womenMenu { get; set; }

        public void IsPageLoaded()
        {
            womenMenu.AssertElementPresent();
        }

        public void addToCartProducts(int itemToBeSelected)
        {
            Actions act = new Actions(DriverContext.Driver);
            for (int i = 1; i <= itemToBeSelected; i++)
            {
                Thread.Sleep(1000);
                act.MoveToElement(WomenProductsList[i - 1]).Build().Perform();
            }
        }
    }
}
