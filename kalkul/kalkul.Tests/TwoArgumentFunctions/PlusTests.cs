using kalkul.TwoArgumentFunction;
using NUnit.Framework;

namespace kalkul.Tests.TwoArgumentFunctions
{
    [TestFixture]
    public class PlusTests
    {
        [TestCase(6,2,8)]
        [TestCase(10, 2, 12)]
        public void PlusTest(double first,double second,double expected)
        {
            ITwoArgCalculator calculator=new Plus();
            double result = calculator.Calculate(first,second);
            Assert.AreEqual(expected,result);
        }

    }
}