using System;

namespace kalkul.OneArgumentFunction
{
    public class SqrTriple:IOneArgCalculator
    {
        public double Calculate(double first)
        {
            return Math.Pow(first, 3);
        }
    }
}