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
        public IWebDriver driver;

        Loginpage logInPageobj = new Loginpage();
        ProfilePage profilePageobj = new ProfilePage();

        [Given(@"I logged into mars portal successfully")]
        public void GivenILoggedIntoMarsPortalSuccessfully()
        {
            //open chrome browser
            driver = new ChromeDriver();

            //Login Page object initialization and defination
            logInPageobj.loginActions(driver);
        }

        [When(@"I navigated to the skill page")]
        public void WhenINavigatedToTheSkillPage()
        {
            
            profilePageobj.Skills(driver);
        }

        [When(@"I added skill to my Profile")]
        public void WhenIAddedSkillToMyProfile()
        {
            profilePageobj.Skills(driver);
        }

        [Then(@"The skill should be added successfully")]
        public void ThenTheSkillShouldBeAddedSuccessfully()
        {
            string newAddSkill = profilePageobj.GetAddSkill(driver);
            Assert.That(newAddSkill == "Automation", "Actual add skill and expected add skill do not match");

            string newChooseSkill = profilePageobj.GetChooseSkill(driver);
            Assert.That(newChooseSkill == "Beginner", "Actual choose skill and expected choose skill do not match");
        }
        [When(@"I navigated to the education page")]
        public void WhenINavigatedToTheEducationPage()
        {
            ProfilePage profilePageobj = new ProfilePage();
            profilePageobj.Education(driver);
        }
        [When(@"I added education to my Profile")]
        public void WhenIAddedEducationToMyProfile()
        {
            profilePageobj.Education(driver);
        }
        [Then(@"The education should be added successfully")]
        public void ThenTheEducationShouldBeAddedSuccessfully()
        {
            string newCollage = profilePageobj.GetCollage(driver);
            Assert.That(newCollage == "hjdjf", "Actual collage and expected collage do not match");

            string newCountryofcollage = profilePageobj.GetCountryofcollage(driver);
            Assert.That(newCountryofcollage == "India", "Actual country of collage and expected country of collage do not match");

            string newTitle = profilePageobj.GetTitle(driver);
            Assert.That(newTitle == "M.B.A", "Actual Title and expected Title do not match");

            string newDegree = profilePageobj.GetDegree(driver);
            Assert.That(newDegree == "Post Graduation", "Actual degree and expected degree do not match");

            string newYearofGraduation = profilePageobj.GetYearofGraduation(driver);
            Assert.That(newYearofGraduation == "2010", "Actual year of graduation and expected Actual year of graduation do not match");
        }

        [When(@"I navigated to the certification page")]
        public void WhenINavigatedToTheCertificationPage()
        {
            profilePageobj.Certifications(driver);
        }

        [When(@"I added certification to my Profile")]
        public void WhenIAddedCertificationToMyProfile()
        {
            profilePageobj.Certifications(driver);
        }

        [Then(@"The certification should be added successfully")]
        public void ThenTheCertificationShouldBeAddedSuccessfully()
        {
            string newCertification = profilePageobj.GetCertifications(driver);
            Assert.That(newCertification == "ISTQB", "Actual certification and expected certification do not Match");

            string newCertificationFrom = profilePageobj.GetcertificateFrom(driver);
            Assert.That(newCertificationFrom == "ISTQB", "Actual certification ffom and expected certification from do not Match");

            string newYear = profilePageobj.Getyear(driver);
            Assert.That(newYear == "2011", "Actual year and expected year do not match");
        }

    }
}
 