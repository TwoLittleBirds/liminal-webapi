using liminal_webapi.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Reflection;

namespace liminal_webapi_tests.controllers
{
    [TestClass]
    public class VersionControllerUnitTests
    {
        [TestMethod]
        public void Call_Get_Resturns_Version()
        {
            var logger = new Mock<ILogger<VersionController>>();
            var controller = new VersionController(logger.Object);
            var result = controller.Get() as OkObjectResult;

            var t = typeof(VersionController);
            // Instantiate an Assembly class to the assembly housing the Integer type.
            var assem = Assembly.GetAssembly(t);

            Assert.AreEqual(assem.GetName().Version.ToString(), result.Value);
        }
    }
}
