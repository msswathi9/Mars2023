using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mars2023.Utilities;
using Mars2023.Commondriver;

namespace Mars2023.Pages
{
    public class Loginpage 
    {
        //private IWebDriver driver;

        //public Loginpage(IWebDriver driver)
        //{
        //    this.driver = driver;
        //}

        //public Loginpage()
        //{
        //}

        private static IWebElement signInButton => CommonDriver.driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
        private static IWebElement userTextBox => CommonDriver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
        private static IWebElement passwordTextBox => CommonDriver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
        private static IWebElement loginButton => CommonDriver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));


        public static void loginActions()
        {

            //Open chrome Browser
           // driver = new ChromeDriver();

            CommonDriver.driver.Manage().Window.Maximize();

            //Launch Mars URL

            CommonDriver.driver.Navigate().GoToUrl("http://localhost:5000/Home");

            //Thread.Sleep(2000);
            //Wait.WaittobeClickable(driver, "Xpath", "//*[@id=\"home\"]/div/div/div[1]/div/a", 5);
            //signInButton.Click();

            //Wait.WaittobeClickable(driver, "Xpath", "/html/body/div[2]/div/div/div[1]/div/div[1]/input", 5);
            //userTextBox.SendKeys("msswathi9@gmail.com");

            //Wait.WaittobeClickable(driver, "Xpath", "/html/body/div[2]/div/div/div[1]/div/div[2]/input", 5);
            //passwordTextBox.SendKeys("Abcd@123");

            //Wait.WaittobeClickable(driver, "Xpath", "/html/body/div[2]/div/div/div[1]/div/div[4]/button", 5);
            //Thread.Sleep(2000);
            //loginButton.Click();


        }
        public static void SigninButton()
        {
           // Thread.Sleep(2000);
            Wait.WaittobeClickable(CommonDriver.driver, "Xpath", "//*[@id=\"home\"]/div/div/div[1]/div/a", 5);
            signInButton.Click();
        }
        public static void UserTextBox()
        {
            Wait.WaittobeClickable(CommonDriver.driver, "Xpath", "/html/body/div[2]/div/div/div[1]/div/div[1]/input", 5);
            userTextBox.SendKeys("msswathi9@gmail.com");
        }
        public static void PasswordTextBox()
        {
            Wait.WaittobeClickable(CommonDriver.driver, "Xpath", "/html/body/div[2]/div/div/div[1]/div/div[2]/input", 5);
            passwordTextBox.SendKeys("Abcd@123");
        }
        public static void LogInButton()
        {
            //Wait.WaittobeClickable(CommonDriver.driver, "Xpath", "/html/body/div[2]/div/div/div[1]/div/div[4]/button", 5);
            Thread.Sleep(2000);

            loginButton.Click();
        }
    }
}
