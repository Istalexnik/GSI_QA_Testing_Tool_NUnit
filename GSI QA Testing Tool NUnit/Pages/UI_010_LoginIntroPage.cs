﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit.Pages
{
    public class UI_010_LoginIntroPage : BasePage
    {
        By individualregistrationButton = By.Id("btnIndRegistration");

        public UI_010_LoginIntroPage(IWebDriver driver) : base(driver) { }

        public UI_015_EqualOpportunity ClickIndividualregistrationButton()
        {
            individualregistrationButton.WaitForElementToBeClickable(Driver).Click();
            return new UI_015_EqualOpportunity(Driver);
        }

    }
}
