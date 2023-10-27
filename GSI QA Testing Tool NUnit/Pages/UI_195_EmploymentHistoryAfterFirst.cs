﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit.Pages
{
    public class UI_195_EmploymentHistoryAfterFirst
    {
        By rbAddEmployerNo = By.Id("ctl00_Main_content_rblAddAnotherEntry_1");

        By btnNext = By.Id("ctl00_Main_content_btnNext");
        public UI_195_EmploymentHistoryAfterFirst()
        {
            rbAddEmployerNo.Click();

            btnNext.Click();
        }
    }
}
