using OpenQA.Selenium;
using System;
using System.Threading;
using Turnup.Utilities;

namespace Turnup.Pages
{
    class TMpage
    {
        // Test - Create - New TM 

        public void CreateTM(IWebDriver driver)
        {

            //Identify Create New Action Button and click
            driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();
            Wait.WaitForIWebElementToExist(driver, "//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]", "xpath", 5);

            // Select time from the dropdown list
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]")).Click();
  
            Wait.WaitForIWebElementToExist(driver, "/html/body/div[4]/form/div/div[2]/div/input", "xpath", 5);


            // Identify Typecode textbox enter input
            driver.FindElement(By.XPath("/html/body/div[4]/form/div/div[2]/div/input")).SendKeys("xyz@@@xyz");
            Wait.WaitForIWebElementToExist(driver, "Description", "Id", 5);

            // Identify Description textbox enter input
            driver.FindElement(By.Id("Description")).SendKeys("This is created for reference");



            // Identify priceperunit textbox enter input

            IWebElement priceperunittextbox = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            priceperunittextbox.SendKeys("7777");
            driver.FindElement(By.Id("Price"));




            // Click on save button
            driver.FindElement(By.XPath("//*[@id='SaveButton']")).Click();

            Wait.WaitForIWebElementToExist(driver, "//*[@id='tmsGrid']/div[4]/a[4]/span", "xpath", 5);

            // Go to last page and click
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();
            Wait.WaitForIWebElementToExist(driver, "//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]", "xpath", 5);

            // click if created record is present in the Table and it has expected values
            IWebElement displayedcode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement displayeddescrption = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            //IWebElement displayedprice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr/td[4]"));////*[@id="tmsGrid"]/div[3]/table/tbody/tr/td[4]

            if (displayedcode.Text == "xyz@@@xyz" && displayeddescrption.Text == "This is created for reference")

            {
                Console.WriteLine("Record created, Test Passed");

            }
            else
            {
                Console.WriteLine("Record NOT created,Test Failed");
            }

        }

        //Test - Edit TM
        public void EditTM(IWebDriver driver)
            
        {
            //Click on lastarrow
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]"));
            Wait.WaitForIWebElementToExist(driver, "//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]", "xpath", 5);

            // Identify Edit button and click
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]")).Click();
            Wait.WaitForIWebElementToExist(driver, "//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]", "xpath", 5);

            //update Time record
            IWebElement dropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
            dropdown.Click();

            // Update Type code Textbox enter input
            driver.FindElement(By.XPath("//*[@id='Code']")).Clear();
            IWebElement DescriptionTestBox = driver.FindElement(By.XPath("//*[@id='Code']"));
             DescriptionTestBox.SendKeys("xxx@@@xxx");
            
            // Update Description Textbox enter input
            driver.FindElement(By.XPath("//*[@id='Description']")).Clear();
            Wait.WaitForIWebElementToExist(driver, "Description", "Xpath", 3);
            driver.FindElement(By.XPath("//*[@id='Description']")).SendKeys("for my practice");
            
            // Update PriceperUnit Textbox enter input
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).Click();

            Wait.WaitForIWebElementToExist(driver, "//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]", "xpath", 5);

            driver.FindElement(By.Id("Price")).Clear();
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).Click();
            driver.FindElement(By.XPath("//*[@id='Price']")).SendKeys("4444");

            Wait.WaitForIWebElementToExist(driver, "//*[@id='SaveButton']", "xpath", 5);

            // Click on save button

            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();


            Thread.Sleep(1000);
            // It didn't work on wait
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();
            Wait.WaitForIWebElementToExist(driver, "//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]", "xpath", 5);


            Wait.WaitForIWebElementToExist(driver, "//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]", "XPath", 5);

         

            // click if created record is present in the Table and it has expected values
            IWebElement Editcode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            IWebElement Editdescrption = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));

            if (Editcode.Text == "xxx@@@xxx" && Editdescrption.Text == "for my practice")

            {
                Console.WriteLine("Record Edited, Test Passed");

            }
            else
            {
                Console.WriteLine("Test Failed");
            }
        }
        //Test - Delete TM
        public void DeleteTM(IWebDriver driver)

        {

            // Identify the delete button and click
            Wait.WaitForIWebElementToExist(driver, "//*[@id='tmsGrid']/div[4]/a[4]/span", "XPath", 5);
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();

            Wait.WaitForIWebElementToExist(driver, "//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]", "xpath", 5);

            IWebElement DeleteButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));  ////*[@id="tmsGrid"]/div[4]/a[4]/span

            DeleteButton.Click();

            // Switching to Alert
            driver.SwitchTo().Alert().Accept();
            Wait.WaitForIWebElementToExist(driver, "//*[@id='tmsGrid']/div[4]/a[4]/span", "XPath", 5);

            IWebElement gotothelastpage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            gotothelastpage.Click();

            Wait.WaitForIWebElementToExist(driver, "//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]", "XPath", 1);

            // Go to last page
            // Check if record deleted successfully
            IWebElement DisplayedCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement DisplayedDescrption = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));

            if (DisplayedCode.Text == "xxx@@@xxx" && DisplayedDescrption.Text == "for my practice")

            {
                Console.WriteLine("Record Exists, Test Failed");
            }
            else
            {
                Console.WriteLine("Record Deleted,Test Passed");
            }

        }
    }
}
