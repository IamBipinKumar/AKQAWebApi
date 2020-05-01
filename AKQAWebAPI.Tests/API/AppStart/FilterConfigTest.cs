/// <summary>
/// AKQA Web API AppStart Tests namespace
/// </summary>
namespace AKQAWebAPI.Tests.API.AppStart
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Web.Mvc;

    [TestClass]
    public class FilterConfigTest
    {

        [TestMethod]
        public void RegisterGlobalFilters()
        {
            //Arrange
            GlobalFilterCollection filters = new GlobalFilterCollection();

            // Act
            FilterConfig.RegisterGlobalFilters(filters);

            // Assert
            Assert.IsNotNull(filters);
            Assert.AreEqual(1, filters.Count);
        }
    }
}