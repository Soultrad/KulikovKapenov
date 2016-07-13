using System;
using NUnit.Framework;
using kalkul.TwoArgumentFunction;

namespace kalkul.Tests.TwoArgumentFunctions
{
    public class TwoArgumentFactoryTests
    {
        [TestCase("plus", typeof(Plus))]
        [TestCase("minus", typeof(Minus))]
        [TestCase("delenie", typeof(Divide))]
        [TestCase("ymno", typeof(Multiplication))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = TwoArgumentFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);
        }

    }
}