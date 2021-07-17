
using NUnit.Framework;
using System;
using Turnup.Pages;
using Turnup.Utilities;

namespace Turnup.tests
{
    [TestFixture]
    [Parallelizable]
    public class Employee : CommonDriver

    {

        [Test]
        public void CreateEmployeeTest()
        {
            HomePage homeObj = new HomePage(); 
            homeObj.GoToEmployeePage(driver);

            EmployeePage employeeObj = new EmployeePage();
            employeeObj.CreateEmployee(driver);
        }
        [Test]
        public void EditEmployeesTest()
        {
            HomePage homeObj = new HomePage();
            homeObj.GoToEmployeePage(driver);

            EmployeePage employeeObj = new EmployeePage();
            employeeObj.EditEmployee(driver);
        }
        [Test]
        public void DeleteEmployeesTest()
        {
            HomePage homeObj = new HomePage();
            homeObj.GoToEmployeePage(driver);

            EmployeePage employeeObj = new EmployeePage();
            employeeObj.DeleteEmployee(driver);
        }


    }
}