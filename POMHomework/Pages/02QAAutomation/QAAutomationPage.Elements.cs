using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace POMHomework.Pages._02QAAutomation
{
    public partial class QAAutomationPage : BasePage
    {
        public IWebElement LearningsButton => Wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[text()='Обучения']")));

        public IWebElement ActiveModulsButton => Wait.Until(ExpectedConditions.ElementExists(By.XPath("//div[@class='category-nav']//div[contains(text(), 'Активни модули')]")));

        public IWebElement QAModulLink => Wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[contains(text(), 'Quality Assurance - октомври 2019')]")));

        public IWebElement CourseLink => Wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//h4[contains(text(), 'QA Automation')]")));

        public IWebElement CourseTitle => Wait.Until(ExpectedConditions.ElementExists(By.XPath("//h1[@class='text-center']")));
    }
}
