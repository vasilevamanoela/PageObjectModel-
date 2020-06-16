using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace POMHomework.Pages._05DemoQA.Interactions
{
    public partial class DroppablePage : BasePage
    {
        public IWebElement TheSlowestElementOnPage => Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class='Advertisement-Section']")));

        public IWebElement SourceBox => Wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("draggable")));

        public IWebElement TargetBox => Wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("droppable")));
    }
}
