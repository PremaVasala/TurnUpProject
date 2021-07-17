
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
    [Parallelizable]
    class Program : CommonDriver


    {
       

           // Object for TMPage
             [Test]
             public void CreateTM()
             {
            // Object for Homepage
            HomePage homeObj = new HomePage();
            homeObj.GoToTMPage(driver);

            TMpage tmObj = new TMpage();
            tmObj.CreateTM(driver);

             }

              // Create object for Edit
              [Test]
              public void EditTM()
              {
            // Object for Homepage
            HomePage homeObj = new HomePage();
            homeObj.GoToTMPage(driver);

            TMpage tmObj = new TMpage();
              tmObj.EditTM(driver);
              }
           

            // Create Object for Delete
            [Test]
            public void DeleteTM()
            {

            // Object for Homepage
            HomePage homeObj = new HomePage();
            homeObj.GoToTMPage(driver);

            TMpage tmObj = new TMpage();
                tmObj.DeleteTM(driver);
            }


           

            }

        








    }

    




































































