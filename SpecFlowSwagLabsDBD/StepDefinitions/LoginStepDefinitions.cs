using OpenQA.Selenium;
using SpecFlowSwagLabsBDD.TestData;
using SpecFlowSwagLabsDBD.Pages.CommonPage;
using SpecFlowSwagLabsDBD.Pages.LoginPage;

namespace SpecFlowSwagLabsBDD.StepDefinitions
{
    [Binding]
    public sealed class LoginStepDefinitions
    {
        private readonly LoginPage _loginPage;
        private readonly HomePage _homePage;

        public LoginStepDefinitions(IWebDriver driver)
        {
            _loginPage = new LoginPage(driver);
            _homePage = new HomePage(driver);
        }

        [Given(@"the user is on the home page")]
        public void GivenTheUserIsOnTheHomePage()
        {
            _loginPage.NavigateToUrl(CommonTestData.BaseUrl);
        }

        [When(@"the user enters valid credentials")]
        public void WhenTheUserEntersValidCredentials()
        {
            _loginPage.login();
        }

        [Then(@"the user is successfully logged in")]
        public void ThenTheUserIsSuccessfullyLoggedIn()
        {
            _homePage.AssertProductsGridIsDisplated();
            _homePage.AssertPageUrl($"{CommonTestData.BaseUrl}inventory.html");
        }

        [When(@"the user enters invalid credentials")]
        public void WhenTheUserEntersInvalidCredentials()
        {
            _loginPage.login(CommonTestData.InvalidUsername, CommonTestData.InvalidPassword);
        }

        [Then(@"the user is not able to log in")]
        public void ThenTheUserIsNotAbleToLogIn()
        {
            _loginPage.AssertPageUrl(CommonTestData.BaseUrl);
            _loginPage.AssertThatUserIsUnableToLogin();
        }
    }
}