﻿using GSI_QA_Testing_Tool_NUnit.Data;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static GSI_QA_Testing_Tool_NUnit.SeleniumExtensions;


namespace GSI_QA_Testing_Tool_NUnit.Pages
{
    public class UI_105_EmploymentStatus
    {
        By rbAcceptJobIfOfferedYes = By.Id("ctl00_Main_content_ucUIEmployment_rblOfferedJobToday_0");

        By rbBeenPhysicallyAbleToWorkYes = By.CssSelector("label[for='ctl00_Main_content_ucUIEmployment_rblPhysicallyAbleToWork_0']");
        
        By rbBeenAvailableToWorkYes = By.CssSelector("label[for='ctl00_Main_content_ucUIEmployment_rblAvailableToWork_0']");     

        By rbSelfEmployedNo = By.Id("ctl00_Main_content_ucUIEmployment_rblSelfEmployed_1");

        By rbElectedOfficialNo = By.Id("ctl00_Main_content_ucUIEmployment_rblElectedOfficial_1");

        By btnNext = By.Id("ctl00_Main_content_btnNext");

        public UI_105_EmploymentStatus()
        {
            if (new[] { "PFL" }.Any(site => TestData.Site.Contains(site))) { return; }

            rbAcceptJobIfOfferedYes.IsPresent()?.Click();

            rbBeenPhysicallyAbleToWorkYes.IsPresent()?.Click();

            rbBeenAvailableToWorkYes.IsPresent()?.Click();

            rbSelfEmployedNo.IsPresent()?.Click();

            rbElectedOfficialNo.IsPresent()?.Click();

            btnNext.Click();
        }
    }
}
