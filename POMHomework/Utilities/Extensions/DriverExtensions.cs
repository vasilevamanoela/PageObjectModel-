﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace POMHomework.Utilities.Extensions
{
    public static class DriverExtensions
    {
        public static void ScrollTo(this IWebDriver driver, IWebElement element)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }
    }
}
