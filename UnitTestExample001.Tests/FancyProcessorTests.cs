using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestExample001;

namespace UnitTestExample001.Tests
{
    [TestClass]
    public class FancyProcessorTests
    {

        [DynamicData(nameof(FancyProcessorTestData.GetAddIntegersTestData), typeof(FancyProcessorTestData), DynamicDataSourceType.Method)]
        [DataTestMethod]
        public void AddIntegers_Addition_Returns_Answer(int value1, int value2, int expectedResult)
        {
            Assert.AreEqual(new FancyProcessor().AddIntegers(value1, value2), expectedResult);
        }

        [TestMethod]
        public void AlwaysReturnsTrue_ReturnsTrue()
        {
            Assert.IsTrue(new FancyProcessor().AlwaysReturnsTrue());
        }
    }
}
