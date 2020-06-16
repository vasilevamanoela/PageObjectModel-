﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Linq;

namespace POMHomework.Pages._05DemoQA.Interactions
{
    public partial class SortablePage : BasePage
    {
        public IWebElement TheSlowestElementOnPage => Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class='Advertisement-Section']")));

        public IWebElement SortablePanel => Wait.Until(ExpectedConditions.ElementExists(By.XPath("//li[@class='btn btn-light active']")));

        public IWebElement FirstElement => Wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/div/div[1]/div/div[1]")));

        public IWebElement LastElement => Wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/div/div[1]/div/div[6]")));

        public List<IWebElement> ListOfOption => Driver.FindElements(By.XPath("//div[@id='demo-tabpane-list']//div[contains(@class, 'list-group-item')]")).ToList();
    }
}
