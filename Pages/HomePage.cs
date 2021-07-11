using OpenQA.Selenium;
using System;
using System.Threading.Tasks;
using Turnup.Utilities;

namespace Turnup.Pages
{
    class HomePage
    {
        public void GoToTMpage(IWebDriver driver)
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

        
    }
      
}
