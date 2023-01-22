using OpenQA.Selenium;
using SpecFlowSwagLabsBDD.TestData;
using SpecFlowSwagLabsDBD.Pages.CommonPage;

namespace SpecFlowSwagLabsBDD.StepDefinitions
{
    [Binding]
    public class HomePageStepDefinitions
    {
        private readonly HomePage _homePage;

        public HomePageStepDefinitions(IWebDriver driver)
        {
            _homePage = new HomePage(driver);
        }

        [When(@"the user selects (.*) from the filter drop down")]
        public void WhenTheUserSelectsNameZToAFromTheFilterDropDown(string order)
        {
            _homePage.SelectOrder(order);
        }

        [Then(@"the results are sorted correctly by (.*)")]
        public void ThenTheResultsAreSortedCorrectly(string order)
        {
            _homePage.AssertThatCorrectOrderingIsApplied(order);
        }

        [When(@"the user select (.*) from the menu options")]
        public void WhenTheUserSelectFromTheMenuOptions(string option)
        {
            _homePage.SelectMenuOption(option);
        }

        [Then(@"the user is redirected to the official SauceLabs website")]
        public void ThenTheUserIsRedirectedToTheOfficialSauceLabsWebsite()
        {
            _homePage.AssertPageUrl(CommonTestData.SauceLabsPageUrl);
            _homePage.AssertPageTitle(CommonTestData.SauceLabsPageTitle);
        }

        [Given(@"the user adds a (.*) product to the cart")]
        public void GivenTheUserAddsASauceLabsBackpackProductToTheCart(string productTitle)
        {
            _homePage.AddProductToCart(productTitle);
        }

        [Given(@"the user navigates to Your Cart page")]
        public void GivenTheUserNavigatesToYourCartPage()
        {
            _homePage.NavigateToYourCartPage();
        }

        [Given(@"the user proceeds with the checkout")]
        public void GivenTheUserProceedsWithTheCheckout()
        {
            _homePage.ProceedCheckout();
        }

        [When(@"the user enters the mandatory personal info")]
        public void WhenTheUserEntersTheMandatoryPersonalInfo()
        {
            _homePage.FillUserData();
        }

        [When(@"the user submits the form")]
        public void WhenTheUserSubmitsTheForm()
        {
            _homePage.ContinuePurchase();
        }

        [When(@"the user finishes the order")]
        public void WhenTheUserFinishesTheOrder()
        {
            _homePage.FinishOrder();
        }

        [Then(@"the product is purchased and the checkout is completed")]
        public void ThenTheProductIsPurchasedAndTheCheckoutIsCompleted()
        {
            _homePage.AssertPageUrl($"{CommonTestData.BaseUrl}checkout-complete.html");
            _homePage.AssertThatTheOrderWasCompleted();
        }
    }
}
