﻿using GSI_QA_Testing_Tool_NUnit.Data;
using GSI_QA_Testing_Tool_NUnit.Pages;
using GSI_QA_Testing_Tool_NUnit.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit.Tests
{

    public class RegistrationTest : BaseTest
    {
        [Test]
        public void TestRegistration()
        {

            new UI_005_HomePage();

            new UI_010_LoginIntroPage();

            new UI_015_EqualOpportunity();

            new UI_020_PrivacyAgreement();

            new UI_025_IndividualRegistrationType();

            new UI_030_UnemploymentInsuranceCompemsation();

            new UI_035_WelcomePage();

            new UI_040_SocialSecurityPage();

            new UI_045_WorkHistoryVerification();

            new UI_050_StatesYouWorkedIn();

            new UI_055_FederalService();

            new UI_060_MilitaryService();

            new UI_065_LoginInformation();

            new UI_070_NamePage();

            new UI_075_ResidentialAddress();

            new UI_080_PhoneNumber();

            new UI_085_NotficationMethod();

            new UI_090_CitizenshipAndDependents();

            new UI_095_EducationInformation();

            new UI_100_EmploymentInformation();

            new UI_105_EmploymentStatus();

            new UI_110_EmploymentMiscellaneous();

            new UI_115_MajorDisaster();

            new UI_120_LaborUnion();
        }
    }
}
