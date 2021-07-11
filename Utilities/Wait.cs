using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Turnup.Utilities
{
    class Wait
    {
        // re-usable function for wait
        public static void  WaitForIWebElementToExist(IWebDriver driver,string attributeValue,string attribute,int secondsToWait)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, secondsToWait));
            if (attribute == "xpath")
                { 

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(attributeValue)));
            }
            if (attribute == "Id")
                {

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id(attributeValue)));

            }

            if (attribute == "CssSelector")
                {

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(attributeValue)));

            }






        }

       
        }
    }
    
    









    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
      
        
        
        
        
        
       




    
 


