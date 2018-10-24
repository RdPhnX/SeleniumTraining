using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpTraining.PageObjects
{
    public abstract class AbstractPage
    {
        private RemoteWebDriver _driver;

        public AbstractPage(RemoteWebDriver driver) => _driver = driver;

        public IWebDriver getDriver()
        {
            return driver;
        }

        public HomePage navigateToWebApp()
        {
            driver.Url = https://www.phptravels.net/;
            return new HomePage(driver);
        }
    }
}
