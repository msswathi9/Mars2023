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
        Loginpage logInPageobj;
        ProfilePage profilePageobj; 
        public ProfilefeatureStepDefinitions()
        {
            logInPageobj = new Loginpage();
             profilePageobj = new ProfilePage();

        }
       
        [Given(@"I logged into mars portal successfully")]
        [BeforeScenario]
        public void GivenILoggedIntoMarsPortalSuccessfully()
        {
            //driver = new ChromeDriver();
            //Login Page object initialization and defination
            Loginpage.loginActions();
            Loginpage.SigninButton();
            Loginpage.UserTextBox();
            Loginpage.PasswordTextBox();
            Loginpage.LogInButton();
        }

        [When(@"I added education to my Profile")]
        public void WhenIAddedEducationToMyProfile()
        {
           ProfilePage.GotoEducation();
            ProfilePage.ClickAddNewButton();
            ProfilePage.AddCollage();
            ProfilePage.SelectCountryOfCollage();
            ProfilePage.SelectTitle();
            ProfilePage.AddDegree();
            ProfilePage.SelectYearofGraduation();
            ProfilePage.Addbutton();

        }
        [Then(@"The education should be added successfully")]
        public void ThenTheEducationShouldBeAddedSuccessfully()
        {
            string neweucationRecord = ProfilePage.GetAlertWindow();
            Assert.That(neweucationRecord == "Education has been added", "Failed to add education record");
        }
        [When(@"I Want to update existing Education record")]
        public void WhenIWantToUpdateExistingEducationRecord()
        {
            ProfilePage.GotoEducation();
            ProfilePage.EditRecordIcon();
            ProfilePage.EditCollageTextBox();
            ProfilePage.EditCountryDropdown();
            ProfilePage.EditTitleDropDown();
            ProfilePage.EditDegreeTextBox();
            ProfilePage.EditYearofGraduation();
            ProfilePage.UpdateButton();
            

        }
        [Then(@"The record should be updated succesully")]
        public void ThenTheRecordShouldBeUpdatedSuccesully()
        {
            string editedrecord = ProfilePage.GetAlertWindow();
            Assert.That(editedrecord == "Education as been updated", "Failed to update education record");
           
        }
        [When(@"I Want to delte existing Education record")]
        public void WhenIWantToDelteExistingEducationRecord()
        {
            ProfilePage.GotoEducation();
            ProfilePage.DeleteEducationrecord();
        }
        [Then(@"The record should be deleted succesully")]
        public void ThenTheRecordShouldBeDeletedSuccesully()
        {
            string deleteEducationRecord = ProfilePage.GetAlertWindow();
            Assert.That(deleteEducationRecord == "Education entry successfully removed", "Failed to delete education record");
        }

        [AfterScenario]
        public void tearDown()
        {
            driver.Quit();
        }

    }

}
