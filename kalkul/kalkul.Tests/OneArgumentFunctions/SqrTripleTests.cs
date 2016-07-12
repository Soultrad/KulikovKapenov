using kalkul.OneArgumentFunction;
using NUnit.Framework;

namespace kalkul.Tests.OneArgumentFunctions
{
    [TestFixture]
    public class SqrTripleTests
    {

        [TestCase(2, 8)]
        [TestCase(10, 1000)]
        public void SqrTripleTest(double first, double expected)
        {
            IOneArgCalculator calculator = new SqrTriple();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result);
        }
    }
}