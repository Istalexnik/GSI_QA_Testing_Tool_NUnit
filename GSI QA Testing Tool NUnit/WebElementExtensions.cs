using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit
{
    public static class WebElementExtensions
    {
        public static void JSClick(this IWebElement element)
        {
            var driver = ((IWrapsDriver)element).WrappedDriver;
            var jsExecutor = (IJavaScriptExecutor)driver;
            jsExecutor.ExecuteScript("arguments[0].click();", element);
        }

        public static void Click(this By by)
        {
            IWebDriver? driver = BasePage.CurrentDriver;
            if (driver == null)
            {
                throw new InvalidOperationException("Driver is not initialized.");
            }
            IWebElement element = driver.FindElement(by);
            element.Click();
        }
    }
}
