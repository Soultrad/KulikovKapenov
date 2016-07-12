using kalkul.OneArgumentFunction;
using NUnit.Framework;

namespace kalkul.Tests.OneArgumentFunctions
{
    [TestFixture]
    public class SqrtTests
    {

        [TestCase(9, 3)]
        [TestCase(100, 10)]
        public void SqrtTest(double first, double expected)
        {
            IOneArgCalculator calculator = new Sqrt();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.00001);
        }
    }

}