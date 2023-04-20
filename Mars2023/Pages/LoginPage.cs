using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mars2023.Utilities;

namespace Mars2023.Pages
{
    public class Loginpage : CommonDriver
    {
        public Loginpage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public Loginpage()
        {
        }

        // IWebDriver driver;
        // public Loginpage(IWebDriver driver)
        //{
        // this.driver = driver;
        //}

        private IWebElement signInButton => driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
        private IWebElement userTextBox => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
        private IWebElement passwordTextBox => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
        private IWebElement loginButton => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));


        public void loginActions(IWebDriver driver)
        {

            //Open chrome Browser
           // driver = new ChromeDriver();

            driver.Manage().Window.Maximize();

            //Launch Mars URL

            driver.Navigate().GoToUrl("http://localhost:5000/Home");

            Thread.Sleep(2000);
            //signInButton.Click();
            //userTextBox.SendKeys("msswathi9@gmail.com");
            //passwordTextBox.SendKeys("Abcd@123");
            //loginButton.Click();


        }       
        public void SigninButton(IWebDriver driver)
        {
          signInButton.Click();
        }
        public void UserTextBox(IWebDriver driver)
        {
           userTextBox.SendKeys("msswathi9@gmail.com");
        }
        public void PasswordTextBox(IWebDriver driver)
        {
          passwordTextBox.SendKeys("Abcd@123");
        }
        public void LogInButton(IWebDriver driver)
        {
         loginButton.Click();
        }
    }
}
