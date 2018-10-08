using SeleniumWebDriver.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriver.Pages.CreateTaskPage
{
    public class CreateTaskPage : BasePage<CreateTaskPageElementMap>
    {
        public CreateTaskPage(string url = "https://app.fluxday.io/tasks/new#pane3") : base(url)
        {
        }

        internal void TypeTitle(string title)
        {
            var titleInput = Map.TitleInput;
            titleInput.Click();
            titleInput.Clear();
            titleInput.SendKeys(title);
        }

        internal void TypeDescription(string description)
        {
            var descriptionInput = Map.DescriptionInput;
            descriptionInput.Click();
            descriptionInput.Clear();
            descriptionInput.SendKeys(description);
        }

        internal void PressCreateTaskButton()
        {
            Map.CreateTaskButton.Click();
        }
    }
}

