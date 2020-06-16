using NUnit.Framework;
using OpenQA.Selenium;

namespace POMHomework.Pages._02QAAutomation
{
    public partial class QAAutomationPage : BasePage
    {
        public void AssertCorrectCourseTitle(IWebElement element)
        {
            Assert.AreEqual("QA Automation - май 2020", element.Text);
        }

        public void AssertCorrectHeadingTag(IWebElement element)
        {
            Assert.IsTrue("h1" == element.TagName);
        }
    }
}
