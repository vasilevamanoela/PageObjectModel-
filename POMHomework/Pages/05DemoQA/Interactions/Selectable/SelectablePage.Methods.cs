using OpenQA.Selenium;

namespace POMHomework.Pages._05DemoQA.Interactions
{
    public partial class SelectablePage : BasePage
    {
        public SelectablePage(IWebDriver driver)
            : base(driver)
        {
        }

        public override string Url => "http://www.demoqa.com/selectable";
    }
}
