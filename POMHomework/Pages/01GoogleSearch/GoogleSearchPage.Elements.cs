using OpenQA.Selenium;

namespace POMHomework.Pages._01GoogleSearch
{
    public partial class GoogleSearchPage : BasePage
    {
        public IWebElement InputField => Wait.Until(d => d.FindElement(By.Name("q")));

        public IWebElement FirstResult => Wait.Until(d => d.FindElement(By.XPath("//h3[text()='Selenium']")));
    }
}
