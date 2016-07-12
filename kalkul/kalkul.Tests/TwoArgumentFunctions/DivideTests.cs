using kalkul.TwoArgumentFunction;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace kalkul.Tests.TwoArgumentFunctions
{
    [TestFixture]
    public class DivideTests
    {
        [TestCase(15,3,5)]
        [TestCase(30,10,3)]
        public void DivideTest(double first, double second, double expected)
        {
            ITwoArgCalculator calculator = new Divide();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}