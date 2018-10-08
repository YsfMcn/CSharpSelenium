using SeleniumWebDriver.TestData.Models;
using SeleniumWebDriver.TestData.Models.Messages;
using SeleniumWebDriver.TestData.Models.User;

using System.Collections.Generic;

namespace SeleniumWebDriver.TestData
{
    public static class TestData
    {
        private static Dictionary<MessagesKeys, string> messages = new Dictionary<MessagesKeys, string>()
        {
            { MessagesKeys.HomePageTitle, "OPENSOURCE TASK & PRODUCTIVITY MANAGEMENT TOOL FOR STARTUPS"}
        };

        public static User AdminUser
        {
            get
            {
                return new User("admin@fluxday.io", "password", "Admin User");
            }
        }

        public static User TeamLeadUser
        {
            get
            {
                return new User("lead@fluxday.io", "password", "Team Lead");
            }
        }

        public static Dictionary<MessagesKeys, string> Messages
        {
            get
            {
                return messages;
            }
        }

        public static string Password
        {
            get
            {
                return "987654321";
            }
        }

        public static Task NewTask
        {
            get
            {
                return new Task("Test Title", "Test Description");
            }
        }
    }
}