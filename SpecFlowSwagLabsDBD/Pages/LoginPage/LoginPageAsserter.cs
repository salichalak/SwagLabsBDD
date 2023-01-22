using NUnit.Framework;

namespace SpecFlowSwagLabsDBD.Pages.LoginPage
{
    public partial class LoginPage
    {
        public void AssertThatUserIsUnableToLogin()
        {
            Assert.IsTrue(this.ErrorMessageDiv.Displayed, "The error message is not displayed!");
            Assert.IsTrue(this.LoginButton.Displayed, "The login button is not displayed!");
        }
    }
}
