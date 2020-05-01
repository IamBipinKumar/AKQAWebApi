/// <summary>
/// AKQA Web API AppStart Tests namespace
/// </summary>
namespace AKQAWebAPI.Tests.API.AppStart
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Web.Http;

    [TestClass]
    public class WebApiConfigTest
    {
        [TestMethod]
        public void Register()
        {
            //Arrange
            HttpConfiguration configuration = new HttpConfiguration();

            // Act
            WebApiConfig.Register(configuration);

            // Assert
            Assert.IsNotNull(configuration);
            Assert.AreEqual(2, configuration.Routes.Count);
        }
    }
}