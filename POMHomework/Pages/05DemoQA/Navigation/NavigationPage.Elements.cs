using OpenQA.Selenium;

namespace POMHomework.Pages._05DemoQA.Navigation
{
    public partial class NavigationPage : BasePage
    {
        public IWebElement InteractionButton => Driver.FindElement(By.XPath("//*[normalize-space(text())='Interactions']/ancestor::div[contains(@class, 'top-card')]"));

        public IWebElement InteractionSideBarMenu(string sectionName) =>
            Driver.FindElement(By.XPath($"//*[normalize-space(text())='{sectionName}']"));

        public IWebElement PageHeader => Driver.FindElement(By.ClassName("main-header"));
    }
}
