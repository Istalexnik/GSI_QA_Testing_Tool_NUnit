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


        }
    }
}
