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

        public void AddDescription(IWebDriver driver)
        {
            // Identify description outline write button and click
            Thread.Sleep(3000);
            IWebElement descriptionOutlineButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
            descriptionOutlineButton.Click();
            Thread.Sleep(3000);

            //Identify descritption text box and enter information
            IWebElement descriptionTextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
            descriptionTextbox.Clear();
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
            Wait.WaittobeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 5);
            //Identify skills page and click
            IWebElement skillPage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillPage.Click();
            //Thread.Sleep(6000);

            Wait.WaittobeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div", 5);
            //Identify add new button and click
            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewButton.Click();                                  

            Wait.WaittobeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/inpu", 5);
            //Identify add skill textbox and enter info
            IWebElement addSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            addSkill.SendKeys("Automation");

            Wait.WaittobeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select", 5);
            //Identify choose skill level dropdown and click
            IWebElement chooseSkillDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            chooseSkillDropdown.Click();
            SelectElement element = new SelectElement(chooseSkillDropdown);
            element.SelectByValue("Beginner");

            Wait.WaittobeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]", 5);
            //Identify add button and click
            IWebElement addButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            addButton.Click();
        }
        public string GetAddSkill(IWebDriver driver)
        {
            //Check weather add skill added successfully or not 
            IWebElement actualAddSkill = driver.FindElement(By.XPath(" //*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[1]"));
            return actualAddSkill.Text;                              
        }
        public string GetChooseSkill(IWebDriver driver)
        {
            //Check weather chooseskill is added successfully or not
            IWebElement actualChooseSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[2]"));
            return actualChooseSkill.Text;                               
        }
        public void Editskill(IWebDriver driver)
        {

            Wait.WaittobeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 5);
            //Identify skills page and click
            IWebElement skillPage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillPage.Click();

            //Identify newly created skill record edit button and click
            IWebElement SkillRecordEditButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last]/tr/td[3]/span[1]/i"));
            SkillRecordEditButton.Click();

            //identify add skill text box and enter new info
            IWebElement addnewSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[2]/tr/td/div/div[1]/input"));
            addnewSkill.Clear();
            addnewSkill.SendKeys("Testing");

            //Identify choose Skill level and click
            IWebElement chooseSkillLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[2]/tr/td/div/div[2]/select"));
            chooseSkillLevel.Click();
            IWebElement chooseSkillLevel1 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[2]/tr/td/div/div[2]/select/option[4]"));
            chooseSkillLevel1.Click();

            //Identify update button and click
            IWebElement updateButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[2]/tr/td/div/span/input[1]"));
            updateButton.Click();
        }
        public string GeteditedAddSkill(IWebDriver driver)
        {
            //Check weather add skill added successfully or not 
            IWebElement actualAddSkill = driver.FindElement(By.XPath(" //*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[1]"));
            return actualAddSkill.Text;
        }
        public string GeteditedChooseSkill(IWebDriver driver)
        {
            //Check weather chooseskill is added successfully or not
            IWebElement actualChooseSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[2]"));
            return actualChooseSkill.Text;
        }
        public void DeleteSkill(IWebDriver driver)
        {
            //Identify new record skill
            IWebElement newRecordskill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]/i"));
            newRecordskill.Click();
        }

        public string Getdelete(IWebDriver driver)
        {
            IWebElement actualDelete = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]/i"));
            return actualDelete.Text;
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
            yearOfGraduationdropdown.Click();                                                                       
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
            IWebElement actualcollage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[1]"));
            return actualcollage.Text;
        }
        //Check weather country of collage name is same as given name
        public string GetCountryofcollage(IWebDriver driver)
        {
            IWebElement actualCountryofcollage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[2]"));
            return actualCountryofcollage.Text;
        }
        //Check weather title is same as given title
        public string GetTitle(IWebDriver driver)
        {
            IWebElement actualTitle = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[3]"));
            return actualTitle.Text;
        }
        //Check weather degree is same as given Degree
        public string GetDegree(IWebDriver driver)
        {
            IWebElement actualDegree = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[4]"));
            return actualDegree.Text;
        }
        //Check weather year of graduation is same as given year
        public string GetYearofGraduation(IWebDriver driver)
        {
            IWebElement actualYearofGraduation = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[5]"));
            return actualYearofGraduation.Text;
        }

        public void Certifications(IWebDriver driver)
        {
            Wait.WaittobeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 5);
            //Identify certification tab and click
            IWebElement certificationsPage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            certificationsPage.Click();

            Wait.WaittobeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div", 5);
            //Identify add new button and click
            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
            addNewButton.Click();

            Wait.WaittobeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input", 5);
            //Identify certificate or award text box and give input
            IWebElement certificateTextBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input"));
            certificateTextBox.SendKeys("ISTQB");

            Wait.WaittobeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input", 5);
            //Identify certificate from text box and give input
            IWebElement certificateFromTextBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));
            certificateFromTextBox.SendKeys("ISTQB");

            Wait.WaittobeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select", 5);
            //Identify year dropdown button, click, and select
            IWebElement yearDropDown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select"));
            yearDropDown.Click();

            Wait.WaittobeClickable(driver, "XPath", "/*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select/option[14]", 5);
            IWebElement yearSelect = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select/option[14]"));
            yearSelect.Click();
        }
        public string GetCertifications(IWebDriver driver)
        {
            //Check weather certificate is same as given 
            IWebElement actualcertificateTextBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]"));
            return actualcertificateTextBox.Text;                               
        }
        public string GetcertificateFrom(IWebDriver driver)
        {
            //Check weather certificate from is as given 
            IWebElement actualcertificateFrom = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[2]"));
            return actualcertificateFrom.Text;
        }
        public string Getyear(IWebDriver driver)
        {
            //Check weather year is same as given
            IWebElement actualYear = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[3]"));
            return actualYear.Text;
        }
        public void ShareSkill(IWebDriver driver)
        {
            Wait.WaittobeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[1]/div/div[2]/a", 5);
            //Identify shareskill button and Click
            IWebElement shareSkillButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/div[2]/a"));
            shareSkillButton.Click();

            Wait.WaittobeClickable(driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input", 5);
            //Identify title textbox and give data
            IWebElement titleTextbox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input"));
            titleTextbox.SendKeys("Mrs");

            Wait.WaittobeClickable(driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea", 5);
            //Identify description Textbox and give data
            IWebElement descriptionTextbox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea"));
            descriptionTextbox.SendKeys("Software Testing");

            Wait.WaittobeClickable(driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div/select", 5);
            // Identify category dropdown box and select
            IWebElement categoryDropdownbox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div/select"));
            categoryDropdownbox.Click();

            Wait.WaittobeClickable(driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[1]/select/option[7]//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[1]/select/option[7]", 5);
            //select the option
            IWebElement selectCategory = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[1]/select/option[7]//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[1]/select/option[7]"));
            selectCategory.Click();

            Wait.WaittobeClickable(driver, "XPath", "///*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select", 5);
            //Identify subcategory dropdown box and select
            IWebElement subcategoryDropdownbox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select"));
            subcategoryDropdownbox.Click();

            Wait.WaittobeClickable(driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select/option[5]", 5);
            //Select subcategory 
            IWebElement selectSubcategory = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select/option[5]"));
            selectSubcategory.Click();

            Wait.WaittobeClickable(driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input", 5);
            //Identify tages text box and give data
            IWebElement tagesTextBox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));
            tagesTextBox.SendKeys("Testing");
            tagesTextBox.SendKeys(Keys.Enter);

            Wait.WaittobeClickable(driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input", 5);
            //Identify Service type and select
            IWebElement selectServiceType = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input"));
            selectServiceType.Click();

            Wait.WaittobeClickable(driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input", 5);
            //Identify Location type and select
            IWebElement selectLocatiotype = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input"));
            selectLocatiotype.Click();

            Wait.WaittobeClickable(driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/inpu", 5);
            //Identify available date and select start and end dates
            IWebElement selectStartDate = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input"));
            selectStartDate.Click();

            Wait.WaittobeClickable(driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input", 5);
            IWebElement selectEndDate = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input"));
            selectEndDate.Click();

            Wait.WaittobeClickable(driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[2]/div/div[2]/div/input", 5);
            //Identify skill teade and select
            IWebElement skillTrade = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[2]/div/div[2]/div/input"));
            skillTrade.Click();

            Wait.WaittobeClickable(driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div/input", 5);
            //Identify Credit Text and give data
            IWebElement creditTextbox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div/input"));
            creditTextbox.SendKeys("5");

            Wait.WaittobeClickable(driver, "XPath", "d=\"service-listing-section\"]/div[2]/div/form/div[10]/div[2]/div/div[1]/div/input", 5);
            //Identify Active and select
            IWebElement selectActive = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[10]/div[2]/div/div[1]/div/input"));
            selectActive.Click();

            Wait.WaittobeClickable(driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]", 5);
            //Identify save button and click
            IWebElement saveButton = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]"));
            saveButton.Click();

            //Go to mange listing find record you created
            IWebElement mangeListing = driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/section[1]/div/a[3]"));
            mangeListing.Click();


        } 
       


    }

}
