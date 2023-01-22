using OpenQA.Selenium;

namespace SpecFlowSwagLabsDBD.Pages.CommonPage
{
    public partial class HomePage
    {
        public IWebElement ExpandMenuButton => this._driver.FindElement(By.Id("react-burger-menu-btn"));

        public IWebElement ShoppingCartLink => this._driver.FindElement(By.ClassName("shopping_cart_link"));

        public IWebElement ProductSortDropdown => this._driver.FindElement(By.ClassName("product_sort_container"));

        public IWebElement MenuOption(string optionTitle) => this._driver.FindElement(By.XPath($"//nav[@class='bm-item-list']//a[text()='{optionTitle}']"));

        public IWebElement CloseMenuButton => this._driver.FindElement(By.Id("react-burger-cross-btn"));

        public IWebElement ProductsGrid => this._driver.FindElement(By.ClassName("inventory_list"));

        public IWebElement OrderOptionsDropdown => this._driver.FindElement(By.ClassName("product_sort_container"));

        public IWebElement ActiveOrderOption => this._driver.FindElement(By.ClassName("active_option"));

        public IWebElement ProductAddToCartButton(string productTitle) => this._driver.FindElement(By.XPath($"//div[@class='pricebar']/button[contains(@data-test, {productTitle})]"));

        public IWebElement CheckOutButton => this._driver.FindElement(By.Id("checkout"));

        public IWebElement FirstNameInput => this._driver.FindElement(By.Id("first-name"));

        public IWebElement LastNameInput => this._driver.FindElement(By.Id("last-name"));

        public IWebElement ZipCodeInput => this._driver.FindElement(By.Id("postal-code"));

        public IWebElement ContinueButton => this._driver.FindElement(By.Id("continue"));

        public IWebElement FinishButton => this._driver.FindElement(By.Id("finish"));

        public IWebElement CheckOutCompletedMessage => this._driver.FindElement(By.XPath("//span[text()='Checkout: Complete!']"));

        public IWebElement PonyExpressLogo => this._driver.FindElement(By.XPath("//img[@alt='Pony Express']"));

        public IWebElement ThankYouMessage => this._driver.FindElement(By.CssSelector("h2.complete-header"));
    }
}
