using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit.Pages
{
    public class UI_180_EmploymentHistoryBeforeFirst
    {
        By rbAddEmployerYes = By.Id("ctl00_Main_content_rblAddAnotherEntry_0");

        By btnNext = By.Id("ctl00_Main_content_btnNext");
        public UI_180_EmploymentHistoryBeforeFirst()
        {
            rbAddEmployerYes.Click();

            btnNext.Click();
        }
    }
}
