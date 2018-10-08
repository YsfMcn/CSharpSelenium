

using OpenQA.Selenium;
using SeleniumWebDriver.Core;

namespace SeleniumWebDriver.Pages.PassworChangePage
{
    public class PasswordChangePageElementMap : BasePageElementMap
    {

        public IWebElement SaveButton
        {
            get
            {
                return GetElement(By.XPath(@"//*[@id='edit_user_12']/div[3]/div[2]/input"));
            }
        }
        public IWebElement PasswordInput
        {
            get
            {
                return GetElement(By.CssSelector("#user_password"));
            }
        }

        public IWebElement ConfirmPasswordInput
        {
            get
            {
                return GetElement(By.CssSelector("#user_password_confirmation"));
            }
        }
    }
}
