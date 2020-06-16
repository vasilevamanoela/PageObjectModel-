using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace POMHomework.Pages
{
    public abstract class BasePage
    {
        public IWebDriver Driver { get; }

        public WebDriverWait Wait { get; }

        public Actions Builder { get; }

        public virtual string Url { get; }

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            Builder = new Actions(Driver);
        }

        public void NavigateTo()
        {
            Driver.Navigate().GoToUrl(Url);
        }

        public void WaitForLoad(int timeoutSec = 15)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            WebDriverWait wait = new WebDriverWait(Driver, new TimeSpan(0, 0, timeoutSec));
            wait.Until(wd => js.ExecuteScript("return document.readyState").ToString() == "complete");
        }
    }
}
