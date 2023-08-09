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
    }


}

