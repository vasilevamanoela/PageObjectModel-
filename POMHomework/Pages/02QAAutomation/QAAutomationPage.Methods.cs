using OpenQA.Selenium;
using POMHomework.Utilities.Extensions;

namespace POMHomework.Pages._02QAAutomation
{
    public partial class QAAutomationPage : BasePage
    {
        public QAAutomationPage(IWebDriver driver)
            : base(driver)
        {
        }

        public override string Url => "http://www.softuni.bg";

        public void NavigationForm()
        {
            LearningsButton.Click();
            ActiveModulsButton.Click();
            QAModulLink.Click();

            Driver.ScrollTo(CourseLink);
            CourseLink.Click();
        }
    }
}
