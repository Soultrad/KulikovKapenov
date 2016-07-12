using kalkul.OneArgumentFunction;
using NUnit.Framework;

namespace kalkul.Tests.OneArgumentFunctions
{
    [TestFixture]
    public class SinTests
    {
        [TestCase(0,0)]
        [TestCase(120, 0.58061118)]
        public void SinTest(double first, double expected)
        {
            IOneArgCalculator calculator = new Sin();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.00001);
        }
    }
}