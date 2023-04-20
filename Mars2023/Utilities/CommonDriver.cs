using Mars2023.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars2023.Utilities
{
   
        public class CommonDriver
        {
            public IWebDriver driver;
            [SetUp]
            public void LoginSteps()
            {
                driver = new ChromeDriver();

                // Login Page object initialization and defination
                Loginpage logInPageobj = new Loginpage(driver);
                logInPageobj.loginActions(driver);

            }
            [TearDown]
            public void CloseTestRun()
            {
                driver.Quit();
            }
        }
}


