/// <summary>
/// AKQA Web API Controllers Tests namespace
/// </summary>
namespace AKQAWebAPI.Tests.API.Controllers
{
    using AKQAWebAPI.Controllers;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Linq;

    [TestClass]
    public class HomeControllerTest
    {
        HomeController controller;

        [TestInitialize]
        public void Initialize()
        {
            controller = new HomeController();
        }

        [TestMethod]
        public void Get()
        {
            // Arrange

            // Act
            var result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
            Assert.AreEqual("Name 1", result.ToList()[0].Name);
            Assert.AreEqual("Number 1.0", result.ToList()[0].Number);
            Assert.AreEqual("Name 2", result.ToList()[1].Name);
            Assert.AreEqual("Number 2.0", result.ToList()[1].Number);
        }

        [TestMethod]
        public void GetById()
        {
            // Act
            var result = controller.Get(5);

            // Assert
            Assert.AreEqual("Name 5", result.Name);
            Assert.AreEqual("Number 5.0", result.Number);
        }

        [TestMethod]
        public void Post()
        {
            // Act
            controller.Post("value");

            // Assert
        }

        [TestMethod]
        public void Put()
        {
            // Act
            controller.Put(5, "value");

            // Assert
        }

        [TestMethod]
        public void Delete()
        {
            // Act
            controller.Delete(5);

            // Assert
        }

        [TestCleanup]
        public void Cleanup()
        {
            controller = null;
        }
    }
}