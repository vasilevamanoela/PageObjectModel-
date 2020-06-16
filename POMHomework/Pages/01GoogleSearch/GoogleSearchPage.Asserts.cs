using NUnit.Framework;
using OpenQA.Selenium;

namespace POMHomework.Pages._01GoogleSearch
{
    public partial class GoogleSearchPage : BasePage
    {
        public void AssertFirstResultTitle(IWebElement element)
        {
            Assert.AreEqual("Selenium", element.Text);
        }
    }
}
