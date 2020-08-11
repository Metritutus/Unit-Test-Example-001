using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestExample001.Tests
{
    internal static class FancyProcessorTestData
    {
        public static IEnumerable<object[]> GetAddIntegersTestData()
        {
            yield return new object[] { 1, 1, 2 };
            yield return new object[] { 2, 2, 4 };
            yield return new object[] { 3, 3, 6 };
            yield return new object[] { 4, 4, 8 };
            yield return new object[] { 5, 5, 10 };
        }
    }
}
