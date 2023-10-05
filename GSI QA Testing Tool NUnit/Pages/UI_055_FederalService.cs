﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit.Pages
{
    public class UI_055_FederalService
    {
        By rbFederalCivilianEmployee = By.CssSelector("label[for='ctl00_Main_content_Wizard1_rblFederalCivilianEmployee_1']");
        By btnNext = By.Id("ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton");

        public UI_055_FederalService()
        {
            rbFederalCivilianEmployee.Click();

            btnNext.Click();

        }

    }
}
