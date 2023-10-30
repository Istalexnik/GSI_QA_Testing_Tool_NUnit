using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit.Pages
{
    public class UI_135_MilitaryInformation
    {
        By rbSpouseNo = By.Id("ctl00_Main_content_ucVeteran_rblSpouseEligiblePerson_1");
       
        By rbVeteranNo = By.Id("ctl00_Main_content_ucVeteran_rblMilitaryService_1");

        By rbServed180DaysNo = By.Id("ctl00_Main_content_ucVeteran_rblServedConsecutiveDaysInActiveDuty_1");

        By ddClassifiedDisabledVeteran = By.Id("ctl00_Main_content_ucVeteran_ddlClassifiedAsDisabledVeteran");

        By btnNext = By.Id("ctl00_Main_content_btnNext");
        public UI_135_MilitaryInformation()
        {
            if (!rbSpouseNo.FindIt()) { return; }

            rbSpouseNo.Click();

            rbVeteranNo.IsPresent()?.Click();

            rbServed180DaysNo.IsPresent()?.Click();

            ddClassifiedDisabledVeteran.IsPresent()?.SelectDropdownByIndex("1");

            btnNext.Click();
        }
    }
}
