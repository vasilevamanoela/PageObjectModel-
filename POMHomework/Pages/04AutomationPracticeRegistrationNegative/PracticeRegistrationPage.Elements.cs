using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace POMHomework.Pages._04AutomationPracticeRegistrationNegative
{
    public partial class PracticeRegistrationPage : BasePage
    {
        public IWebElement SignInButton => Wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[@class='login']")));

        public IWebElement EmailAddressField => Wait.Until(ExpectedConditions.ElementExists(By.Id("email_create")));

        public IWebElement CreateAccountButton => Wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("SubmitCreate")));

        public IWebElement RadioButton => Wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[@id='uniform-id_gender1']")));

        public IWebElement FirstName => Driver.FindElement(By.Id("customer_firstname"));

        public IWebElement LastName => Driver.FindElement(By.Id("customer_lastname"));

        public IWebElement Password => Driver.FindElement(By.Id("passwd"));

        public IWebElement Date => Wait.Until(d => d.FindElement(By.Id("days")));

        public IWebElement Month => Wait.Until(d => d.FindElement(By.Id("months")));

        public IWebElement Year => Wait.Until(d => d.FindElement(By.Id("years")));

        public IWebElement Address => Driver.FindElement(By.Id("address1"));

        public IWebElement City => Driver.FindElement(By.Id("city"));

        public IWebElement State => Wait.Until(d => d.FindElement(By.Id("id_state")));

        public IWebElement ZipCode => Driver.FindElement(By.Id("postcode"));

        public IWebElement MobilePhone => Driver.FindElement(By.Id("phone_mobile"));

        public IWebElement RegisterButton => Driver.FindElement(By.Id("submitAccount"));

        public IWebElement ErrorMessage => Driver.FindElement(By.XPath("//div[@class='alert alert-danger']//li"));
    }
}
