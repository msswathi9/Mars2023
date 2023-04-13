using Mars2023.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Mars2023.StepDefinition
{
    [Binding]

    public class ProfilefeatureStepDefinitions
    {
        public IWebDriver driver = new ChromeDriver();

        Loginpage logInPageobj = new Loginpage();
        ProfilePage profilePageobj = new ProfilePage();
        [Given(@"I logged into mars portal successfully")]
        [BeforeScenario]
        public void GivenILoggedIntoMarsPortalSuccessfully()
        {
            //Login Page object initialization and defination
            logInPageobj.loginActions(driver);
        }

        [When(@"I added education to my Profile")]
        public void WhenIAddedEducationToMyProfile()
        {
            profilePageobj.Education(driver);
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
            profilePageobj.Editeducation(driver);

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
