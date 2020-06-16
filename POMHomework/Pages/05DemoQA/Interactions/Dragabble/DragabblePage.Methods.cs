using OpenQA.Selenium;

namespace POMHomework.Pages._05DemoQA.Interactions
{
    public partial class DragabblePage : BasePage
    {
        public DragabblePage(IWebDriver driver)
            : base(driver)
        {
        }

        public override string Url => "http://www.demoqa.com/dragabble";

        public void DragAndDropToOffset(IWebElement sourse, int offsetX, int offsetY)
        {
            Builder
                .DragAndDropToOffset(sourse, offsetX, offsetY)
                    .SendKeys(sourse, Keys.Tab)
                    .Perform();
        }
    }
}
