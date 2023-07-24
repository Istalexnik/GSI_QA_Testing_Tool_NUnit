using GSI_QA_Testing_Tool_NUnit.Data;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit
{
    public abstract class BaseTest
    {
        protected IWebDriver Driver { get; private set; }
        private TestData testData;

        [SetUp]
        public void TestSetup()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            testData = new TestData();
            Driver.Navigate().GoToUrl(testData.Url);
        }

        [TearDown]
        public void TestTearDown()
        {
        //    Driver.Quit();
        }
    }
}
