using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumDriver
{
    public class PortalMain
    {
        private ChromeDriver driver;
        private string username;
        private string password;

        public PortalMain(string url, string username, string password)
        {
            this.username = username;
            this.password = password;

            var option = new ChromeOptions();
            option.AddArguments("ignore-certificate-errors");

            driver = new ChromeDriver(option);
            driver.Navigate().GoToUrl(url);
        }

        public ChromeDriver GetDriver()
        {
            return driver;
        }
        public bool Logon()
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));

                var usernameElement = driver.FindElementByName("uname");
                usernameElement.SendKeys(username);

                var passwordElement = driver.FindElementByName("psw");
                passwordElement.SendKeys(password);

                var logonButton = driver.FindElementByXPath("//*[contains(text(), 'Log On')]");
                logonButton.Click();

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("welcome-user")));

                //TODO: Add logic to change password on first log on
                return true;
            }
            catch { return false; }
           
        }

        public void Close()
        {
            driver.Quit();
        }

    }
}
