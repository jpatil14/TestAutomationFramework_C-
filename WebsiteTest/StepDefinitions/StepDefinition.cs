using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TestAutomationFramework.Base;
using WebsiteTest.Pages;
using TechTalk.SpecFlow.Assist;
using TestAutomationFramework.Helpers;
using NUnit.Framework;

namespace WebsiteTest.StepDefinitions
{
    [Binding]
    public class StepDefinition:BaseStep

    {
        [Given(@"I have navigated to application")]
        public void GivenIHaveNavigatedToApplication()
        {
            CurrentPage = GetInstance<HomePage>();
        }

        [Given(@"I see application opened")]
        public void GivenISeeApplicationOpened()
        {
            CurrentPage.As<HomePage>().CheckIfElementExist();
        }

        [When(@"I click (.*) link")]
        public void WhenIClickLink(string linkName)
        {
            switch (linkName)
            {
                case "login":
                    CurrentPage = GetInstance<HomePage>().ClickLogin();
                    break;
                case "Women":
                    CurrentPage = CurrentPage.As<MyAccountPage>().clickOnWomenMenu();
                    break;
                default:
                    break;
            }

        }

        [When(@"I enter username and password")]
        public void WhenIEnterUsernameAndPassword(Table table)
        {
            var dictionary = DataHelperExtensions.ToDictionary(table);
            CurrentPage.As<LoginPage>().Login(dictionary["UserName"],dictionary["Password"]);
        }

        [When(@"I click login button")]
        public void WhenIClickLoginButton()
        {
            CurrentPage = GetInstance<LoginPage>().ClickLoginBUtton();
        }

        [Then(@"I should be navigated to (.*) page")]
        public void ThenIShouldBeNavigatedTo(string pageName)
        {
            switch (pageName)
            {
                case "My Account":
                    CurrentPage.As<MyAccountPage>().IsPageLoaded();
                    break;
                case "Women Home":
                    CurrentPage.As<WomenPage>().IsPageLoaded();
                    break;
                default:
                    Assert.That(false, "Page is not exist");
                    break;
            }
        }
    }
}
