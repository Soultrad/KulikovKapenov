using kalkul.TwoArgumentFunction;
using NUnit.Framework;

namespace kalkul.Tests.TwoArgumentFunctions
{
[TestFixture]
    public class MultiplicationTests
    {
        [TestCase(2,3,6)]
        [TestCase(6, 8, 48)]
    public void MultiplicationTest(double first, double second, double expected)
        {
            ITwoArgCalculator calculator = new Multiplication();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}