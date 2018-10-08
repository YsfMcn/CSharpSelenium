
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumWebDriver.Core;
using SeleniumWebDriver.Pages.DashboardPage;
using SeleniumWebDriver.Pages.LoginPage;
using SeleniumWebDriver.Pages.PassworChangePage;

namespace SeleniumWebDriver.Tests
{
    [TestClass]
    public class ChangingPasswordTests : BaseTest
    {
        [TestCategory("FluxdayTests")]
        [TestMethod]
        public void Test003ChangePasswordAsATeamLead()
        {
            var loginPage = new LoginPage();
            loginPage.Navigate();

            var teamLeadUser = TestData.TestData.TeamLeadUser;
            loginPage.TypeEmail(teamLeadUser.Email);
            loginPage.TypePassword(teamLeadUser.Password);
            loginPage.PressLoginButton();

            
            var passwordChangePage = new PasswordChangePage();
            passwordChangePage.Navigate();

            var temporaryPassword = TestData.TestData.Password;
            passwordChangePage.TypePassword(temporaryPassword);
            passwordChangePage.TypeConfirmPassword(temporaryPassword);
            passwordChangePage.PressSaveButton();


            var loginPageWithNewPass = new LoginPage();
            loginPage.Navigate();

            var teamLeadUserWithNewPass = TestData.TestData.TeamLeadUser;
            loginPage.TypeEmail(teamLeadUser.Email);
            loginPage.TypePassword(temporaryPassword);
            loginPage.PressLoginButton();


            var dashboardPage = new DashboardPage();
           
            var actualResul = dashboardPage.ReadAdminUserLinkText();

            var passwordChangePageBack = new PasswordChangePage();
            passwordChangePageBack.Navigate();

          
            passwordChangePageBack.TypePassword(teamLeadUser.Password);
            passwordChangePageBack.TypeConfirmPassword(teamLeadUser.Password);
            passwordChangePageBack.PressSaveButton();

            Assert.AreEqual(teamLeadUser.Name, actualResul);
        }

    }
}
