using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit.Pages
{
    public class UI_030_UnemploymentInsuranceCompemsation
    {
        By rbFilingUI = By.CssSelector("label[for='ctl00_Main_content_radFilingUI_0']");
        By btnNext = By.Id("ctl00_Main_content_btnNext");

        public UI_030_UnemploymentInsuranceCompemsation()
        {
            rbFilingUI.Click();

            btnNext.Click();
        }

    }
}
