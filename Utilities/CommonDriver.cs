using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Turnup.Pages;

namespace Turnup.Utilities
{
    public class CommonDriver
    {
        public IWebDriver driver;
       
        

        [OneTimeSetUp]
        public void LoginSteps()

        {
            // Open Chromebrowser
            driver = new ChromeDriver(@"D:\Automation\Turnup");
            Thread.Sleep(500);


            // Test LoginPage by Creating the LoginPage Object and login function
            LoginPage loginObj = new LoginPage();
            loginObj.loginActions(driver);

        }
        [OneTimeTearDown]
        public void CloseTestRun()
        {
            driver.Quit();

        }
    } 
    }
    

