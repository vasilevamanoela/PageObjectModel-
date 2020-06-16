using OpenQA.Selenium;
using POMHomework.Utilities.Extensions;

namespace POMHomework.Pages._05DemoQA.Navigation
{
    public partial class NavigationPage : BasePage
    {
        public NavigationPage(IWebDriver driver)
            : base(driver)
        {
        }

        public override string Url => "http://www.demoqa.com/";

        public void Navigation(string sectionName)
        {
            InteractionButton.Click();

            Driver.ScrollTo(InteractionSideBarMenu(sectionName));
            InteractionSideBarMenu(sectionName).Click();           
        }
    }
}
