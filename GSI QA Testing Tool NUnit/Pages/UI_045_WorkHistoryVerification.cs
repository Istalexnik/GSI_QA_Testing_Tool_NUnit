using GSI_QA_Testing_Tool_NUnit.Data;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit.Pages
{
    public class UI_045_WorkHistoryVerification
    {
        By rbDidYouWorkYes = By.CssSelector("label[for='ctl00_Main_content_Wizard1_rblWorkHistoryVerify_0']");
        By rbDidYouWorkNo = By.CssSelector("label[for='ctl00_Main_content_Wizard1_rblWorkHistoryVerify_1']");
        By btnNext = By.Id("ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton");

        public UI_045_WorkHistoryVerification()
        {
            if (!rbDidYouWorkYes.FindIt()) { return; }

            if (TestData.Type.Contains(7))
            {
                rbDidYouWorkNo.Click();
            }
            else
            {
                rbDidYouWorkYes.Click();
            }
            rbDidYouWorkYes.Click();


            btnNext.Click();

        }
    }
}
