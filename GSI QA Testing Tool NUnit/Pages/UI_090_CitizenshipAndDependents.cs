using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit.Pages
{
    public class UI_090_CitizenshipAndDependents
    {
        By rbDependents = By.Id("ctl00_Main_content_ucDemographics_rblDependents_1");
        By ddCitizenship = By.Id("ctl00_Main_content_ucDemographics_ddl_UI_Citizen");
        By rbDisability = By.Id("ctl00_Main_content_ucDemographics_rblDisability_1");
        By btnNext = By.Id("ctl00_Main_content_btnNext");

        public UI_090_CitizenshipAndDependents()
        {
            rbDependents.Click();
 
            ddCitizenship.SelectDropdownByIndex("1");

            rbDisability.Click();

            btnNext.Click();

        }
    }
}
