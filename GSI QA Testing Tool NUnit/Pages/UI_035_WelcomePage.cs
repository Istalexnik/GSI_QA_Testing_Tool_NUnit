using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit.Pages
{
    public class UI_035_WelcomePage : BasePage
    {
        By btnNext = By.Id("ctl00_Main_content_Wizard1_StartNavigationTemplateContainerID_StartNextButton");

        public UI_040_SocialSecurityPage ClickNextButton()
        {
            btnNext.Click();
            return new UI_040_SocialSecurityPage();
        }
    }
}
