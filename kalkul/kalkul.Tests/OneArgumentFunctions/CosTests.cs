using kalkul.OneArgumentFunction;
using NUnit.Framework;

namespace kalkul.Tests.OneArgumentFunctions
{

    [TestFixture]
    public class CosTests
    {
        [TestCase(0,1)]
        [TestCase(120, 0.8141809705)]
        public void CosTest(double first, double expected)
        {
            IOneArgCalculator calculator = new Cos();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.00001);
        }
    }
}