using OpenQA.Selenium;
using SeleniumWebDriver.Core;



namespace SeleniumWebDriver.Pages.CreateTaskPage
{
    public class CreateTaskPageElementMap : BasePageElementMap
    {
        public IWebElement TitleInput
        {
            get
            {
                return GetElement(By.CssSelector("#task_name"));
            }
        }

        public IWebElement DescriptionInput
        {
            get
            {
                return GetElement(By.CssSelector("#task_description"));
            }
        }

        public IWebElement CreateTaskButton
        {
            get
            {
                return GetElement(By.XPath(@"//*[@id='new_task']/div[3]/div[2]/input"));
            }
        }

    }
}
