using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit.Pages
{
    public class UI_025_IndividualRegistrationType 
    {
        By lnkRegistration = By.Id("ctl00_Main_content_lnkCompleteHeader");

        public UI_030_UnemploymentInsuranceCompemsation ClickComprehensiveRegistrationLink()
        {
            lnkRegistration.JSClick();
            return new UI_030_UnemploymentInsuranceCompemsation();
        }
    }
}
