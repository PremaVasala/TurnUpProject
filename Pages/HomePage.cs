using OpenQA.Selenium;
using System;
using System.Threading;
using System.Threading.Tasks;
using Turnup.Utilities;

namespace Turnup.Pages
{
    class HomePage
    {

        // Function to navigate Time and Material page
        public void GoToTMPage(IWebDriver driver )
        {
            //Navigate to time and material page
            // Click on Administration 
            IWebElement Administrationbutton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            Administrationbutton.Click();

            // Click on Time and Material dropdown
            IWebElement TimeMaterialbutton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            TimeMaterialbutton.Click();
            // Wait.WaitForIWebElement((driver, "/ html / body / div[3] / div / div / ul / li[5] / ul / li[3] / a", "XPath", 2));

        }
          
        public void GoToEmployeePage(IWebDriver driver )
        {

            //Navigate to time and material page
            // Click on Administration 
            IWebElement Administrationbutton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            Administrationbutton.Click();
            Thread.Sleep(500);

            // Click on Employee dropdown 
            IWebElement Employeedropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a")); 
            Employeedropdown.Click();

            Thread.Sleep(500);


        }




    }

        
    }
      

