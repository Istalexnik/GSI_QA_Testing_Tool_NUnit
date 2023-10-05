using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit.Pages
{
    public class UI_125_JobTitle
    {
        By txtJobTitle = By.Id("ctl00_Main_content_ucJobTitleToOcc_txtJobTitle");

        By txtSuggestions = By.Id("ac_results");

        By ddJobOccupation = By.Id("ctl00_Main_content_ucJobTitleToOcc_ONETDropDownList");

        By btnNext = By.Id("ctl00_Main_content_btnNext");

        public UI_125_JobTitle()
        {
            txtJobTitle.EnterText("Test", txtSuggestions);

            WaitForSuggestions(ddJobOccupation).SelectDropdownByIndex("1");

            btnNext.Click();
        }
    }
}
