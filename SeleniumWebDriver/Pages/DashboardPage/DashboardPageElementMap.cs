using OpenQA.Selenium;
using SeleniumWebDriver.Core;
using System.Collections.Generic;

namespace SeleniumWebDriver.Pages.DashboardPage
{
    public class DashboardPageElementMap : BasePageElementMap
    {
        public IWebElement AdminUserLink
        {
            get
            {
                return GetElement(By.XPath(@"/html/body/div[2]/div[1]/ul[3]/li[1]/a"));
            }
        }

        public IWebElement TeamLeadButton
        {
            get
            {
                return GetElement(By.XPath(@"/html/body/div[2]/div[1]/ul[3]/li[1]/a"));
            }
        }
        public IWebElement TaskTitle
        {
            get
            {
                return GetElement(By.XPath(@"//*[@id='pane3']/div[2]/dl/dd[1]/a/li[1]"));
            }
        }

        public IWebElement TaskIkonButton
        {
            get
            {
                return GetElement(By.XPath(@"//*[@id='pane3']/div[2]/dl/dd/a/li[1]/div/div"));
            }
        }

        public IWebElement WheelIkonButton
        {
            get
            {
                return GetElement(By.XPath(@"//*[@id='panel1']/div/div[1]/div[1]/div/a[2]/div"));
            }
        }

        public IWebElement DeleteButton
        {
            get
            {
                return GetElement(By.XPath(@"//a[contains(text(),'Delete')]"));

               
            }
        }

        public IReadOnlyCollection<IWebElement> TaskTitles
        {
            get
            {
                return GetElements(By.CssSelector(@"li.task-name"));
            }
        }
    }
}