using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit.Pages
{
    public class UI_110_EmploymentMiscellaneous
    {
        By rbAttendingTrainingNo = By.Id("ctl00_Main_content_ucUIEmploymentStatus_rblAttendingTraining_1");
        
        By rbComissionBasisNo = By.CssSelector("label[for='ctl00_Main_content_ucUIEmploymentStatus_rblCommissionBasis_1']");
           
        By rbResultOfTradeNo = By.Id("ctl00_Main_content_ucUIEmploymentStatus_rblCertifiedTrade_1");

        By rbProfessionalAthleteNo = By.Id("ctl00_Main_content_ucUIEmploymentStatus_rblWorkedAsProfessionalAthlete_1");

        By rbHeadStartNo = By.CssSelector("label[for='ctl00_Main_content_ucUIEmploymentStatus_rblEmployedBySchool_1']");

        By btnNext = By.Id("ctl00_Main_content_btnNext");
        public UI_110_EmploymentMiscellaneous()
        {
            rbAttendingTrainingNo.Click();

            rbComissionBasisNo.IsPresent()?.Click();

            rbResultOfTradeNo.Click();

            rbProfessionalAthleteNo.IsPresent()?.Click();

            rbHeadStartNo.IsPresent()?.Click();

            btnNext.Click();
        }
    }
}
