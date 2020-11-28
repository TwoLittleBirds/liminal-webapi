using liminal_webapi.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Reflection;

namespace liminal_webapi_tests.controllers
{
    [TestClass]
    public class HealthCheckControllerUnitTests
    {
        [TestMethod]
        public void Call_Get_Resturns_Healthy()
        {
            var logger = new Mock<ILogger<HealthCheckController>>();
            var controller = new HealthCheckController(logger.Object);
            var result = controller.Get() as OkObjectResult;


            Assert.AreEqual("Healthy", result.Value);
        }
    }
}
