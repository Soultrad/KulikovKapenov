using kalkul.OneArgumentFunction;
using NUnit.Framework;

namespace kalkul.Tests.OneArgumentFunctions
{
    [TestFixture]
    public class SqrTests
    {

        [TestCase(2, 4)]
        [TestCase(10, 100)]
        public void SqrTest(double first, double expected)
        {
            IOneArgCalculator calculator = new Sqr();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result);
        }
    }
}