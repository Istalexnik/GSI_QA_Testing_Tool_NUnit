using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit
{
    public abstract class BasePage
    {
        public static IWebDriver? CurrentDriver { get;  set;}
        protected static IWebDriver Driver => CurrentDriver ?? throw new InvalidOperationException("Driver is not initialized.");


        protected bool IsPresent(By locator)
        {
            return Driver.FindElements(locator).Count > 0;
        }
    }


}

