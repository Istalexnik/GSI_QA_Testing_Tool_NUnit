using GSI_QA_Testing_Tool_NUnit.Data;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit.Pages
{
    public class UI_145_UnemploymentCompensation
    {
        By btnNext = By.Id("ctl00_Main_content_btnRegistrationCompleteUIEmploymentHistory");
        public UI_145_UnemploymentCompensation()
        {
            if (new[] { "PFL" }.Any(site => TestData.Site.Contains(site))) { return; }

            btnNext.Click();
        }
    }
}
