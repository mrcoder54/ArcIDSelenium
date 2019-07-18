using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumDriver.RoleManagement
{
    public class RoleMain
    {
        private PortalMain _main;
        private ChromeDriver _driver;
        public RoleMain(PortalMain main)
        {
            //main is passed in, in the instance that the application needs to be 
            //logged back into again.
            _main = main;
            _driver = main.GetDriver();
        }

        public void NavigateToRoleManagement()
        {
            
        }

        public void ReLogin()
        {
            
        }
    }
}
