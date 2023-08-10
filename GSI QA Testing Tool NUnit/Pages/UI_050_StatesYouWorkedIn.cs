using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit.Pages
{
    public class UI_050_StatesYouWorkedIn 
    {
        By rbnWorkedInTwoStates = By.CssSelector("label[for='ctl00_Main_content_Wizard1_rblStatesWorkedIn_1']");
        By rbnClaimedUnemployment = By.CssSelector("label[for='ctl00_Main_content_Wizard1_rblAppliedUCPast12Months_1']");
        By btnNext = By.Id("ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton");

        public UI_050_StatesYouWorkedIn ClickWorkedInTwoStatesRButton()
        {
            rbnWorkedInTwoStates.Click();
            return this;
        }   
        
        public UI_050_StatesYouWorkedIn ClickClaimedUnemploymentRButton()
        {
            rbnClaimedUnemployment.Click();
            return this;
        }

        public UI_055_FederalService ClickNextButton()
        {
            btnNext.Click();
            return new UI_055_FederalService();
        }

    }
}
