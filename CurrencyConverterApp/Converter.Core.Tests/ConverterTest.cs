using Converter.Core.Frameworks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Converter.Core.Tests
{
    [TestClass]
    public class ConverterTest
    {
        [TestMethod]
        public void DoubleConverterTest()
        {
            var value = 123.45;
            var expectedResult = "ONE HUNDRED AND TWENTY-THREE DOLLARS AND FORTY-FIVE CENTS";
            var doubleConverter = new DoubleToWordConverter();
            string actualResult = doubleConverter.ConvertToWord(value);
            Assert.AreEqual(expectedResult, actualResult);

            value = 12540.85;
            expectedResult = "TWELVE THOUSAND FIVE HUNDRED AND FORTY DOLLARS AND EIGHTY-FIVE CENTS";
            doubleConverter = new DoubleToWordConverter();
            actualResult = doubleConverter.ConvertToWord(value);
            Assert.AreEqual(expectedResult, actualResult);

            value = -5.0;
            expectedResult = "CURRENCY IS NEGETIVE";
            doubleConverter = new DoubleToWordConverter();
            actualResult = doubleConverter.ConvertToWord(value);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void IntConverterTest()
        {
            var value = 123;
            var expectedResult = "ONE HUNDRED AND TWENTY-THREE DOLLARS";
            var intConverter = new IntegerToWordConverter();
            string actualResult = intConverter.ConvertToWord(value);
            Assert.AreEqual(expectedResult, actualResult);

            value = 120;
            expectedResult = "ONE HUNDRED AND TWENTY DOLLARS";
            intConverter = new IntegerToWordConverter();
            actualResult = intConverter.ConvertToWord(value);
            Assert.AreEqual(expectedResult, actualResult);

            value = -5;
            expectedResult = "CURRENCY IS NEGETIVE";
            intConverter = new IntegerToWordConverter();
            actualResult = intConverter.ConvertToWord(value);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
