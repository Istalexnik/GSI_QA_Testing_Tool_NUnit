using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit.Pages
{
    public class UI_130_EthnicOrigin
    {
        By rbHispanicNo = By.Id("ctl00_Main_content_ucEthnicity_rblHispanic_1");

        By cbRace = By.Id("ctl00_Main_content_ucEthnicity_chkRaceList_1");

        By rbLimitedEnglishNo = By.Id("ctl00_Main_content_ucEthnicity_rblLangSecondary_1");

        By btnNext = By.Id("ctl00_Main_content_btnNext");
        public UI_130_EthnicOrigin()
        {
            rbHispanicNo.Click();

            cbRace.Click();

            rbLimitedEnglishNo.Click();

            btnNext.Click();
        }
    }
}
