using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MASGlobalTest;
using MASGlobalTest.Controllers;
using MASGlobalTest.Controllers.Api;
using MASGlobal.Entities.DTOs;

namespace MASGlobalTest.Tests.Controllers
{
    [TestClass]
    public class EmployeesControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            EmployeeController controller = new EmployeeController();

            //Act
            IEnumerable<EmployeeDTO> result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
            Assert.AreEqual("Juan", result.ElementAt(0).Name);
            Assert.AreEqual("Sebastian", result.ElementAt(1).Name);
        }

        [TestMethod]
        public void GetById_SuccesfullyFound()
        {
            // Arrange
            var employeeId = 1;
            EmployeeController controller = new EmployeeController();

            // Act
            EmployeeDTO result = controller.Get(employeeId);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Juan", result.Name);
        }

        [TestMethod]
        public void GetById_IdDontFound()
        {
            // Arrange
            var employeeId = 99;            
            EmployeeController controller = new EmployeeController();

            // Act
            EmployeeDTO result = controller.Get(employeeId);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Id);
            Assert.IsNull(result.Name);
        }
    }
}