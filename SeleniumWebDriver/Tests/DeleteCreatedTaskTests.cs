
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumWebDriver.Core;
using SeleniumWebDriver.Pages.DashboardPage;
using SeleniumWebDriver.Pages.LoginPage;
using System.Threading;

namespace SeleniumWebDriver.Tests
{
    [TestClass]
    public class DeleteCreatedTaskTests : BaseTest
    {
        [TestCategory("FluxdayTests")]
        [TestMethod]
        public void Test005DeleteCreatedTask()
        {
            var loginPage = new LoginPage();
            loginPage.Navigate();

            var teamLeadUser = TestData.TestData.TeamLeadUser;
            loginPage.TypeEmail(teamLeadUser.Email);
            loginPage.TypePassword(teamLeadUser.Password);
            loginPage.PressLoginButton();

            var dashboardPage = new DashboardPage();
            dashboardPage.Navigate();
            dashboardPage.PressTaskIkonButton();
            
            dashboardPage.PressWheelIkonButton();
            Thread.Sleep(2000);
            dashboardPage.PressDeleteButton();
            

            var dashboardPageCheck = new DashboardPage();
            dashboardPage.Navigate();

            var tasks = dashboardPageCheck.ReadTaskItems();

            Assert.AreEqual(0, tasks.Count);
        }
    }
}
