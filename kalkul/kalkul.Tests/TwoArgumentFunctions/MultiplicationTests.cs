using kalkul.TwoArgumentFunction;
using NUnit.Framework;

namespace kalkul.Tests.TwoArgumentFunctions
{
[TestFixture]
    public class MultiplicationTests
    {
        [Test]
        public void MultiplicationTest()
        {
            ITwoArgCalculator calculator = new Multiplication();
            double result = calculator.Calculate(3, 5);
            Assert.AreEqual(15, result);
        }
    }
}