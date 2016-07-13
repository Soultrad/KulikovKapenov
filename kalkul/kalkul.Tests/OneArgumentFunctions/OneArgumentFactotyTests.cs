using System;
using NUnit.Framework;
using  kalkul.OneArgumentFunction;

namespace kalkul.Tests.OneArgumentFunctions
{
     [TestFixture]
    public class OneArgumentFactotyTests
    {
        [TestCase("ArcCos",typeof(ArcCos))]
[TestCase("ArcSin", typeof(ArcSin))]
[TestCase("Cos", typeof(Cos))]
[TestCase("Ctg", typeof(Ctg))]
[TestCase("Exp", typeof(Exp))]
[TestCase("Ln", typeof(Ln))]
[TestCase("LogTen", typeof(LogTen))]
[TestCase("Sin", typeof(Sin))]
[TestCase("Sqr", typeof(Sqr))]
[TestCase("Sqrt", typeof(Sqrt))]
[TestCase("SqrTriple", typeof(SqrTriple))]
[TestCase("SqrtTriple", typeof(SqrtTriple))]
[TestCase("Tg", typeof(Tg))]
public void CalculateTest(string name, Type type)
{
var calculator = OneArgumentFactory.CreateCalculator(name);

Assert.IsInstanceOf(type, calculator);
}

    }
}