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
    public class ProfilePage : CommonDriver
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
        private IWebElement educationpage => driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
       private IWebElement addNewbutton => driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
        
        private IWebElement collageTextBox => driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));

        private IWebElement countryOfCollageDropdown => driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));

        private IWebElement titleDropDownbox => driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));
        private IWebElement degreeTextBox => driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));

        private IWebElement yearOfGraduationdropdown => driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));

        private IWebElement addButton => driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));

        //Edit education record elements xpaths

        private IWebElement editButton => driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[1]/i"));
        private IWebElement editCollageName => driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[1]/input"));

        private IWebElement editCountryDropdown => driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[2]/select"));

        private IWebElement editTitleDropdown => driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[1]/select"));

        private IWebElement editDegreeTextbox => driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[2]/input"));

        private IWebElement editYearOfGraduation => driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[3]/select"));

        private IWebElement updateButton => driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[3]/input[1]"));

        private IWebElement deleteButton => driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[2]/i"));

        private IWebElement alertWindow => driver.FindElement(By.XPath("/html/body/div[1]"));

        public void GotoEducation(IWebDriver driver)
        {
            //Wait.WaittobeClickable(driver, "Xpath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]", 5);
            Thread.Sleep(2000);
             educationpage.Click();
        }
        public void ClickAddNewButton(IWebDriver driver)
        {
            Wait.WaittobeClickable(driver, "Xpath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div", 5);
            Thread.Sleep(2000);
            addNewbutton.Click();
        }
        public void AddCollage(IWebDriver driver)
        {
            Wait.WaittobeClickable(driver, "Xpath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input", 5);
            collageTextBox.Click();
            collageTextBox.SendKeys("hjdjf");
        }
        public void SelectCountryOfCollage(IWebDriver driver)
        {
            Wait.WaittobeClickable(driver, "Xpath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select", 5);
            countryOfCollageDropdown.Click();

            //select country
            SelectElement element = new SelectElement(countryOfCollageDropdown);
            element.SelectByValue("India");
        }
        public void SelectTitle(IWebDriver driver)
        {
            Wait.WaittobeClickable(driver, "Xpath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select", 5);
            titleDropDownbox.Click();
            SelectElement element1 = new SelectElement(titleDropDownbox);
            element1.SelectByValue("B.Sc");
        }
        public void AddDegree(IWebDriver driver)
        {
            Wait.WaittobeClickable(driver, "Xpath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input", 5);
            degreeTextBox.SendKeys("Bachelor's Degree");
        }

        public void SelectYearofGraduation(IWebDriver driver)
        {
            Wait.WaittobeClickable(driver, "Xpath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select", 5);
            yearOfGraduationdropdown.Click();
            SelectElement element2 = new SelectElement(yearOfGraduationdropdown);
            element2.SelectByValue("2008");
        }
        public void Addbutton(IWebDriver driver)
        {
            Wait.WaittobeClickable(driver, "Xpath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]", 5);
            addButton.Click();
        }      
        public void EditRecordIcon(IWebDriver driver)
        {
            Wait.WaittobeClickable(driver, "Xpath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[1]/i", 5);
            editButton.Click();
        }
        public void EditCollageTextBox(IWebDriver driver)
        {
            Wait.WaittobeClickable(driver, "Xpath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[1]/input", 5);
            editCollageName.Clear();
            editCollageName.SendKeys("fdhfh");
        }
        public void EditCountryDropdown(IWebDriver driver)
        {
            Wait.WaittobeClickable(driver, "Xpath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[2]/select", 5);
            editCountryDropdown.Click();
            SelectElement element = new SelectElement(editCountryDropdown);
            element.SelectByValue("Australia");
        }
        public void EditTitleDropDown(IWebDriver driver)
        {
            Wait.WaittobeClickable(driver, "Xpath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[1]/select", 5);
            editTitleDropdown.Click();
            SelectElement element1 = new SelectElement(editTitleDropdown);
            element1.SelectByValue("M.B.A");
        }
        public void EditDegreeTextBox(IWebDriver driver)
        {

            Wait.WaittobeClickable(driver, "Xpath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[2]/input", 5);
            editDegreeTextbox.Clear();
            editDegreeTextbox.SendKeys("Master's Degree");
        }
        public void EditYearofGraduation(IWebDriver driver)
        {
            Wait.WaittobeClickable(driver, "Xpath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[3]/select", 5);
            editYearOfGraduation.Click();
            SelectElement element3 = new SelectElement(editYearOfGraduation);
            element3.SelectByValue("2010");
        }
        public void UpdateButton(IWebDriver driver)
        {
            Wait.WaittobeClickable(driver, "Xpath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[3]/input[1]", 5);
            updateButton.Click();
        }
        

        public void DeleteEducationrecord(IWebDriver driver)
        {
            Wait.WaittobeClickable(driver, "Xpath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[2]/i", 5);
            Thread.Sleep(3000);
            //Identify delete button and click    
            deleteButton.Click();
        }
        public string GetAlertWindow(IWebDriver driver)
        {
           
            Thread.Sleep(2000);
            //Wait.WaittobeClickable(driver, "XPath", "/html/body/div[1]", 5);
            
            return alertWindow.Text;
        }
    }

}
