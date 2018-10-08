using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebDriver.Core;
using SeleniumWebDriver.TestData.Models.Messages;
using System.Threading;

namespace SeleniumWebDriver.Tests
{
    [TestClass]
    public class HomePageTests : BaseTest
    {
        [TestCategory("HomePageTests")]
        [TestMethod]
        public void Test0001NavigateToHomePage()
        {
            Driver.Browser.Navigate().GoToUrl("https://fluxday.io/");
            IWebElement pageTitle = Driver.Browser.FindElement(By.ClassName("name"));
            var actualResult = pageTitle.Text;

            var expectedResult = TestData.TestData.Messages[MessagesKeys.HomePageTitle];
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCategory("HomePageTests")]
        [TestMethod]
        public void Test0002NavigateToLiveDemoLoginPage()
        {
            Driver.Browser.Navigate().GoToUrl("https://fluxday.io/");
            var demoLink = Driver.Browser.FindElement(By.XPath("//a[contains(text(), 'Demo')]"));
            demoLink.Click();
            Thread.Sleep(3000);

            var tryLiveDemo = Driver.Browser.FindElement(By.CssSelector(".text-center.spacer a"));
            tryLiveDemo.Click();
            Thread.Sleep(1000);

            var tabs = Driver.Browser.WindowHandles;
            Driver.Browser.SwitchTo().Window(tabs[tabs.Count - 1]);

            var emailInput = Driver.Browser.FindElement(By.Id("user_email"));

            Assert.IsNotNull(emailInput);
        }
    }
}