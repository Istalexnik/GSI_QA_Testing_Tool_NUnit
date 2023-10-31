using GSI_QA_Testing_Tool_NUnit.Data;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit.Pages
{
    public class UI_180_EmploymentHistoryBeforeFirst
    {
        By rbAddEmployerYes = By.Id("ctl00_Main_content_rblAddAnotherEntry_0");

        By linkEdit = By.Id("ctl00_Main_content_ucIndEmpHistory_grdIndEmpHistory_ctl02_lnkEditAction");

        By btnNext = By.Id("ctl00_Main_content_btnNext");
        public UI_180_EmploymentHistoryBeforeFirst()
        {

            if (TestData.Type.Contains(2) || TestData.Type.Contains(3))
            {
                linkEdit.Click();
            }
            else
            {
                rbAddEmployerYes.Click();

                btnNext.Click();
            }
        }
    }
}
