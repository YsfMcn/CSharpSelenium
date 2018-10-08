using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumWebDriver.Core;
using SeleniumWebDriver.Pages.DashboardPage;
using SeleniumWebDriver.Pages.LoginPage;

namespace SeleniumWebDriver.Tests
{
    [TestClass]
    public class LoginPageTests : BaseTest
    {
        [TestCategory("FluxdayTests")]
        [TestMethod]
        public void Test001LoginWithAdminUser()
        {
            
            var loginPage = new LoginPage();
            loginPage.Navigate();

            var adminUser = TestData.TestData.AdminUser;

            loginPage.TypeEmail(adminUser.Email);

            loginPage.TypePassword(adminUser.Password);

            loginPage.PressLoginButton();

           

            var dashboardPage = new DashboardPage();
            var actualResult = dashboardPage.ReadAdminUserLinkText();

            Assert.AreEqual(adminUser.Name, actualResult);
        }

        [TestCategory("LoginPageTests")]
        [TestMethod]
        public void Test002LoginWithLeadUser()
        {
           
            var loginPage = new LoginPage();
            loginPage.Navigate();

         

            var teamLeadUser = TestData.TestData.TeamLeadUser;
            loginPage.TypeEmail(teamLeadUser.Email);
            loginPage.TypePassword(teamLeadUser.Password);
            loginPage.PressLoginButton();
            
         

            var dashboardPage = new DashboardPage();
            var actualResul = dashboardPage.ReadAdminUserLinkText();

            Assert.AreEqual(teamLeadUser.Name, actualResul);
        }

    }
}