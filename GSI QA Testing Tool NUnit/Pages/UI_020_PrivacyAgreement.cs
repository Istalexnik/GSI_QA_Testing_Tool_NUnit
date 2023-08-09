using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit.Pages
{
    public class UI_020_PrivacyAgreement : BasePage
    {
        By btnAgree = By.Id("ctl00_Main_content_ucPrivacyAgreement_btnAgree");

        public UI_020_PrivacyAgreement(IWebDriver driver) : base(driver) { }

        public UI_025_IndividualRegistrationType ClickIAgreeButton()
        {
            btnAgree.WaitForElementToBeClickable(Driver).Click();
            return new UI_025_IndividualRegistrationType(Driver);
        }
    }
}
