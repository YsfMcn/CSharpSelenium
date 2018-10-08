

using SeleniumWebDriver.Core;

namespace SeleniumWebDriver.Pages.PassworChangePage
{
    public class PasswordChangePage : BasePage<PasswordChangePageElementMap>
    {
        public PasswordChangePage(string url = "https://app.fluxday.io/users/change_password#pane3") : base(url)
        {
        }

        internal void TypePassword(string password)
        {
            var passwordInput = Map.PasswordInput;
            passwordInput.Click();
            passwordInput.Clear();
            passwordInput.SendKeys(password);
        }

        internal void TypeConfirmPassword(string password)
        {
            var ConfirmPasswordInput = Map.ConfirmPasswordInput;
            ConfirmPasswordInput.Click();
            ConfirmPasswordInput.Clear();
            ConfirmPasswordInput.SendKeys(password);
        }

        internal void PressSaveButton()
        {
            Map.SaveButton.Click();
        }
    }
}
