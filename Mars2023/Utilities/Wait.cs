using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars2023.Commondriver
{
    public class Wait
    {
        public static void WaittobeClickable(IWebDriver driver, string locatertype, string locatervalue, int seconds)
        {
            var Wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
            if (locatertype == "Xpath")
            {
               Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatervalue)));
            }
              if (locatertype == "Id")
            {
               Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(locatervalue)));
            }
              if (locatertype == "Cssselector")
            {
               Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(locatervalue)));
            }
        }
    }
}
