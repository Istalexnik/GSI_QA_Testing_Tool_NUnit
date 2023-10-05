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
        By rbDidYouWork = By.CssSelector("label[for='ctl00_Main_content_Wizard1_rblWorkHistoryVerify_0']");
        By btnNext = By.Id("ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton");

        public UI_045_WorkHistoryVerification()
        {
            rbDidYouWork.Click();

            btnNext.Click();

        }
    }
}
