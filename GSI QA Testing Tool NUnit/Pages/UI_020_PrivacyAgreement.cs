using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit.Pages
{
    public class UI_020_PrivacyAgreement
    {
        By btnAgree = By.Id("ctl00_Main_content_ucPrivacyAgreement_btnAgree");


        public UI_025_IndividualRegistrationType ClickIAgreeButton()
        {
            btnAgree.Click();
            return new UI_025_IndividualRegistrationType();
        }
    }
}
