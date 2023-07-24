using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.ObjectModel;

namespace GSI_QA_Testing_Tool_NUnit
{
    public static class WaitHelpers
    {
        public static WebDriverWait GetWait(IWebDriver driver, int? waitTimeInSeconds = null)
        {
            return new WebDriverWait(driver, TimeSpan.FromSeconds(waitTimeInSeconds ?? 10));
        }

        public static IWebElement WaitForElementToBeClickable(this By locator, IWebDriver driver, int? waitTimeInSeconds = null)
        {
            var wait = GetWait(driver, waitTimeInSeconds);
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

            return element;
        }

        public static IWebElement WaitForElementToBeVisible(this By locator, IWebDriver driver, int? waitTimeInSeconds = null)
        {
            var wait = GetWait(driver, waitTimeInSeconds);
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

            return elements[0];
        }

        public static IWebElement WaitForElementToBeStaleAndRefind(this By locator, IWebDriver driver, int? waitTimeInSeconds = null)
        {
            var wait = GetWait(driver, waitTimeInSeconds);
            IWebElement element = driver.FindElement(locator);
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
            return driver.FindElement(locator);
        }
    }
}
