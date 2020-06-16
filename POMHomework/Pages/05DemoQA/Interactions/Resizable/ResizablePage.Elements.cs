﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace POMHomework.Pages._05DemoQA.Interactions
{
    public partial class ResizablePage : BasePage
    {
        public IWebElement TheSlowestElementOnPage => Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class='Advertisement-Section']")));

        public IWebElement ResizeBox => Wait.Until(ExpectedConditions.ElementExists(By.Id("resizableBoxWithRestriction")));

        public IWebElement ResizeArrow => Wait.Until(ExpectedConditions.ElementExists(By.XPath("//div[@id='resizableBoxWithRestriction']//span[@class='react-resizable-handle react-resizable-handle-se']")));

        public IWebElement Container => Wait.Until(ExpectedConditions.ElementExists(By.ClassName("constraint-area")));

    }
}
