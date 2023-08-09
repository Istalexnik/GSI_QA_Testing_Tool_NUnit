using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.ObjectModel;

namespace GSI_QA_Testing_Tool_NUnit
{
    public static class SeleniumExtensions
    {
        private static IWebDriver Driver => BasePage.CurrentDriver ?? throw new NullReferenceException("Driver is not initialized.");

        // WaitHelpers methods
        public static WebDriverWait GetWait(int? waitTimeInSeconds = null)
        {
            return new WebDriverWait(Driver, TimeSpan.FromSeconds(waitTimeInSeconds ?? 10));
        }

        public static By WaitForElementToBeClickable(this By locator, int? waitTimeInSeconds = null)
        {
            var wait = GetWait(waitTimeInSeconds);
            IWebElement? element = null;
            wait.Until(d =>
            {
                try
                {
                    element = d.FindElement(locator);
                    return element != null && element.Displayed && element.Enabled;
                }
                catch (NoSuchElementException)
                {
                    throw new NoSuchElementException($"Element with locator {locator} was not found");
                }
            });

            if (element == null)
            {
                throw new NoSuchElementException($"Element with locator {locator} was not clickable");
            }

            return locator;
        }

        public static By WaitForElementToBeVisible(this By locator, int? waitTimeInSeconds = null)
        {
            var wait = GetWait(waitTimeInSeconds);
            ReadOnlyCollection<IWebElement>? elements = null;
            wait.Until(d =>
            {
                elements = d.FindElements(locator);
                return elements.Count > 0 && elements[0].Displayed;
            });

            if (elements == null || elements.Count == 0)
            {
                throw new NoSuchElementException($"Element with locator {locator} was not visible");
            }

            return locator;
        }

        public static By WaitForElementToBeStaleAndRefind(this By locator, int? waitTimeInSeconds = null)
        {
            var wait = GetWait(waitTimeInSeconds);
            IWebElement element = Driver.FindElement(locator);
            wait.Until(d =>
            {
                try
                {
                    // Attempt to interact with the element
                    var isEnabled = element.Enabled;
                    return false; // If no exception, the element is not stale, return false
                }
                catch (StaleElementReferenceException)
                {
                    return true; // If an exception is thrown, the element is stale, return true
                }
            });

            // Re-find the element after it has become stale
            return locator;
        }

        // WebElementExtensions methods
        public static void JSClick(this By by)
        {
            IWebElement element = Driver.FindElement(by);
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

        public static void ClickIfPresent(this By locator)
        {
            if (locator.IsPresent())
            {
                Driver.FindElement(locator).Click();
            }
        }
        public static bool IsPresent(this By locator)
        {
            return Driver.FindElements(locator).Count > 0;
        }


        public static void SendKeys(this By locator, string text)
        {
            IWebElement element = Driver.FindElement(locator);
            element.SendKeys(text);
        }


    }
}
