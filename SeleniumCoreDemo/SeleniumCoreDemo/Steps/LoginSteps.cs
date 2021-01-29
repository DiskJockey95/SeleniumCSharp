using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCoreDemo.Pages;
using TechTalk.SpecFlow;

namespace SeleniumCoreDemo.Features
{
    [Binding]
    public class LoginSteps
    {
        IWebDriver webDriver;
        HomePage homePage;
        LoginPage loginPage;

        [Given(@"I am on the Eaapp Page")]
        public void GivenIAmOnTheEaappPage()
        {
            webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("http://eaapp.somee.com/");
            webDriver.Manage().Window.Maximize();
        }

        [When(@"I click login")]
        public void WhenIClickLogin()
        {
            homePage = new HomePage(webDriver);
            homePage.ClickLogin();
        }

        [When(@"I enter the login credendtials")]
        public void WhenIEnterTheLoginCredendtials()
        {
            loginPage = new LoginPage(webDriver);
            loginPage.Login("admin", "password");
        }

        [Then(@"I should see the employee details link")]
        public void ThenIShouldSeeTheEmployeeDetailsLink()
        {
            Assert.That(homePage.IsEmployeeDetailsExist, Is.True);
            webDriver.Quit();
        }

        [When(@"I enter invalid login credendtials")]
        public void WhenIEnterInvalidLoginCredendtials()
        {
            loginPage = new LoginPage(webDriver);
            loginPage.Login("user", "pass");
        }

        [Then(@"I should not see the employee details link")]
        public void ThenIShouldNotSeeTheEmployeeDetailsLink()
        {
            Assert.That(loginPage.IsbuttonLoginExist, Is.True);
            webDriver.Quit();
        }
    }
}
