using System;
using OpenQA.Selenium.Chrome;

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
