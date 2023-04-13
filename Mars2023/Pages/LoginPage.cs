using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars2023.Pages
{
    public class Loginpage
    {
        public void loginActions(IWebDriver driver)
        {

            //Open chrome Browser
           // driver = new ChromeDriver();

            driver.Manage().Window.Maximize();

            //Launch Mars URL

            driver.Navigate().GoToUrl("http://localhost:5000/Home");

            //Identify signin button and click

            IWebElement signInButton = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
            signInButton.Click();

            //Identify user text box and enter valid username

            IWebElement userTextBox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
            userTextBox.SendKeys("msswathi9@gmail.com");

            //Identify password text box and enter valic password

            IWebElement passwordTextBox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
            passwordTextBox.SendKeys("Abcd@123");

            //Identify login button and click
            IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            loginButton.Click();
        }
    }
}
