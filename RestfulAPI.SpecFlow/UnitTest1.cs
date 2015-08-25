using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using RestfullAPI.Controllers;

namespace MyProject.Specs
{
    [Binding]
    public class UnitTest1
    {
        private int result { get; set; }

        EmployeeApiController employeeApiController = new EmployeeApiController();

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIAddAnotherTeams(String name)
        {
            employeeApiController.Add(name); 
        }

        [When(@"I get all teams")]
        public void WhenIPressAdd()
        {
            result = employeeApiController.GetTeamList().Count;
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.AreEqual(expectedResult, result);
        }
    }
}