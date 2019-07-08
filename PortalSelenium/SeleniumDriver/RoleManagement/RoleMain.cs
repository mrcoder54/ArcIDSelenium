using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumDriver.RoleManagement
{
    public class RoleMain
    {
        private ChromeDriver driver;
        public RoleMain(ChromeDriver driver)
        {
            this.driver = driver;
        }

        public void NavigateToRoleManagement(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
    }
}
