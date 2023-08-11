using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit.Pages
{
    public class UI_060_MilitaryService
    {
        By rbMilitaryService = By.CssSelector("label[for='ctl00_Main_content_Wizard1_rblMilitaryService_1']");
        By btnNext = By.Id("ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton");

        public UI_060_MilitaryService ClickrbMilitaryService()
        {
            rbMilitaryService.Click();
            return this;
        }

        public UI_065_LoginInformation ClickbtnNext()
        {
            btnNext.Click();
            return new UI_065_LoginInformation();
        }
    }
}
