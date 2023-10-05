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

        By btnNext = By.Id("ctl00_Main_content_btnNext");
        public UI_135_MilitaryInformation()
        {
            rbSpouseNo.Click();

            rbVeteranNo.Click();

            btnNext.Click();
        }
    }
}
