using OpenQA.Selenium;

namespace SpecFlowSwagLabsDBD.Pages.LoginPage
{
    public partial class LoginPage
    {
        public IWebElement UsernameInput => this._driver.FindElement(By.Id("user-name"));

        public IWebElement PasswordInput => this._driver.FindElement(By.Id("password"));

        public IWebElement LoginButton => this._driver.FindElement(By.Id("login-button"));

        public IWebElement ErrorMessageDiv => this._driver.FindElement(By.XPath("//h3[@data-test='error']"));
    }
}
