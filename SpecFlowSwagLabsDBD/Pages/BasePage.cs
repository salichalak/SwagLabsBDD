using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SpecFlowSwagLabsBDD.TestData;

namespace SpecFlowSwagLabsBDD.Pages
{
    [Binding]
    public abstract class BasePage
    {
        protected readonly IWebDriver _driver;
        protected readonly WebDriverWait wait;

        protected BasePage(IWebDriver driver)
        {
            _driver = driver;
            wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));

        }

        public void NavigateToUrl(string url = CommonTestData.BaseUrl)
        {
            _driver?.Navigate().GoToUrl(url);
        }

        public void AssertPageTitle(string pageTitle)
        {
            Assert.AreEqual(pageTitle, _driver.Title, "The page's title is not the same as expected!");
        }

        public void AssertPageUrl(string url)
        {
            Assert.AreEqual(url, _driver.Url, "The page's url is not the same as expected!");
        }
    }
}
