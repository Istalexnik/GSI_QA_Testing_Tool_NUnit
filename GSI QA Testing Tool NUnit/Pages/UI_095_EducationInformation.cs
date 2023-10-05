using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit.Pages
{
    public class UI_095_EducationInformation
    {
        By ddHighestLevelEducation = By.Id("ctl00_Main_content_ucEducation_ddlIndEduLevel");
        By ddAttendingSchool = By.Id("ctl00_Main_content_ucEducation_ddlSchoolStatus");
        By btnNext = By.Id("ctl00_Main_content_btnNext");

        public UI_095_EducationInformation()
        {
            ddHighestLevelEducation.SelectDropdownByIndex("1");

            ddAttendingSchool.SelectDropdownByValue("4");

            btnNext.Click();

        }
    }
}
