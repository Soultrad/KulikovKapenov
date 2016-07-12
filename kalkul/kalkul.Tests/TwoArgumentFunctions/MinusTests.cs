using kalkul.TwoArgumentFunction;
using NUnit.Framework;

namespace kalkul.Tests.TwoArgumentFunctions
{
    [TestFixture]
    public class MinusTests
    {
        [TestCase(15,4,11)]
        [TestCase(20, 11, 9)]
        public void MinusTest(double first, double second, double expected)
        {
            ITwoArgCalculator calculator = new Minus();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}