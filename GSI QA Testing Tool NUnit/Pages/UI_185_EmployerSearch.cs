using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit.Pages
{
    public class UI_185_EmployerSearch
    {
        By txtEmployerName = By.Id("ctl00_Main_content_ucIndEmpHistory_txtFindEmployerName");

        By txtSuggestions = By.Id("ac_results");


        public UI_185_EmployerSearch()
        {
            txtEmployerName.EnterText(TestData.Employer, txtSuggestions);
        }
    }
}
