using kalkul.OneArgumentFunction;
using NUnit.Framework;

namespace kalkul.Tests.OneArgumentFunctions
{
    [TestFixture]
    public class LogTenTests
    {


        [TestCase(12, 1.07918124)]
        [TestCase(65, 1.81291335664)]
        public void LogTenTest(double first, double expected)
        {
            IOneArgCalculator calculator = new LogTen();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.0000001);
        }

    }
}