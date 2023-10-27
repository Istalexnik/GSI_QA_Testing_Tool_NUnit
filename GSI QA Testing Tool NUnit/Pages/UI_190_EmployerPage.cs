using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit.Pages
{
    public class UI_190_EmployerPage
    {
                               
        By txtEmployerName = By.Id("ctl00_Main_content_ucIndEmpHistory_txtEmpName");

        By txtSuggestions = By.Id("ac_results");

        By rbLastEmployerYes = By.Id("ctl00_Main_content_ucIndEmpHistory_rblLastEmployer_0");

        By txtJobTitle = By.Id("ctl00_Main_content_ucIndEmpHistory_txtJobTitle");

        By ddEmployerType = By.Id("ctl00_Main_content_ucIndEmpHistory_cboEmpType");

        By ddFullOrPartTime = By.Id("ctl00_Main_content_ucIndEmpHistory_cboFullPartTime");

        By ddHours = By.Id("ctl00_Main_content_ucIndEmpHistory_ddlWholeHours");

        By txtGrossSalary = By.Id("ctl00_Main_content_ucIndEmpHistory_txtSalary");

        By ddSalaryBasedUpon = By.Id("ctl00_Main_content_ucIndEmpHistory_cboSalaryBase");

        By rbComissionBasedNo = By.Id("ctl00_Main_content_ucIndEmpHistory_rblSalaryCommission_1");

        By txtWorkBeginDate = By.Id("ctl00_Main_content_ucIndEmpHistory_txtStartDate");

        By rbCurrentlyEmployedNo = By.Id("ctl00_Main_content_ucIndEmpHistory_rblCurrentlyEmployed_1");

        By txtearningsThisWeek = By.Id("ctl00_Main_content_ucIndEmpHistory_txtGrossEarningsThisWeek");

        By txtHoursThisWeek = By.Id("ctl00_Main_content_ucIndEmpHistory_txtHoursWorkedThisWeek");

        By ddSeparationReason = By.Id("ctl00_Main_content_ucIndEmpHistory_cboSeparationReason");
        
        By ddSeparationCategory = By.Id("ctl00_Main_content_ucIndEmpHistory_ddlLeaveReasonSubType");

        By txtWorkEndDate = By.Id("ctl00_Main_content_ucIndEmpHistory_txtEndDate");

        By rbRecallNo = By.Id("ctl00_Main_content_ucIndEmpHistory_rblIntendToRecall_1");

        By rbEducationalNo = By.Id("ctl00_Main_content_ucIndEmpHistory_rblEducationalInstitution_1");

        By rbOfficerRelativeNo = By.Id("ctl00_Main_content_ucIndEmpHistory_rblCorporateOfficer_1");

        By rbTransferOutOfCountryNo = By.Id("ctl00_Main_content_ucIndEmpHistory_rblTransferOutOfCountry_1");

        By ifrJobDuties = By.XPath("//iFrame[contains(@title, 'ctl00_Main_content_ucIndEmpHistory_txtJobDuties_txtWYSIWYGEditor')]");

        By txtJobDuties = By.XPath("//body[@class='cke_editable cke_editable_themed cke_contents_ltr cke_show_borders']");
        
        By rbSeveranceNo = By.Id("ctl00_Main_content_ucIndEmpHistory_ucBenefitPaymentForm_Severance_rdoPayType_1");

        By rbVacationNo = By.Id("ctl00_Main_content_ucIndEmpHistory_ucBenefitPaymentForm_Vacation_rdoPayType_1");

        By rbHolidayPayNo = By.Id("ctl00_Main_content_ucIndEmpHistory_ucBenefitPaymentForm_Holiday_rdoPayType_1");

        By rbSickPayNo = By.Id("ctl00_Main_content_ucIndEmpHistory_ucBenefitPaymentForm_Sick_rdoPayType_1");

        By rbBonusPayNo = By.Id("ctl00_Main_content_ucIndEmpHistory_ucBenefitPaymentForm_Bonus_rdoPayType_1");

        By rbPensionNo = By.Id("ctl00_Main_content_ucIndEmpHistory_ucPensionRetirement_rblPension_1");

        By rb401KNo = By.Id("ctl00_Main_content_ucIndEmpHistory_ucPensionRetirement_rbl401k_1");

        By rbMilitaryDisabilityNo = By.Id("ctl00_Main_content_ucIndEmpHistory_ucPensionRetirement_rblMilitaryDisabilityCompensation_1");

        By rbWorkersCompensationAreNo = By.Id("ctl00_Main_content_ucIndEmpHistory_rblWCReceived_1");

        By rbWorkersCompensationDidNo = By.Id("ctl00_Main_content_ucIndEmpHistory_rdoWCNewReceived_1");

        By btnNext = By.Id("ctl00_Main_content_ucWizardButtons_btnSave");

        By btnConfirm = By.XPath("//button[@id='btn-dialog-save']");


        public UI_190_EmployerPage()
        {

            if (string.IsNullOrEmpty(txtEmployerName.WaitForElementToBeClickable().GetText()))
            {

            }

            rbLastEmployerYes.Click().WaitForElementToBeStaleAndRefind();

            txtJobTitle.EnterText(TestData.JobTitle, txtSuggestions).WaitForElementToBeStaleAndRefind();

            ddEmployerType.SelectDropdownByIndex("1");

            ddFullOrPartTime.SelectDropdownByIndex("1");

            ddHours.SelectDropdownByIndex("1");

            txtGrossSalary.SendKeys("40");

            ddSalaryBasedUpon.SelectDropdownByIndex("1");

            rbComissionBasedNo.Click();

            txtWorkBeginDate.SendKeys(TestData.WorkBeginDate);

            rbCurrentlyEmployedNo.Click();

            txtearningsThisWeek.SendKeys("0");

            txtHoursThisWeek.SendKeys("0");

            ddSeparationReason.SelectDropdownByPartialText("Lay").WaitForElementToBeStaleAndRefind();

            ddSeparationCategory.SelectDropdownByPartialText("Lay").WaitForElementToBeStaleAndRefind();

            txtWorkEndDate.SendKeys(TestData.WorkEndDate);

            rbRecallNo.Click();

            rbEducationalNo.Click();

            rbOfficerRelativeNo.Click();

            rbTransferOutOfCountryNo.Click();

            ifrJobDuties.SendTextToIFrame(txtJobDuties, "Test");

            rbSeveranceNo.Click();

            rbVacationNo.Click();

            rbHolidayPayNo.Click();

            rbSickPayNo.Click();

            rbBonusPayNo.Click();

            rbPensionNo.Click();

            rb401KNo.Click();

            rbMilitaryDisabilityNo.Click();

            rbWorkersCompensationAreNo.Click();

            rbWorkersCompensationDidNo.Click();

            btnNext.Click();

            btnConfirm.LoopAndClickAllVisible();
        }
    }
}
