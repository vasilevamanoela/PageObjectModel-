using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace POMHomework.Pages._03AutomationPracticeRegistration
{
    public partial class AutomationPracticeRegistrationPage : BasePage
    {
        public IWebElement SignInButton => Wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[@class='login']")));

        public IWebElement EmailAddressField => Wait.Until(ExpectedConditions.ElementExists(By.Id("email_create")));

        public IWebElement CreateAccountButton => Wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("SubmitCreate")));

        public IWebElement EmailField => Wait.Until(ExpectedConditions.ElementExists(By.Id("email")));
    }
}
