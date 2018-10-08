using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumWebDriver.Core;
using SeleniumWebDriver.Pages.CreateTaskPage;
using SeleniumWebDriver.Pages.DashboardPage;
using SeleniumWebDriver.Pages.LoginPage;




namespace SeleniumWebDriver.Tests
{
    [TestClass]
    public class CreateNewTaskTests : BaseTest
    {
        [TestCategory("FluxdayTests")]
        [TestMethod]
        public void Test004CreateNewTask()
        {
            var loginPage = new LoginPage();
            loginPage.Navigate();

            var teamLeadUser = TestData.TestData.TeamLeadUser;
            loginPage.TypeEmail(teamLeadUser.Email);
            loginPage.TypePassword(teamLeadUser.Password);
            loginPage.PressLoginButton();


            var createTaskPage = new CreateTaskPage();
            createTaskPage.Navigate();

            var newTask = TestData.TestData.NewTask;
            createTaskPage.TypeTitle(newTask.Title);
            createTaskPage.TypeDescription(newTask.Description);
            createTaskPage.PressCreateTaskButton();

            var dashboardPage = new DashboardPage();
            dashboardPage.Navigate();

            var actualResul = dashboardPage.ReadTaskTitleText();

            Assert.AreEqual(newTask.Title, actualResul);
        }

    }
}
