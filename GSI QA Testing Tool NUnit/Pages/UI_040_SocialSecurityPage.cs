using GSI_QA_Testing_Tool_NUnit.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit.Pages
{
    public class UI_040_SocialSecurityPage : BasePage
    {
        By txtSSN = By.Id("ctl00_Main_content_Wizard1_ucSSN_txtSSN");
        By txtSSNReenter = By.Id("ctl00_Main_content_Wizard1_ucSSN_txtSSNReenter");
        By btnNext = By.Id("ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton");      

        public UI_040_SocialSecurityPage EnterSSN(String ssn)
        {
            txtSSN.SendKeys(ssn);
            return this;
        }

        public UI_040_SocialSecurityPage ReEnterSSN(String ssn)
        {
            txtSSNReenter.SendKeys(ssn);
            return this;
        }

        public UI_045_WorkHistoryVerification ClickNextButton()
        {
            btnNext.Click();
            return new UI_045_WorkHistoryVerification();
        }
    }
}
