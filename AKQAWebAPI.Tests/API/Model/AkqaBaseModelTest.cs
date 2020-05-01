namespace AKQAWebAPI.Tests.API.Model
{
    using AKQAWebAPI.Models;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ModelTest
    {
        [TestMethod]
        public void TestAkqaBaseModel()
        {
            var actual = new AkqaBaseModel();

            Assert.IsNotNull(actual);
            Assert.AreEqual(null, actual.Name);
            Assert.AreEqual(null, actual.Number);
        }

        [TestMethod]
        public void TestAkqaResponseModel()
        {
            var actual = new AkqaResponseModel();

            Assert.IsNotNull(actual);
            Assert.AreEqual(null, actual.Name);
            Assert.AreEqual(null, actual.Number);
        }
    }
}