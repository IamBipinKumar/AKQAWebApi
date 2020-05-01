/// <summary>
/// AKQA Web API Utility Tests namespace
/// </summary>
namespace AKQAWebAPI.Tests.API.Utility
{
    using AKQA.Utilities.Constants;
    using AKQA.Utilities.Utility;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CurrencyConverterTest
    {
        [TestMethod]
        public void ConvertToText()
        {
            // Arrange

            // Act
            var result = CurrencyConverter.ConvertToText(1.1m, false, Constants.Space);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("one dollar ten cents", result);
        }

        [TestMethod]
        public void ConvertToText_ForUpper()
        {
            // Arrange

            // Act
            var result = CurrencyConverter.ConvertToText(1.1m, true, Constants.Space);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("ONE DOLLAR TEN CENTS", result);
        }

        [TestMethod]
        public void ConvertToText_ForTwenty()
        {
            // Arrange

            // Act
            var result = CurrencyConverter.ConvertToText(121.1m, true, Constants.Space);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("ONE HUNDRED TWENTY ONE DOLLARS TEN CENTS", result);
        }

        [TestMethod]
        public void ConvertToText_ForThirty()
        {
            // Arrange

            // Act
            var result = CurrencyConverter.ConvertToText(131.1m, true, Constants.Space);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("ONE HUNDRED THIRTY ONE DOLLARS TEN CENTS", result);
        }

        [TestMethod]
        public void ConvertToText_ForForty()
        {
            // Arrange

            // Act
            var result = CurrencyConverter.ConvertToText(141.1m, true, Constants.Space);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("ONE HUNDRED FORTY ONE DOLLARS TEN CENTS", result);
        }

        [TestMethod]
        public void ConvertToText_ForFifty()
        {
            // Arrange

            // Act
            var result = CurrencyConverter.ConvertToText(151.1m, true, Constants.Space);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("ONE HUNDRED FIFTY ONE DOLLARS TEN CENTS", result);
        }

        [TestMethod]
        public void ConvertToText_ForSixty()
        {
            // Arrange

            // Act
            var result = CurrencyConverter.ConvertToText(161.1m, true, Constants.Space);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("ONE HUNDRED SIXTY ONE DOLLARS TEN CENTS", result);
        }

        [TestMethod]
        public void ConvertToText_ForSeventy()
        {
            // Arrange

            // Act
            var result = CurrencyConverter.ConvertToText(171.1m, true, Constants.Space);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("ONE HUNDRED SEVENTY ONE DOLLARS TEN CENTS", result);
        }

        [TestMethod]
        public void ConvertToText_ForEighty()
        {
            // Arrange

            // Act
            var result = CurrencyConverter.ConvertToText(181.1m, true, Constants.Space);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("ONE HUNDRED EIGHTY ONE DOLLARS TEN CENTS", result);
        }

        [TestMethod]
        public void ConvertToText_ForNinety()
        {
            // Arrange

            // Act
            var result = CurrencyConverter.ConvertToText(191.1m, true, Constants.Space);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("ONE HUNDRED NINETY ONE DOLLARS TEN CENTS", result);
        }
    }
}