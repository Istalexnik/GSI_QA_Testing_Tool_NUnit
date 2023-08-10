using GSI_QA_Testing_Tool_NUnit.Data;
using GSI_QA_Testing_Tool_NUnit.Pages;
using GSI_QA_Testing_Tool_NUnit.Utilities;
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
        TestData testData = new TestData();

        [Test]
        public void TestRegistration()
        {
            UI_010_LoginIntroPage loginIntroPage = new UI_005_HomePage()
                .ClickLoginButton();
            UI_015_EqualOpportunity equalOpportunity = loginIntroPage
                .ClickIndividualRegistrationButton();
            UI_020_PrivacyAgreement privacyAgreement = equalOpportunity
                .ClickIAgreeButton();
            UI_025_IndividualRegistrationType individualRegistrationType = privacyAgreement
                .ClickIAgreeButton();
            UI_030_UnemploymentInsuranceCompemsation unemploymentInsuranceCompemsation = individualRegistrationType
                .ClickComprehensiveRegistrationLink();
            UI_035_WelcomePage welcomePage = unemploymentInsuranceCompemsation
                .ClickAttemptingToFileRButton()
                .ClickNextButton();
            UI_040_SocialSecurityPage socialSecurityPage = welcomePage
                .ClickNextButton();
            UI_045_WorkHistoryVerification workHistoryVerification = socialSecurityPage
                .EnterSSN(testData.SSN)
                .ReEnterSSN(testData.SSN)
                .ClickNextButton();
            UI_050_StatesYouWorkedIn statesYouWorkedIn = workHistoryVerification
                .ClickDidYouWorkYesRButton()
                .ClickNextButton();
            UI_055_FederalService federalService = statesYouWorkedIn
                .ClickWorkedInTwoStatesRButton()
                .ClickClaimedUnemploymentRButton()
                .ClickNextButton();
        }
    }
}
