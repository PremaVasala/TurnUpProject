using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnup.Pages
{
    class LoginPage
    {
        // Functions that allows users to login to Turnup portal
        public void loginActions(IWebDriver driver)
        {
            

            driver.Manage().Window.Maximize();
            try
            {

                // launch turnup portal
                driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
                driver.Manage().Window.Maximize();



                // Identify username enter valid username
                IWebElement username1 = driver.FindElement(By.Id("UserName"));
                username1.SendKeys("hari");

                //Identify password enter valid password
                IWebElement password = driver.FindElement(By.Id("Password"));
                password.SendKeys("123123");

                // Identify action button click on it
                IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
                loginButton.Click();
                driver.Manage().Window.Maximize();
            }
            catch(Exception ex)

            {
                Assert.Fail(ex.Message);

            }

        }

    }
}
