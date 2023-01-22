using OpenQA.Selenium;
using SpecFlowSwagLabsBDD.Pages;

namespace SpecFlowSwagLabsDBD.Pages.LoginPage
{
    [Binding]
    public partial class LoginPage : BasePage
    {
        private const string USERNAME = "standard_user";
        private const string PASSWORD = "secret_sauce";

        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        public void login(string username = USERNAME, string password = PASSWORD)
        {
            this.UsernameInput.SendKeys(username);
            this.PasswordInput.SendKeys(password);
            this.LoginButton.Click();
        }
    }
}
