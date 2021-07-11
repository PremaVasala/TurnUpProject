
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using Turnup.Pages;
using Turnup.Utilities;

namespace Turnup
{
    [TestFixture]
    class Program : CommonDriver


    {
        [SetUp]

         public void LoginSteps()

          {   
            // Open Chromebrowser
            driver = new ChromeDriver(@"D:\Automation\Turnup");

            // Object for loginPage
            LoginPage loginObj = new LoginPage();
            loginObj.loginActions(driver);

            // Object for Homepage
            HomePage homeObj = new HomePage();
            homeObj.GoToTMpage(driver);
            }

           // Object for TMPage
             [Test]
             public void CreateTM()
             {
            TMpage tmObj = new TMpage();
            tmObj.CreateTM(driver);

             }

              // Create object for Edit
              [Test]
              public void EditTM()
              {
              TMpage tmObj = new TMpage();
              tmObj.EditTM(driver);
              }
           

            // Create Object for Delete
            [Test]
            public void DeleteTM()
            {
                TMpage tmObj = new TMpage();
                tmObj.DeleteTM(driver);
            }


            [TearDown]
            public void CloseTestRun()
            {

            }

        // Create Employee

        //IWebElement CreateEmployee = driver.FindElement(By.XPath("//*[@id='container']/p/a")); 
        //CreateEmployee.click();

        ////*[@id="Name"]
        ///
        //IWebElement EmployeeName = driver.FindElement("//*[@id="Name"]");
        //EmployeeName.sendkeys("Ramu")








    }
}
    




































































