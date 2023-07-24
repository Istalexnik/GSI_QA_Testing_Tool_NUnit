using GSI_QA_Testing_Tool_NUnit.Data;
using GSI_QA_Testing_Tool_NUnit.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit.Tests
{
    [TestFixture]
    public class RegistrationTest : BaseTest
    {
        [Test]
        public void TestRegistration()
        {
            UI_010_LoginIntroPage loginIntroPage = new UI_005_HomePage(Driver).ClickLoginButton();
            UI_015_EqualOpportunity equalOpportunity = loginIntroPage.ClickIndividualregistrationButton();
            UI_020_PrivacyAgreement privacyAgreement = equalOpportunity.ClickIAgreeButton();
            UI_025_IndividualRegistrationType individualRegistrationType = privacyAgreement.ClickIAgreeButton();

        }
    }
}
