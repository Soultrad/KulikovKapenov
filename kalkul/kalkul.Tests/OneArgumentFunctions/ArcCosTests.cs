using kalkul.OneArgumentFunction;
using NUnit.Framework;

namespace kalkul.Tests.OneArgumentFunctions
{
    [TestFixture]
    public class ArcCosTests
    {
        [TestCase(0.21, 1.35922)]
        [TestCase(0.51, 1.03561)]
        public void ArcCosTest(double first, double expected)
        {
            IOneArgCalculator calculator = new ArcCos();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.00001);
        }
    }
}