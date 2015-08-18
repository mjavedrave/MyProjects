using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestfullAPI.Controllers;
using RestfullAPI.Models;
using System.Collections.Generic;

namespace RestfullAPI.Test
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            EmployeeApiController employeeApiController = new EmployeeApiController();
            List<Team> result = employeeApiController.GetTeamList();

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count>0);
          
        }

        [TestMethod]
        public void TestMethod2()
        {
            EmployeeApiController employeeApiController = new EmployeeApiController();
            List<Team> result = employeeApiController.GetTeamList();

            Assert.IsNull(result);
        }
    }
}
