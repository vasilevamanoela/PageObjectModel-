﻿using OpenQA.Selenium;

namespace POMHomework.Pages._05DemoQA.Interactions
{
    public partial class SortablePage : BasePage
    {
        public SortablePage(IWebDriver driver)
            : base(driver)
        {
        }

        public override string Url => "http://www.demoqa.com/sortable";

        public void DragAndDrop(IWebElement sourse, IWebElement target)
        {
            Builder
                .DragAndDrop(sourse, target)
                .SendKeys(sourse, Keys.Tab)
                .Perform();
        }

        public void DragAndDropToOffset(IWebElement sourse, int offsetX, int offsetY)
        {
            Builder
                .DragAndDropToOffset(sourse, offsetX, offsetY)
                .SendKeys(sourse, Keys.Tab)
                .Perform();
        }
    }
}
