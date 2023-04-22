using Mars2023.Pages;
using Mars2023.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Mars2023.StepDefinition
{
    [Binding]

    public class ProfilefeatureStepDefinitions : CommonDriver
    {    
       // public ProfilefeatureStepDefinitions(IWebDriver driver)
        //{
          //  this.driver = driver;
        //}
        Loginpage logInPageobj = new Loginpage();
        ProfilePage profilePageobj = new ProfilePage();
        [Given(@"I logged into mars portal successfully")]
        [BeforeScenario]
        public void GivenILoggedIntoMarsPortalSuccessfully()
        {
            //driver = new ChromeDriver();
            //Login Page object initialization and defination
            logInPageobj.loginActions(driver);
            logInPageobj.SigninButton(driver);
            logInPageobj.UserTextBox(driver);
            logInPageobj.PasswordTextBox(driver);
            logInPageobj.LogInButton(driver);
        }

        [When(@"I added education to my Profile")]
        public void WhenIAddedEducationToMyProfile()
        {
            profilePageobj.GotoEducation(driver);
            profilePageobj.ClickAddNewButton(driver);
            profilePageobj.AddCollage(driver);
            profilePageobj.SelectCountryOfCollage(driver);          
            profilePageobj.SelectTitle(driver);
            profilePageobj.AddDegree(driver);
            profilePageobj.SelectYearofGraduation(driver);
            profilePageobj.Addbutton(driver);

        }
        [Then(@"The education should be added successfully")]
        public void ThenTheEducationShouldBeAddedSuccessfully()
        {
            string neweucationRecord = profilePageobj.GetAlertWindow(driver);
            Assert.That(neweucationRecord == "Education has been added", "Failed to add education record");
        }
        [When(@"I Want to update existing Education record")]
        public void WhenIWantToUpdateExistingEducationRecord()
        {
            profilePageobj.GotoEducation(driver);
            profilePageobj.EditRecordIcon(driver);
            profilePageobj.EditCollageTextBox(driver);
            profilePageobj.EditCountryDropdown(driver);
            profilePageobj.EditTitleDropDown(driver);
            profilePageobj.EditDegreeTextBox(driver);
            profilePageobj.EditYearofGraduation(driver);
            profilePageobj.UpdateButton(driver);
            

        }
        [Then(@"The record should be updated succesully")]
        public void ThenTheRecordShouldBeUpdatedSuccesully()
        {
            string editedrecord = profilePageobj.GetAlertWindow(driver);
            Assert.That(editedrecord == "Education as been updated", "Failed to update education record");
           
        }
        [When(@"I Want to delte existing Education record")]
        public void WhenIWantToDelteExistingEducationRecord()
        {
            profilePageobj.GotoEducation(driver);
            profilePageobj.DeleteEducationrecord(driver);
        }
        [Then(@"The record should be deleted succesully")]
        public void ThenTheRecordShouldBeDeletedSuccesully()
        {
            string deleteEducationRecord = profilePageobj.GetAlertWindow(driver);
            Assert.That(deleteEducationRecord == "Education entry successfully removed", "Failed to delete education record");
        }

        [AfterScenario]
        public void tearDown()
        {
            driver.Quit();
        }

    }

}
