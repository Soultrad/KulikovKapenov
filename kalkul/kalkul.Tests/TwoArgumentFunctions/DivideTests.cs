using kalkul.TwoArgumentFunction;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace kalkul.Tests.TwoArgumentFunctions
{
    [TestFixture]
    public class DivideTests
    {
        [Test]
        public void DivideTest()
        {
            ITwoArgCalculator calculator = new Divide();
            double result = calculator.Calculate(15, 3);
            Assert.AreEqual(5, result);
        }
    }
}