using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumDriver
{
    public class PortalMain
    {
        private ChromeDriver driver;

        public PortalMain(string url)
        {
            var option = new ChromeOptions();
            option.AddArguments("ignore-certificate-errors");

            driver = new ChromeDriver(option);
            driver.Navigate().GoToUrl(url);
        }

        public bool Logon(string username, string password)
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

                return true;
            }
            catch { return false; }
           
        }

        public ChromeDriver Driver
        {
            get { return driver; }
        }

        public void Close()
        {
            driver.Quit();
        }

    }
}
