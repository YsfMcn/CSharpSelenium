using OpenQA.Selenium;
using SeleniumWebDriver.Core;
using System.Collections.Generic;

namespace SeleniumWebDriver.Pages.DashboardPage
{
    public class DashboardPage : BasePage<DashboardPageElementMap>
    {
        public DashboardPage(string url = "https://app.fluxday.io/") : base(url)
        {
        }

        internal string ReadAdminUserLinkText()
        {
            return Map.AdminUserLink.Text;
        }

        internal void PressTeamLeadButton()
        {
            Map.TeamLeadButton.Click();
        }

        internal string ReadTaskTitleText()
        {
            return Map.TaskTitle.Text;
        }

        internal void PressTaskIkonButton()
        {
            Map.TaskIkonButton.Click();
        }

        internal void PressWheelIkonButton()
        {
            Map.WheelIkonButton.Click();
        }

        internal void PressDeleteButton()
        {
            Map.DeleteButton.Click();
        }

        internal IReadOnlyCollection<IWebElement> ReadTaskItems()
        {
            return Map.TaskTitles;
        }
    }
}