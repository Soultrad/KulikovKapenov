using kalkul.OneArgumentFunction;
using NUnit.Framework;

namespace kalkul.Tests.OneArgumentFunctions
{
    [TestFixture]
    public class SqrtTripleTests
    {

        [TestCase(27, 3)]
        [TestCase(1000, 10)]
        public void SqrtTripleTest(double first, double expected)
        {
            IOneArgCalculator calculator = new SqrtTriple();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.00001);
        }
    }
}