using kalkul.OneArgumentFunction;
using NUnit.Framework;

namespace kalkul.Tests.OneArgumentFunctions
{
    
        [TestFixture]
        public class TgTests
        {
            [TestCase(0, 0)]
            [TestCase(120, 0.71312300978)]
            public void TgTest(double first, double expected)
            {
                IOneArgCalculator calculator = new Tg();
                double result = calculator.Calculate(first);
                Assert.AreEqual(expected, result, 0.00001);
            }
        }
    
}