using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mars2023.Commondriver;
using System.Data;
using NUnit.Framework;

namespace Mars2023.Pages
{
    public class ProfilePage
    {
        public void Education(IWebDriver driver)
        {

            //Wait.WaittobeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]", 5);
            //Identify education page and click
            Thread.Sleep(5000);
            IWebElement educationpage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            educationpage.Click();

            Wait.WaittobeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div", 5);
            //Identify add new button and click
            IWebElement addNewbutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            addNewbutton.Click();

            Wait.WaittobeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input", 5);
            //Identify collage/university name text box and enter info
            IWebElement collageTextBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
            collageTextBox.Click();
            collageTextBox.SendKeys("hjdjf");


            Wait.WaittobeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select", 5);
            //Identify country of collage/university dropdown and click
            IWebElement countryOfCollageDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));
            countryOfCollageDropdown.Click();

            //select country
            SelectElement element = new SelectElement(countryOfCollageDropdown);
            element.SelectByValue("India");

            Wait.WaittobeClickable(driver, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select", 5);
            // Identify title dropdown box and choose option
            IWebElement titleDropDownbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));
            titleDropDownbox.Click();
            SelectElement element1 = new SelectElement(titleDropDownbox);
            element1.SelectByValue("B.Sc");

            Wait.WaittobeClickable(driver, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input", 5);
            //Identify degree text box and give info
            IWebElement degreeTextBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));
          
            degreeTextBox.SendKeys("Bachelor's Degree");

            Wait.WaittobeClickable(driver, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select", 5);
            //Identify year of graduation dropdown box and choose option
            IWebElement yearOfGraduationdropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));
            yearOfGraduationdropdown.Click();                                                                       
            SelectElement element2 = new SelectElement(yearOfGraduationdropdown);
            element2.SelectByValue("2008");

            Wait.WaittobeClickable(driver, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]", 5);
            //Identify add button and click
            IWebElement addButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
            addButton.Click();
        }
               
        public void Editeducation(IWebDriver driver)
        {
            //Wait.WaittobeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]", 5);
            //Identify education page and click
            Thread.Sleep(5000);
            IWebElement educationpage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            educationpage.Click();

            //Identify edit button and click

            Wait.WaittobeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[1]/i", 5);
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[1]/i"));
            editButton.Click();

            //Identify edit collage/ univercity name text box

            Wait.WaittobeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[1]/input", 5);
            IWebElement editCollageName = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[1]/input"));
            editCollageName.Clear();  
            editCollageName.SendKeys("fdhfh");

            //Identify edit country drop down box and choose option

            Wait.WaittobeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[2]/select", 5);
            IWebElement editCountryDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[2]/select"));
            editCountryDropdown.Click();
            SelectElement element = new SelectElement(editCountryDropdown);
            element.SelectByValue("Australia");

            //Identify edit title dropdown and choose option

            Wait.WaittobeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[1]/select", 5);
            IWebElement editTitleDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[1]/select"));
            editTitleDropdown.Click();
            SelectElement element1 = new SelectElement(editTitleDropdown);
            element1.SelectByValue("M.B.A");

            //Identify Edit degree text box and give info

            Wait.WaittobeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[2]/input", 5);
            IWebElement editDegreeTextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[2]/input"));
            editDegreeTextbox.Clear();
            editDegreeTextbox.SendKeys("Master's Degree");

            //Identify edit year of graduation dropdown and Choose option

            Wait.WaittobeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[3]/select", 5);
            IWebElement editYearOfGraduation = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[3]/select"));
            editYearOfGraduation.Click();
            SelectElement element3 = new SelectElement(editYearOfGraduation);
            element3.SelectByValue("2010");

            //Identify update button and click

            Wait.WaittobeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[3]/input[1]", 5);
            IWebElement updateButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[3]/input[1]"));
            updateButton.Click();

        }
        
        public void DeleteEducationrecord(IWebDriver driver)
        {
            // Wait.WaittobeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]", 5);
            //Identify education page and click
            Thread.Sleep(5000);
            IWebElement educationpage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            educationpage.Click();

            //Identify delete button and click

            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[2]/i"));
            deleteButton.Click();
        }
        public string GetAlertWindow(IWebDriver driver)
        {
            Thread.Sleep(2000);
            //Wait.WaittobeClickable(driver, "XPath", "/html/body/div[1]", 5);
            IWebElement alertWindow = driver.FindElement(By.XPath("/html/body/div[1]"));
            return alertWindow.Text;
        }
    }

}
