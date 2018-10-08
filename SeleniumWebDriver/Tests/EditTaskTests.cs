using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumWebDriver.Core;
using SeleniumWebDriver.Pages.LoginPage;

namespace SeleniumWebDriver.Tests
{
    [TestClass]
    public class EditTaskTests : BaseTest
    {
        [TestCategory("FluxdayTests")]
        [TestMethod]
        public void Test006EditTask()
        {
            var loginPage = new LoginPage();
            loginPage.Navigate();

            var teamLeadUser = TestData.TestData.TeamLeadUser;
            loginPage.TypeEmail(teamLeadUser.Email);
            loginPage.TypePassword(teamLeadUser.Password);
            loginPage.PressLoginButton();

        


        }

    }
}
