﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.ObjectModel;

namespace GSI_QA_Testing_Tool_NUnit
{
    public static class SeleniumExtensions
    {
        private static IWebDriver Driver => BaseTest.CurrentDriver ?? throw new NullReferenceException("Driver is not initialized.");

        /// <summary>
        /// Default timeout value used when waiting for an element or condition.
        /// </summary>
        public static readonly int DefaultTimeoutInSeconds = 10;

        public static int GetTimeout()
        {
            // Example: Return a different timeout for a specific environment
            if (Environment.GetEnvironmentVariable("Env") == "QA")
            {
                return 15;
            }
            return DefaultTimeoutInSeconds;
        }

        public static Dictionary<string, string> ErrorMessages = new Dictionary<string, string>
        {
            {"ElementNotFound", "Element with locator {0} was not found when attempting to {1}."}
             // add more as needed
        };

        /// <summary>
        /// Returns a WebDriverWait object configured with the provided timeout or the default timeout.
        /// </summary>
        /// <param name="waitTimeInSeconds">Optional timeout in seconds. Uses default if not provided.</param>
        /// <returns>Returns a WebDriverWait object.</returns>
        public static WebDriverWait GetWait(int? waitTimeInSeconds = null)
        {
            return new WebDriverWait(Driver, TimeSpan.FromSeconds(waitTimeInSeconds ?? GetTimeout()));
        }

        /// <summary>
        /// Waits for the element specified by the locator to be clickable.
        /// </summary>
        /// <param name="locator">The By locator for the element.</param>
        /// <param name="waitTimeInSeconds">Optional timeout in seconds. Uses default if not provided.</param>
        /// <returns>Returns the locator of the element.</returns>
        public static By WaitForElementToBeClickable(this By locator, int? waitTimeInSeconds = null)
        {
            var wait = GetWait(waitTimeInSeconds);
            IWebElement? element = null;
            try
            {
                wait.Until(d =>
                {
                    element = d.FindElement(locator);
                    return element.Displayed && element.Enabled;
                });
            }
            catch (WebDriverTimeoutException)
            {
                throw new InvalidOperationException($"Element with locator {locator} was not clickable within the given wait time.");
            }
            catch (NoSuchElementException)
            {
                throw new NoSuchElementException(string.Format(ErrorMessages["ElementNotFound"], locator, "WaitForElementToBeClickable()"));
            }

            return locator;
        }

        /// <summary>
        /// Waits for the element specified by the locator to be visible.
        /// </summary>
        /// <param name="locator">The By locator for the element.</param>
        /// <param name="waitTimeInSeconds">Optional timeout in seconds. Uses default if not provided.</param>
        /// <returns>Returns the locator of the element.</returns>
        public static By WaitForElementToBeVisible(this By locator, int? waitTimeInSeconds = null)
        {
            var wait = GetWait(waitTimeInSeconds);
            ReadOnlyCollection<IWebElement>? elements = null;
            try
            {
                wait.Until(d =>
                {
                    elements = d.FindElements(locator);
                    return elements.Count > 0 && elements[0].Displayed;
                });
            }
            catch (WebDriverTimeoutException)
            {
                throw new InvalidOperationException($"Element with locator {locator} was not visible within the given wait time.");
            }

            return locator;
        }

        /// <summary>
        /// Waits for the element specified by the locator to become stale and then waits for it to reappear.
        /// </summary>
        /// <param name="locator">The By locator for the element.</param>
        /// <param name="waitTimeInSeconds">Optional timeout in seconds. Uses default if not provided.</param>
        /// <returns>Returns the locator of the refound element.</returns>
        public static By WaitForElementToBeStaleAndRefind(this By locator, int? waitTimeInSeconds = null)
        {
            var wait = GetWait(waitTimeInSeconds);

            IWebElement? originalElement = null;

            try
            {
                originalElement = Driver.FindElement(locator);
            }
            catch (NoSuchElementException)
            {
                // If the element doesn't exist at the start, we'll just move on. 
            }

            // If we found the element originally, wait for it to become stale.
            if (originalElement != null)
            {
                wait.Until(driver =>
                {
                    try
                    {
                        // Attempting to access any property, like Displayed, will throw if the element is stale
                        bool dummy = originalElement.Displayed;
                        return false;
                    }
                    catch (StaleElementReferenceException)
                    {
                        // This is what we want; the element is now stale!
                        return true;
                    }
                });
            }

            // Wait for the element to appear again (re-finding it)
            wait.Until(driver => driver.FindElements(locator).Count > 0);

            return locator;
        }






        /// <summary>
        /// Clicks on the element specified by the locator using JavaScript.
        /// </summary>
        /// <param name="locator">The By locator for the element.</param>
        public static By JSClick(this By locator)
        {
            try
            {
                IWebElement element = Driver.FindElement(locator);
                var jsExecutor = (IJavaScriptExecutor)Driver;
                jsExecutor.ExecuteScript("arguments[0].click();", element);
            }
            catch (NoSuchElementException)
            {
                throw new NoSuchElementException(string.Format(ErrorMessages["ElementNotFound"], locator, "JSClick()"));
            }
            catch (StaleElementReferenceException)
            {
                locator.WaitForElementToBeStaleAndRefind().JSClick();
            }
            return locator;
        }

        /// <summary>
        /// Clicks on the element specified by the locator.
        /// </summary>
        /// <param name="locator">The By locator for the element.</param>
        public static By Click(this By locator)
        {
            try
            {
                Driver.FindElement(locator).Click();
            }
            catch (NoSuchElementException)
            {
                throw new NoSuchElementException(string.Format(ErrorMessages["ElementNotFound"], locator, "Click()"));
            }
            catch (StaleElementReferenceException)
            {
                locator.WaitForElementToBeStaleAndRefind().Click();
            }
            catch (ElementNotInteractableException)
            {
                locator.JSClick();
            }
            return locator;
        }

        /// <summary>
        /// Checks if an element specified by the provided locator is present in the DOM.
        /// </summary>
        /// <param name="locator">The By locator for the element.</param>
        /// <returns>Returns the locator if the element is present, otherwise null.</returns>
        public static By? IsPresent(this By locator)
        {
            if (Driver.FindElements(locator).Count > 0)
            {
                return locator;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Sends the specified text to the element determined by the locator.
        /// </summary>
        /// <param name="locator">The By locator for the element.</param>
        /// <param name="text">The text to be sent to the element.</param>
        public static By SendKeys(this By locator, string text)
        {
            try
            {
                IWebElement element = Driver.FindElement(locator);
                element.SendKeys(text);
            }
            catch (NoSuchElementException)
            {
                throw new NoSuchElementException(string.Format(ErrorMessages["ElementNotFound"], locator, "SendKeys()"));
            }
            return locator;
        }

        /// <summary>
        /// Retrieves the text of the element specified by the locator.
        /// </summary>
        /// <param name="locator">The By locator for the element.</param>
        /// <returns>Returns the text of the element.</returns>
        public static string GetText(this By locator)
        {
            try
            {
                return Driver.FindElement(locator).Text;
            }
            catch (NoSuchElementException)
            {
                throw new NoSuchElementException(string.Format(ErrorMessages["ElementNotFound"], locator, "GetText()"));
            }
        }

        /// <summary>
        /// Clicks on all visible elements specified by the locator.
        /// </summary>
        /// <param name="locator">The By locator for the elements.</param>
        public static By ClickAllVisible(this By locator)
        {
            var elements = Driver.FindElements(locator);
            foreach (var element in elements)
            {
                if (element.Displayed)
                {
                    try
                    {
                        element.Click();
                    }
                    catch (WebDriverTimeoutException)
                    {
                        throw new InvalidOperationException($"Element with locator {locator} was not refound within the given wait time.");
                    }
                }
            }
            return locator;
        }

        /// <summary>
        /// Selects an option from a dropdown element based on visible text.
        /// </summary>
        /// <param name="locator">The By locator for the dropdown element.</param>
        /// <param name="text">The visible text of the option to be selected.</param>
        /// <exception cref="NoSuchElementException">Thrown if the dropdown element specified by the locator is not found.</exception>
        /// <exception cref="WebDriverException">Thrown if there is an error in the WebDriver, such as if the option with the given text is not found in the dropdown.</exception>
        public static By SelectDropdownByText(this By locator, string text)
        {
            var dropdown = new SelectElement(Driver.FindElement(locator));
            dropdown.SelectByText(text);
            return locator;
        }

        public static By SelectDropdownByIndex(this By locator, string index)
        {
            var dropdown = new SelectElement(Driver.FindElement(locator));
            dropdown.SelectByIndex(int.Parse(index));
            return locator;
        }

        public static By SelectDropdownByValue(this By locator, string value)
        {
            var dropdown = new SelectElement(Driver.FindElement(locator));
            dropdown.SelectByValue(value);
            return locator;
        }
    }
}
