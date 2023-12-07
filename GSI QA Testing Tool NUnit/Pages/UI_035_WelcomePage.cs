﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_Testing_Tool_NUnit.Pages
{
    public class UI_035_WelcomePage
    {
        By btnNext = By.Id("ctl00_Main_content_Wizard1_StartNavigationTemplateContainerID_StartNextButton");

        By btnLogOut = By.Id("ctl00_hlNotRegistered2");
        By btnHome = By.Id("ctl00_Main_content_Button2");
        

        public UI_035_WelcomePage()
        {
            //PA workaround  when the user is not logged out
            try
            {
                btnNext.Click();
            } 
            catch (OpenQA.Selenium.NoSuchElementException)
            {
                btnLogOut.Click();
                btnHome.Click();

                new UI_005_HomePage();
            }
        }
    }
}
