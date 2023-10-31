using GSI_QA_Testing_Tool_NUnit.Data;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit.Pages
{
    public class UI_055_FederalService
    {
        By rbFederalCivilianEmployeeNo = By.CssSelector("label[for='ctl00_Main_content_Wizard1_rblFederalCivilianEmployee_1']");
        By rbFederalCivilianEmployeeYes = By.CssSelector("label[for='ctl00_Main_content_Wizard1_rblFederalCivilianEmployee_0']");
        By rbInHostStateYes = By.CssSelector("label[for='ctl00_Main_content_Wizard1_rblFederalCivilianEmployeeHostState_0']");
        By btnOk = By.Id("btn-dialog-save");
        By rbInAnotherStateNo = By.CssSelector("label[for='ctl00_Main_content_Wizard1_rblFederalCivilianEmployeeAnotherState_1']");
        By rbWagesAssignedOtherStateNo = By.CssSelector("label[for='ctl00_Main_content_Wizard1_rblHasOtherStateWages_1']");
        By btnNext = By.Id("ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton");

        By rbAddFederalEmployerYes = By.CssSelector("label[for='ctl00_Main_content_Wizard1_ucFederalCivilEmploymentHistory_rbAddNewEmp_0']");
        By rbAddFederalEmployerNo = By.CssSelector("label[for='ctl00_Main_content_Wizard1_ucFederalCivilEmploymentHistory_rbAddNewEmp_1']");

        By spanFIC = By.ClassName("ui-icon-triangle-1-s");
        By inputFIC = By.Id("cmbCustomFIC");
        By ddDestinationCode = By.Id("ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_ddlDestCodes");
        By ddStateOfEmployment = By.Id("ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_ddlStateOfEmployment");
        By txtCity = By.Id("ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_txtOutofCountryCity");
        By rbForm8Yes = By.CssSelector("label[for='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_rblReceiveStandardForm8_0']");
        By rbForm50Yes = By.CssSelector("label[for='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_rblReceiveStandardForm50_0']");
        By txtWorkBeginDate = By.Id("ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_txtDateBeganWork");
        By txtWorkEndDate = By.Id("ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_txtLastDayWorked");
        By ddSeparationReason = By.Id("ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_ddlReasonForSeparation");
        By ddEmployerCategory = By.Id("ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_ddlEmployerNAICS");
        By ddOccupation = By.Id("ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_ddlPositionOccGroupCode");
        By txtWagesQ1 = By.Id("ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_txtWagesQuarter1");
        By txtWagesQ2 = By.Id("ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_txtWagesQuarter2");
        By txtWagesQ3 = By.Id("ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_txtWagesQuarter3");
        By txtWagesQ4 = By.Id("ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_txtWagesQuarter4");
        By txtWagesQ5 = By.Id("ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_txtWagesQuarter5");
        By txtWagesQ6 = By.Id("ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_txtWagesQuarter6");
        By rbDidYouWorkInNEAfterThatNo = By.CssSelector("label[for='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_rblWorkedInStateAfterFederalEmployment_1']");
        By rbDidYouWorkAnywhereAfterThatNo = By.CssSelector("label[for='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_rblOtherEmploymentLastNMonths_1']");


        public UI_055_FederalService()
        {

            if (!TestData.Type.Contains(3))
            {
                rbFederalCivilianEmployeeNo.Click();
                btnNext.Click();
            } 
            else
            {
                rbFederalCivilianEmployeeYes.Click();
                rbInHostStateYes.Click();
                btnOk.Click();
                rbInAnotherStateNo.Click();
                rbWagesAssignedOtherStateNo.Click();
                btnNext.Click();

                //adding employer
                rbAddFederalEmployerYes.Click();
                btnNext.Click();

                //employer info
                spanFIC.Click();
                inputFIC.SendKeys(Keys.Down + Keys.Down + Keys.Tab).WaitForElementToBeStaleAndRefind(); ;
                ddDestinationCode.SelectDropdownByIndex("1").WaitForElementToBeStaleAndRefind();
                ddStateOfEmployment.SelectDropdownByValue(TestData.StateAbbreviation).WaitForElementToBeStaleAndRefind();
                txtCity.SendKeys("City");
                rbForm8Yes.Click();
                rbForm50Yes.Click();
                txtWorkBeginDate.SendKeys(TestData.WorkBeginDate1);
                txtWorkEndDate.SendKeys(TestData.WorkEndDate1);
                ddSeparationReason.SelectDropdownByPartialText("Lay");
                ddEmployerCategory.SelectDropdownByIndex("1");
                ddOccupation.SelectDropdownByIndex("1");
                txtWagesQ1.SendKeys("5000");
                txtWagesQ2.SendKeys("5000");
                txtWagesQ3.SendKeys("5000");
                txtWagesQ4.SendKeys("5000");
                txtWagesQ5.SendKeys("5000");
                txtWagesQ6.SendKeys("5000");
                rbDidYouWorkInNEAfterThatNo.Click();
                rbDidYouWorkAnywhereAfterThatNo.Click();
                btnNext.Click();

                //adding employer
                rbAddFederalEmployerNo.Click();
                btnNext.Click();
            }


        }

    }
}
