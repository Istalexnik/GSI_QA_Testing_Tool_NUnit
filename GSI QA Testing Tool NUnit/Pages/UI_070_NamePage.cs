﻿
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSI_QA_Testing_Tool_NUnit.Data;


namespace GSI_QA_Testing_Tool_NUnit.Pages
{
    public class UI_070_NamePage
    {

        By txtFirstName = By.Id("ctl00_Main_content_ucName_txtFirstName");
        By txtLastName = By.Id("ctl00_Main_content_ucName_txtLastName");
        By btnNext = By.Id("ctl00_Main_content_btnNext");

        
        public UI_070_NamePage()
        {
            txtFirstName.SendKeys(TestData.FirstName);

            txtLastName.SendKeys(TestData.LastName);

            btnNext.Click();
        }

    }
}
