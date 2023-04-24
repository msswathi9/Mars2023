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
using Mars2023.Utilities;

namespace Mars2023.Pages
{
    public class ProfilePage 
    {

        //IWebDriver driver;
        //   public ProfilePage(IWebDriver driver)
        //   {
        //    this.driver = driver;
        //    }

        //public ProfilePage()
        //{
        //}

        //Create education crecord element xpaths
        private static IWebElement educationpage => CommonDriver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
       private static IWebElement addNewbutton => CommonDriver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
        
        private static IWebElement collageTextBox => CommonDriver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));

        private static IWebElement countryOfCollageDropdown => CommonDriver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));

        private static IWebElement titleDropDownbox => CommonDriver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));
        private static IWebElement degreeTextBox => CommonDriver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));

        private static IWebElement yearOfGraduationdropdown => CommonDriver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));

        private static IWebElement addButton => CommonDriver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));

        //Edit education record elements xpaths

        private static IWebElement editButton => CommonDriver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[1]/i"));
        private static IWebElement editCollageName => CommonDriver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[1]/input"));

        private static IWebElement editCountryDropdown => CommonDriver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[2]/select"));

        private static IWebElement editTitleDropdown => CommonDriver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[1]/select"));

        private static IWebElement editDegreeTextbox => CommonDriver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[2]/input"));

        private static IWebElement editYearOfGraduation => CommonDriver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[3]/select"));

        private static IWebElement updateButton => CommonDriver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[3]/input[1]"));

        private static IWebElement deleteButton => CommonDriver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[2]/i"));

        private static IWebElement alertWindow => CommonDriver.driver.FindElement(By.XPath("/html/body/div[1]"));

        public static void GotoEducation()
        {
            //Wait.WaittobeClickable(driver, "Xpath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]", 5);
            Thread.Sleep(2000);
             educationpage.Click();
        }
        public static void ClickAddNewButton()
        {
            Wait.WaittobeClickable(CommonDriver.driver, "Xpath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div", 5);
            Thread.Sleep(2000);
            addNewbutton.Click();
        }
        public static void AddCollage()
        {
            Wait.WaittobeClickable(CommonDriver.driver, "Xpath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input", 5);
            collageTextBox.Click();
            collageTextBox.SendKeys("hjdjf");
        }
        public static void SelectCountryOfCollage()
        {
            Wait.WaittobeClickable(CommonDriver.driver, "Xpath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select", 5);
            countryOfCollageDropdown.Click();

            //select country
            SelectElement element = new SelectElement(countryOfCollageDropdown);
            element.SelectByValue("India");
        }
        public static void SelectTitle()
        {
            Wait.WaittobeClickable(CommonDriver.driver, "Xpath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select", 5);
            titleDropDownbox.Click();
            SelectElement element1 = new SelectElement(titleDropDownbox);
            element1.SelectByValue("B.Sc");
        }
        public static void AddDegree()
        {
            Wait.WaittobeClickable(CommonDriver.driver, "Xpath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input", 5);
            degreeTextBox.SendKeys("Bachelor's Degree");
        }

        public static void SelectYearofGraduation()
        {
            Wait.WaittobeClickable(CommonDriver.driver, "Xpath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select", 5);
            yearOfGraduationdropdown.Click();
            SelectElement element2 = new SelectElement(yearOfGraduationdropdown);
            element2.SelectByValue("2008");
        }
        public static void Addbutton()
        {
            Wait.WaittobeClickable(CommonDriver.driver, "Xpath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]", 5);
            addButton.Click();
        }      
        public static void EditRecordIcon()
        {
            Wait.WaittobeClickable(CommonDriver.driver, "Xpath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[1]/i", 5);
            editButton.Click();
        }
        public static void EditCollageTextBox()
        {
            Wait.WaittobeClickable(CommonDriver.driver, "Xpath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[1]/input", 5);
            editCollageName.Clear();
            editCollageName.SendKeys("fdhfh");
        }
        public static void EditCountryDropdown()
        {
            Wait.WaittobeClickable(CommonDriver.driver, "Xpath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[2]/select", 5);
            editCountryDropdown.Click();
            SelectElement element = new SelectElement(editCountryDropdown);
            element.SelectByValue("Australia");
        }
        public static void EditTitleDropDown()
        {
            Wait.WaittobeClickable(CommonDriver.driver, "Xpath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[1]/select", 5);
            editTitleDropdown.Click();
            SelectElement element1 = new SelectElement(editTitleDropdown);
            element1.SelectByValue("M.B.A");
        }
        public static void EditDegreeTextBox()
        {

            Wait.WaittobeClickable(CommonDriver.driver, "Xpath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[2]/input", 5);
            editDegreeTextbox.Clear();
            editDegreeTextbox.SendKeys("Master's Degree");
        }
        public static void EditYearofGraduation()
        {
            Wait.WaittobeClickable(CommonDriver.driver, "Xpath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[3]/select", 5);
            editYearOfGraduation.Click();
            SelectElement element3 = new SelectElement(editYearOfGraduation);
            element3.SelectByValue("2010");
        }
        public static void UpdateButton()
        {
            Wait.WaittobeClickable(CommonDriver.driver, "Xpath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[3]/input[1]", 5);
            updateButton.Click();
        }
        

        public static void DeleteEducationrecord()
        {
            Wait.WaittobeClickable(CommonDriver.driver, "Xpath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[2]/i", 5);
            Thread.Sleep(3000);
            //Identify delete button and click    
            deleteButton.Click();
        }
        public static string GetAlertWindow()
        {
           
            Thread.Sleep(2000);
            //Wait.WaittobeClickable(CommonDriver.driver, "XPath", "/html/body/div[1]", 5);
            
            return alertWindow.Text;
        }
    }

}
