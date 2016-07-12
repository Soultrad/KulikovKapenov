using kalkul.OneArgumentFunction;
using NUnit.Framework;

namespace kalkul.Tests.OneArgumentFunctions
{

        [TestFixture]
        public class ArcSinTests
        {
            [TestCase(0.21, 0.21157)]
            [TestCase(0.51, 0.53518)]
            public void ArcSinTest(double first, double expected)
            {
                IOneArgCalculator calculator = new ArcSin();
                double result = calculator.Calculate(first);
                Assert.AreEqual(expected, result, 0.00001);
            }
        }
    
}