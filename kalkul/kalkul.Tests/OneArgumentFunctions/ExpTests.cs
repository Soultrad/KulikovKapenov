using kalkul.OneArgumentFunction;
using NUnit.Framework;

namespace kalkul.Tests.OneArgumentFunctions
{
    [TestFixture]
    public class ExpTests
    {

        [TestCase(30, 10686474581524.463)]
        [TestCase(24, 26489122129.8435)]
        public void ExpTest(double first, double expected)
        {
            IOneArgCalculator calculator = new Exp();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}