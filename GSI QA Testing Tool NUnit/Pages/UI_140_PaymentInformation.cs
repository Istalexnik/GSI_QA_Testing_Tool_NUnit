using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit.Pages
{
    public class UI_140_PaymentInformation
    {
        By rbPaymentMethodDC = By.Id("ctl00_Main_content_ucUIPayment_rblPaymentMethod_1");
        
        By cbAcknowledg = By.Id("ctl00_Main_content_ucUIPayment_cbdebitcardack");

        By cbAcknowledgLong = By.Id("ctl00_Main_content_ucUIPayment_cbdebitcardacklongform");

        By btnOk = By.Id("btn-dialog-ok");

        By rbFederalTaxYes = By.Id("ctl00_Main_content_ucPaymentDeductions_rblFederalTaxWithheld_0");
        
        By rbStateTaxYes = By.Id("ctl00_Main_content_ucPaymentDeductions_rblStateTaxWithheld_0");
        
        By rbSnapNo = By.Id("ctl00_Main_content_ucPaymentDeductions_rblSNAPOverpayment_1");
 
        By btnNext = By.Id("ctl00_Main_content_btnNext");
        public UI_140_PaymentInformation()
        {
            rbPaymentMethodDC.Click();

            cbAcknowledg.IsPresent()?.Click();

            cbAcknowledgLong.IsPresent()?.Click();

            btnOk.Click();

            rbFederalTaxYes.Click();

            rbStateTaxYes.Click();

            rbSnapNo.IsPresent()?.Click();

            btnNext.Click();
        }
    }
}
