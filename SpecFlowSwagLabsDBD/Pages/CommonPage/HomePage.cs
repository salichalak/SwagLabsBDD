using AngleSharp.Css.Dom;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SpecFlowSwagLabsBDD.Pages;
using SpecFlowSwagLabsBDD.TestData;

namespace SpecFlowSwagLabsDBD.Pages.CommonPage
{
    public partial class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public void SelectMenuOption(string option)
        {
            this.ExpandMenuButton.Click();
            this.MenuOption(option).Click();
        }

        public void SelectOrder(string order)
        {
            SelectElement orderDropdown = new SelectElement(this.OrderOptionsDropdown);
            if (!this.ActiveOrderOption.Text.Contains(order))
            {
                orderDropdown.SelectByText(order);
            }
        }

        public void AddProductToCart(string productTitle)
        {
            string parsedProductTitle = productTitle.ToLower().Replace(" ", "-");
            this.ProductAddToCartButton(parsedProductTitle).Click();
        }

        public void NavigateToYourCartPage()
        {
            this.ShoppingCartLink.Click();
        }

        public void ProceedCheckout()
        {
            this.CheckOutButton.Click();
        }

        public void FillUserData()
        {
            this.FirstNameInput.SendKeys(CommonTestData.FirstName);
            this.LastNameInput.SendKeys(CommonTestData.LastName);
            this.ZipCodeInput.SendKeys(CommonTestData.ZipCode);
        }

        public void ContinuePurchase()
        {
            this.ContinueButton.Click();
        }

        public void FinishOrder()
        {
            this.FinishButton.Click();
        }
    }
}
