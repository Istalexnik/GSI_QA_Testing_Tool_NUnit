using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit.Pages
{
    public class UI_105_EmploymentStatus
    {
        By rbAcceptJobIfOfferedYes = By.Id("ctl00_Main_content_ucUIEmployment_rblOfferedJobToday_0");

        By rbSelfEmployedNo = By.Id("ctl00_Main_content_ucUIEmployment_rblSelfEmployed_1");

        By rbElectedOfficialNo = By.Id("ctl00_Main_content_ucUIEmployment_rblElectedOfficial_1");

        By btnNext = By.Id("ctl00_Main_content_btnNext");

        public UI_105_EmploymentStatus()
        {
            rbAcceptJobIfOfferedYes.Click();

            rbSelfEmployedNo.Click();

            rbElectedOfficialNo.Click();

            btnNext.Click();
        }
    }
}
