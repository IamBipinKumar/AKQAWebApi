/// <summary>
/// AKQA Web API Tests namespace
/// </summary>
namespace AKQAWebAPI.Tests.API
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    class Test : WebApiApplication
    {
        public void TestApplication_Start()
        {
            base.Application_Start();
        }
    }

    [TestClass]
    public class WebApiApplicationTest
    {
        [ExpectedException(typeof(InvalidOperationException))]
        [TestMethod]
        public void RegisterGlobalFilters()
        {
            //Arrange
            Test application = new Test();

            // Act
            application.TestApplication_Start();

            // Assert
            Assert.IsNotNull(application);
        }
    }
}