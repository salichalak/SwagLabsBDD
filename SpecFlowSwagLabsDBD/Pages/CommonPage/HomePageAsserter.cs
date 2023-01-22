using NUnit.Framework;

namespace SpecFlowSwagLabsDBD.Pages.CommonPage
{
    public partial class HomePage
    {
        public void AssertProductsGridIsDisplated()
        {
            Assert.IsTrue(this.ProductsGrid.Displayed, "The products grid is not displayed!");
        }

        public void AssertThatCorrectOrderingIsApplied(string order)
        {
            string currentOrder = this.ActiveOrderOption.Text;
            Assert.AreEqual(order.ToLower(), currentOrder.ToLower(), "The provided order is not applied!");
        }

        public void AssertThatTheOrderWasCompleted()
        {
            Assert.IsTrue(this.CheckOutCompletedMessage.Displayed, "The check out completed message is missing!");
            Assert.IsTrue(this.ThankYouMessage.Displayed, "The thank you message is missing!");
        }
    }
}
