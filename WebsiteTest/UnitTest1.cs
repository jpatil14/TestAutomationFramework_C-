using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using TestAutomationFramework.Base;
using TestAutomationFramework.Config;
using TestAutomationFramework.Helpers;
using WebsiteTest.Pages;

namespace WebsiteTest
{
    public class UnitTest1:HookInitialize
    {

        /*

        [TestMethod]
        public void TestMethod1()
        {
            string filePath = Environment.CurrentDirectory.ToString() + "\\TestData\\loginData.xlsx";
            ExcelHelper.PopulateIntoCollection(filePath);
            
            DriverContext.Browser.GoToUrl(Settings.AUT);

            CurrentPage = GetInstance<LoginPage>();
            CurrentPage.As<LoginPage>().CheckIfElementExist();
            CurrentPage.As<LoginPage>().Login(ExcelHelper.ReadData(2,"Column0"), ExcelHelper.ReadData(2, "Column1"));
            CurrentPage=CurrentPage.As<LoginPage>().clickOnWomenMenu();
            CurrentPage.As<WomenPage>().addToCartProducts(2);
            DriverContext.Driver.Quit();
        }

     */
    }
}
