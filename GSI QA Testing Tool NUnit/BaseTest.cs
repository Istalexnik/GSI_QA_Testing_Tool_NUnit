using GSI_QA_Testing_Tool_NUnit.Data;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit
{
    public abstract class BaseTest
    {
        protected static IWebDriver? Driver { get; private set; }
        public static IWebDriver? CurrentDriver { get; set; }

        [SetUp]
        public static void TestSetup()
        {
            CloseAllChromeDriverProcesses();
            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;

            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments(new List<string> {
        "no-sandbox",
        $"--user-data-dir={Path.GetFullPath("C:/ChromeProfile/")}"
    });
            chromeOptions.AddExcludedArgument("enable-automation");

            chromeOptions.AddUserProfilePreference("profile.exit_type", "Normal");

            Driver = new ChromeDriver(service, chromeOptions, TimeSpan.FromSeconds(120));
            CurrentDriver = Driver; // <-- This sets the static driver in BasePage.
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl(TestData.Url);
        }

        [TearDown]
        public void TestTearDown()
        {
        //    Driver.Quit();
        }

        private static void CloseAllChromeDriverProcesses()
        {
            foreach (var process in Process.GetProcessesByName("chrome"))
            {
                try
                {
                    process.Kill();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Failed to close process {process.Id}. Error: {ex.Message}");
                }
            }


        }

    }
}
