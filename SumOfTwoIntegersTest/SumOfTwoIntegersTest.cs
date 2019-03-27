using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumOfTwoIntegers;

namespace SumOfTwoIntegersTest
{
    [TestClass]
    public class SumOfTwoIntegersTest
    {
        [TestMethod]
        public void Test_AddTwoLargestIntegers()
        {
            var sequence = new int [] { 2, 5, 124, 9, 2, 44, 77, 124};

            var expected = 201;

            var actual = new SumOfTwoIntegers.SumOfTwoIntegers().AddTwoLargestIntegers(sequence);

            Assert.AreEqual(expected, actual);
        }
    }
}
