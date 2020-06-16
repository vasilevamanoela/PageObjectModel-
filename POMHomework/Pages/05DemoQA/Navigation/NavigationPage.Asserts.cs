using NUnit.Framework;
using OpenQA.Selenium;

namespace POMHomework.Pages._05DemoQA.Navigation
{
    public partial class NavigationPage : BasePage
    {
        public void AssertCorrectTitleSection(string sectionName, IWebElement element)
        {
            Assert.AreEqual(sectionName, element.Text);
        }
    }
}
