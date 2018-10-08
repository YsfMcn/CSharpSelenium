using OpenQA.Selenium;
using System.Collections.Generic;

namespace SeleniumWebDriver.Core
{
    public class BasePageElementMap
    {
        protected IWebDriver Browser;

        public BasePageElementMap()
        {
            Browser = Driver.Browser;
        }

        public IWebElement GetElement(By by)
        {
            return Browser.FindElement(by);
        }

        public IReadOnlyCollection<IWebElement> GetElements(By by)
        {
            return Browser.FindElements(by);
        }
    }
}