using kalkul.OneArgumentFunction;
using NUnit.Framework;

namespace kalkul.Tests.OneArgumentFunctions
{
    [TestFixture]
    public class CtgTests
    {


            [TestCase(12, -1.57267)]
            [TestCase(65, -0.68025)]
            public void CtgTest(double first, double expected)
            {
                IOneArgCalculator calculator = new Ctg();
                double result = calculator.Calculate(first);
                Assert.AreEqual(expected, result, 0.00001); 
            }
        
    }
}