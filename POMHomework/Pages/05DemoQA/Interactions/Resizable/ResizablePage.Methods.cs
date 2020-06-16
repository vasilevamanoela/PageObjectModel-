using OpenQA.Selenium;

namespace POMHomework.Pages._05DemoQA.Interactions
{
    public partial class ResizablePage : BasePage
    {
        public ResizablePage(IWebDriver driver)
            : base(driver)
        {
        }

        public override string Url => "http://www.demoqa.com/resizable";

        public void DragAndDropToOffset(IWebElement sourse, int offsetX, int offsetY)
        {
            Builder
                .DragAndDropToOffset(sourse, offsetX, offsetY)
                .Perform();
        }
    }
}
