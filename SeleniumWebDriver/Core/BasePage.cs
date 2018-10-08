namespace SeleniumWebDriver.Core
{
    public class BasePage<TM> : IPage where TM : BasePageElementMap, new()
    {
        public BasePage(string url)
        {
            Url = url;
        }

        public string Url { get; set; }

        protected TM Map
        {
            get
            {
                return new TM();
            }
        }

        public void Navigate()
        {
            Driver.Browser.Navigate().GoToUrl(Url);
        }
    }
}