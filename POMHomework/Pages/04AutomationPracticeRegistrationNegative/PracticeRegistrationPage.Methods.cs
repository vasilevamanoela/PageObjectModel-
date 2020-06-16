using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using POMHomework.Models._04AutomationPracticeRegistrationNegative;

namespace POMHomework.Pages._04AutomationPracticeRegistrationNegative
{
    public partial class PracticeRegistrationPage : BasePage
    {
        public PracticeRegistrationPage(IWebDriver driver)
            : base(driver)
        {
        }

        public override string Url => "http://automationpractice.com/index.php";

        public void FillEmailForm(PracticeRegistrationModel user)
        {
            SignInButton.Click();
            EmailAddressField.SendKeys(user.EmailAddressField);
            CreateAccountButton.Click();
            RadioButton.Click();
            FirstName.SendKeys(user.FirstName);
            LastName.SendKeys(user.LastName);
            Password.SendKeys(user.Password);

            SelectElement date = new SelectElement(Date);
            date.SelectByValue("1");
            SelectElement month = new SelectElement(Month);
            month.SelectByValue("2");
            SelectElement year = new SelectElement(Year);
            year.SelectByValue("2010");

            Address.SendKeys(user.Address);
            City.SendKeys(user.City);

            SelectElement state = new SelectElement(State);
            state.SelectByValue("2");

            ZipCode.SendKeys(user.ZipCode);
            MobilePhone.SendKeys(user.MobilePhone);
            RegisterButton.Click();
        }
    }
}
