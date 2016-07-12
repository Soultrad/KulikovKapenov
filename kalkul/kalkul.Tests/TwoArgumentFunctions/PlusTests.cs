using kalkul.TwoArgumentFunction;
using NUnit.Framework;

namespace kalkul.Tests.TwoArgumentFunctions
{
    [TestFixture]
    public class PlusTests
    {
        [Test]
        public void PlusTest()
        {
            ITwoArgCalculator calculator=new Plus();
            double result = calculator.Calculate(3, 5);
            Assert.AreEqual(8,result);
        }
    }
}