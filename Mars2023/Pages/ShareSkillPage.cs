using Mars2023.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars2023.Pages
{
    public class ShareSkillPage : CommonDriver
    {

        public void EditMangeListingRecord(IWebDriver driver)
        {
            //Goto Mange listing page 
            IWebElement mangListingPage = driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/section[1]/div/a[3]"));
            mangListingPage.Click();

            //Identify Edit icon and click
            IWebElement editRecodeIcon = driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[2]/i"));
            editRecodeIcon.Click();

            //Identify Title Text box and give data
            IWebElement titleTextBox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input"));
            titleTextBox.SendKeys("mnkfjdgh");

            //Identify Description text box and give data
            IWebElement descriptionTextBox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea"));
            descriptionTextBox.SendKeys("kjdihggb");

            //Identify category dropdown box and select
            IWebElement categoryDropdownBox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[1]/select"));
            categoryDropdownBox.Click();
            SelectElement element = new SelectElement(categoryDropdownBox);
            element.SelectByValue("2");

            //Identify sub category dropdown and select
            IWebElement subCategoryDropdownBox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select"));
            subCategoryDropdownBox.Click();
            SelectElement element1 = new SelectElement(subCategoryDropdownBox);
            element1.SelectByValue("2");

            //Identify tags text box and give text and enter
            IWebElement tagsTextBox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));
            tagsTextBox.SendKeys("test"+Keys.Enter);
            //tagsTextBox.SendKeys(Keys.Enter);

            //Identify service type and select
            IWebElement serviceType = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input"));
            serviceType.Click();

            //Identify location type and select
            IWebElement locationType = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input"));
            locationType.Click();

            //Identify start date and select
            IWebElement startDate = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input"));
            startDate.Click();

            //Identify end date and select




        }
    }
}
