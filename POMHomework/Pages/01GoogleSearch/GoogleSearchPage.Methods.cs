using OpenQA.Selenium;
using POMHomework.Models._01GoogleSearch;

namespace POMHomework.Pages._01GoogleSearch
{
    public partial class GoogleSearchPage : BasePage
    {
        public GoogleSearchPage(IWebDriver driver)
            : base(driver)
        {
        }

        public override string Url => "http://www.google.com";

        public void FillGoogleSearch(GoogleSearchModel input)
        {
            InputField.SendKeys(input.InputField + Keys.Enter);
        }
    }
}
