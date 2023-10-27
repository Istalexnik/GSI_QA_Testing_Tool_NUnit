using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit.Pages
{
    public class UI_205_UnemploymentInsuranceClaimConfirmation
    {
        By btnNext = By.Id("ctl00_Main_content_btnCertifyClaim");
        public UI_205_UnemploymentInsuranceClaimConfirmation()
        {
            btnNext.Click();
        }
    }
}
