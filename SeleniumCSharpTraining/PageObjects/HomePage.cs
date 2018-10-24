using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpTraining.PageObjects
{
    public class HomePage
    {
        private readonly IWebDriver driver;

        public HomePage(IWebDriver driver) => this.driver = driver;

        IWebElement 

        public ContactUsPage clickOnContactUs()
        {
            return new ContactUsPage();
        }
    }
}
