using NUnit.Framework;
using OpenQA.Selenium;

namespace POMHomework.Pages._03AutomationPracticeRegistration
{
    public partial class AutomationPracticeRegistrationPage : BasePage
    {
        public void AssertThatTheEmailsAreSame(IWebElement element)
        {
            Assert.AreEqual(element.Text, element.GetProperty("value"));
        }
    }
}
