using SeleniumWebDriver.Core;

namespace SeleniumWebDriver.Pages.HomePage
{
    public class HomePage : BasePage<HomePageElementMap>
    {
        public HomePage(string url = "https://fluxday.io/") : base(url)
        {
        }
    }
}