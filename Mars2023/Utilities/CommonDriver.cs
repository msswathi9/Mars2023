using Mars2023.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars2023.Utilities
{
   
        public class CommonDriver
        {
        public static IWebDriver driver { get; set; }

            public CommonDriver()
            {
             driver = new ChromeDriver();
            }

        
        }
}


