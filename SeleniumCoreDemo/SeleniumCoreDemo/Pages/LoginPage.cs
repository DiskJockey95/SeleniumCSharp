using OpenQA.Selenium;

namespace SeleniumCoreDemo.Pages
{
    class LoginPage
    {
        public LoginPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; }

        IWebElement TextUserName => Driver.FindElement(By.Id("UserName"));

        IWebElement TextPassword => Driver.FindElement(By.Id("Password"));

        IWebElement ButtonLogin => Driver.FindElement(By.XPath("//input[@value='Log in']"));

        public void Login(string userName, string password)
        {
            TextUserName.SendKeys(userName);
            TextPassword.SendKeys(password);
            ButtonLogin.Submit();
        }

        public bool IsbuttonLoginExist => ButtonLogin.Displayed;
    }
}
