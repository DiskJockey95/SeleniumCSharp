using OpenQA.Selenium;

namespace SeleniumCoreDemo.Pages
{
    public class HomePage
    {
        public HomePage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        private IWebDriver Driver { get; }

        public IWebElement LinkLogin => Driver.FindElement(By.Id("loginLink"));

        IWebElement LinkEmployeeDetails => Driver.FindElement(By.LinkText("Employee Details"));

        public void ClickLogin()
        {
            LinkLogin.Click();
        }

        public bool IsEmployeeDetailsExist() => LinkEmployeeDetails.Displayed;
    }
}
