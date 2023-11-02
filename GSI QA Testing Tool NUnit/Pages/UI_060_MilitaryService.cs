﻿using GSI_QA_Testing_Tool_NUnit.Data;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit.Pages
{
    public class UI_060_MilitaryService
    {
        By rbMilitaryServiceNo = By.CssSelector("label[for='ctl00_Main_content_Wizard1_rblMilitaryService_1']");
        By rbMilitaryServiceYes = By.CssSelector("label[for='ctl00_Main_content_Wizard1_rblMilitaryService_0']");
        By btnNext = By.Id("ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton");

        By rbAddMilitaryEmployerYes = By.CssSelector("label[for='ctl00_Main_content_Wizard1_ucMilitaryServiceHistory_rbAddNewEmp_0']");
        By rbAddMilitaryEmployerNo = By.CssSelector("label[for='ctl00_Main_content_Wizard1_ucMilitaryServiceHistory_rbAddNewEmp_1']");

        By rbHaveYouFiledNo = By.CssSelector("label[for='ctl00_Main_content_Wizard1_ucMilitaryService_rblFiledInStateAfterSeparation_1']");
        By rbDD214Yes = By.CssSelector("label[for='ctl00_Main_content_Wizard1_ucMilitaryService_rblMember4OfDD214_0']");
        By ddServiceBranch = By.Id("ctl00_Main_content_Wizard1_ucMilitaryService_ddlServiceBranch");
        By txtEntryDate = By.Id("ctl00_Main_content_Wizard1_ucMilitaryService_txtServiceEntryDate");
        By txtSeparationDate = By.Id("ctl00_Main_content_Wizard1_ucMilitaryService_txtServiceSeparationDate");
        By ddCharacterOfService = By.Id("ctl00_Main_content_Wizard1_ucMilitaryService_ddlDischargeStatus");
        By ddReasonForSeparation = By.Id("ctl00_Main_content_Wizard1_ucMilitaryService_ddlReasonForSeparation");
        By ddPayGrade = By.Id("ctl00_Main_content_Wizard1_ucMilitaryService_ddlPayGrade");
        By txtAccruedDaysOfLeave = By.Id("ctl00_Main_content_Wizard1_ucMilitaryService_txtAccuredDaysOfLeave");
        By rbPhysicalDisabilityNo = By.CssSelector("label[for='ctl00_Main_content_Wizard1_ucMilitaryService_rblDischargePhysicalDisability_1']");
        By rbMilitaryRetireeNo = By.CssSelector("label[for='ctl00_Main_content_Wizard1_ucMilitaryService_rblMilitaryRetiree_1']");
        By rbCompletedFirstTermNo = By.CssSelector("label[for='ctl00_Main_content_Wizard1_ucMilitaryService_rblCompletedFirstFullTermDuty_1']");
        By rbAppliedForAllowanceNo = By.CssSelector("label[for='ctl00_Main_content_Wizard1_ucMilitaryService_rblSubsistenceVocRehabTraining_1']");
        By rbAppliedForAssistanceNo = By.CssSelector("label[for='ctl00_Main_content_Wizard1_ucMilitaryService_rblWarOrphanWidowsEducationAllowance_1']");


        public UI_060_MilitaryService()
        {
            if (!TestData.Type.Contains(2))
            {
                rbMilitaryServiceNo.Click();
                btnNext.Click();
            }
            else
            {
                rbMilitaryServiceYes.Click();
                btnNext.Click();

                //adding employer
                rbAddMilitaryEmployerYes.Click();
                btnNext.Click();

                //employer info
                rbHaveYouFiledNo.Click();
                rbDD214Yes.Click();
                ddServiceBranch.SelectDropdownByIndex("1");
                txtEntryDate.SendKeys(TestData.WorkBeginDate1);
                txtSeparationDate.SendKeys(TestData.WorkEndDate1);
                ddCharacterOfService.SelectDropdownByIndex("1");
                ddReasonForSeparation.SelectDropdownByIndex("1");
                ddPayGrade.SelectDropdownByIndex("1");
                txtAccruedDaysOfLeave.SendKeys("0");
                rbPhysicalDisabilityNo.Click();
                rbMilitaryRetireeNo.Click();
                rbCompletedFirstTermNo.Click();
                rbAppliedForAllowanceNo.Click();
                rbAppliedForAssistanceNo.Click();
                btnNext.Click();

                //adding employer
                rbAddMilitaryEmployerNo.Click();
                btnNext.Click();
            }

        }
    }
}
