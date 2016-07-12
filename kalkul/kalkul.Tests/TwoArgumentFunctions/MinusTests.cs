using kalkul.TwoArgumentFunction;
using NUnit.Framework;

namespace kalkul.Tests.TwoArgumentFunctions
{
    [TestFixture]
    public class MinusTests
    {
        [Test]
        public void MinusTest()
        {
            ITwoArgCalculator calculator = new Minus();
            double result = calculator.Calculate(10, 5);
            Assert.AreEqual(5, result);
        }
    }
}