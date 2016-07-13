using System;
using kalkul.OneArgumentFunction;
using NUnit.Framework;

namespace kalkul.Tests.OneArgumentFunctions
{
    [TestFixture]
    public class LnTests
    {
        [TestCase(15, 2.7080502011)]
        [TestCase(120, 4.78749174)]
        public void LnTest(double first, double expected)
        {
            IOneArgCalculator calculator = new Ln();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.0000001);
        }
        [Test]
        public void DividebyZeroTest()
        {
            IOneArgCalculator calculator = new Sqrt();
            Assert.Throws<Exception>(() => calculator.Calculate(-3));

        }
    }
}