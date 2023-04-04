using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mars2023.Commondriver;
using System.Data;

namespace Mars2023.Pages
{
    public class ProfilePage
    {

        public void AddDescription(IWebDriver driver)
        {
            // Identify description outline write button and click
            IWebElement descriptionOutlineButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
            descriptionOutlineButton.Click();

            //Identify descritption text box and enter information
            IWebElement descriptionTextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
            descriptionTextbox.SendKeys("Swathi Shetty");

            //Identify save button and click
            IWebElement saveButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
            saveButton.Click();

        }
        public string GetDescription(IWebDriver driver)
        {
            IWebElement actualDescription = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/span"));
            return actualDescription.Text;
        }
        public void editedDescription(IWebDriver driver)
        {
            // Identify description outline write button and click
            IWebElement descriptionOutlineButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
            descriptionOutlineButton.Click();

            // //Identify descritption text box and enter information
            IWebElement descriptionTextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
            descriptionTextbox.Clear();
            descriptionTextbox.SendKeys("Swathi Madham Shetty");

            //Identify save button and click
            IWebElement saveButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
            saveButton.Click();

        }
        //Check if description saved successfully or not
        public string GetEdiedDescription(IWebDriver driver)
        {
            IWebElement actualDescription = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/span"));
            return actualDescription.Text;
        }
        public void Skills(IWebDriver driver)
        {
            Thread.Sleep(6000);
            //Wait.WaittobeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 5);
            //Identify skills page and click
            IWebElement skillPage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillPage.Click();
            //Thread.Sleep(6000);

            //Identify add new button and click
            IWebElement addNewButton = driver.FindElement(By.XPath("<div class=\"ui teal button \">Add New</div>"));
            addNewButton.Click();

            //Identify add skill textbox and enter info
            IWebElement addSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            addSkill.SendKeys("Automation");

            //Identify choose skill level dropdown and click
            IWebElement chooseSkillDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            chooseSkillDropdown.Click();
            SelectElement element = new SelectElement(chooseSkillDropdown);
            element.SelectByValue("Beginner");


            //Identify add button and click
            IWebElement addButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            addButton.Click();
        }
        public string GetAddSkill(IWebDriver driver)
        {
            //Check weather add skill added successfully or not 
            IWebElement actualAddSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            return actualAddSkill.Text;
        }
        public string GetChooseSkill(IWebDriver driver)
        {
            //Check weather chooseskill is added successfully or not
            IWebElement actualChooseSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[2]"));
            return actualChooseSkill.Text;
        }

        public void Education(IWebDriver driver)
        {
            Wait.WaittobeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]", 5);
            //Identify education page and click
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
            // Identify title dropdown box and select option
            IWebElement titleDropDownbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));
           
            SelectElement element1 = new SelectElement(titleDropDownbox);
            element1.SelectByValue("M.B.A");

            Wait.WaittobeClickable(driver, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input", 5);
            //Identify degree text box and give info
            IWebElement degreeTextBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));
          
            degreeTextBox.SendKeys("Post Graduation");

            Wait.WaittobeClickable(driver, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select", 5);
            //Identify year of graduation dropdown box and choose option
            IWebElement yearOfGraduationdropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));
            
            SelectElement element2 = new SelectElement(yearOfGraduationdropdown);
            element2.SelectByValue("2010");

            Wait.WaittobeClickable(driver, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]", 5);
            //Identify add button and click
            IWebElement addButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
            addButton.Click();
        }
        //Check weather collage name is same as given name
        public string GetCollage(IWebDriver driver)
        {
            IWebElement actualcollage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
            return actualcollage.Text;
        }
        //Check weather country of collage name is same as given name
        public string GetCountryofcollage(IWebDriver driver)
        {
            IWebElement actualCountryofcollage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));
            return actualCountryofcollage.Text;
        }
        //Check weather title is same as given title
        public string GetTitle(IWebDriver driver)
        {
            IWebElement actualTitle = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));
            return actualTitle.Text;
        }
        //Check weather degree is same as given Degree
        public string GetDegree(IWebDriver driver)
        {
            IWebElement actualDegree = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));
            return actualDegree.Text;
        }
        //Check weather year of graduation is same as given year
        public string GetYearofGraduation(IWebDriver driver)
        {
            IWebElement actualYearofGraduation = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));
            return actualYearofGraduation.Text;
        }

        public void Certifications(IWebDriver driver)
        {
            Wait.WaittobeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 5);
            //Identify certification tab and click
            IWebElement certificationsPage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            certificationsPage.Click();

            //Identify add new button and click
            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
            addNewButton.Click();

            //Identify certificate or award text box and give input
            IWebElement certificateTextBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input"));
            certificateTextBox.SendKeys("ISTQB");

            //Identify certificate from text box and give input
            IWebElement certificateFromTextBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));
            certificateFromTextBox.SendKeys("ISTQB");

            //Identify year dropdown button, click, and select
            IWebElement yearDropDown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select"));
            yearDropDown.Click();
            IWebElement yearSelect = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select/option[14]"));
            yearSelect.Click();
        }
        public string GetCertifications(IWebDriver driver)
        {
            //Check weather certificate is same as given 
            IWebElement actualcertificateTextBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input"));
            return actualcertificateTextBox.Text;
        }
        public string GetcertificateFrom(IWebDriver driver)
        {
            //Check weather certificate from is as given 
            IWebElement actualcertificateFrom = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));
            return actualcertificateFrom.Text;
        }
        public string Getyear(IWebDriver driver)
        {
            //Check weather year is same as given
            IWebElement actualYear = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select"));
            return actualYear.Text;
        }
        public void ShareSkill(IWebDriver driver)
        {
            //Identify shareskill button and Click
            IWebElement shareSkillButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/div[2]/a"));
            shareSkillButton.Click();

            //Identify tages text box and give input
            IWebElement tagesTextBox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));
            tagesTextBox.SendKeys("Testing");
            
            //

        }


    }

}
