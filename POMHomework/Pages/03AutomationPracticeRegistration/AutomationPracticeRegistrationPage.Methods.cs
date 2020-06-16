using OpenQA.Selenium;
using POMHomework.Models._03AutomationPracticeRegistration;
using POMHomework.Utilities.Extensions;

namespace POMHomework.Pages._03AutomationPracticeRegistration
{
    public partial class AutomationPracticeRegistrationPage : BasePage
    {
        public AutomationPracticeRegistrationPage(IWebDriver driver)
            : base(driver)
        {
        }

        public override string Url => "http://automationpractice.com/index.php";

        public void NavigationEmailForm(AutomationPracticeRegistrationModel user)
        {
            SignInButton.Click();
            EmailAddressField.SendKeys(user.EmailAddressField);
            CreateAccountButton.Click();

            Driver.ScrollTo(EmailField);
        }
    }
}
