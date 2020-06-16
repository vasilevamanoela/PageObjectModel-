using NUnit.Framework;
using OpenQA.Selenium;

namespace POMHomework.Pages._04AutomationPracticeRegistrationNegative
{
    public partial class PracticeRegistrationPage : BasePage
    {
        public void AssertErrorMessage(string message, IWebElement element)
        {
            Assert.AreEqual(message, element.Text);
        }
    }
}
