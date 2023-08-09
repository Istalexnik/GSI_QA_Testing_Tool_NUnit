using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit.Pages
{
    public class UI_030_UnemploymentInsuranceCompemsation : BasePage
    {
        By radFilingUI = By.CssSelector("label[for='ctl00_Main_content_radFilingUI_0']");
        By btnNext = By.Id("ctl00_Main_content_btnNext");
        public UI_030_UnemploymentInsuranceCompemsation(IWebDriver driver) : base(driver) { }

        public UI_030_UnemploymentInsuranceCompemsation ClickAttemptingToFileRButton()
        {
            radFilingUI.WaitForElementToBeClickable().Click();
            return this;
        }

        public UI_035_WelcomePage ClickNextButton()
        {
            btnNext.WaitForElementToBeClickable().Click();
            return new UI_035_WelcomePage(Driver);
        }

    }
}
