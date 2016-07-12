using System;

namespace kalkul.OneArgumentFunction
{
    public class SqrtTriple:IOneArgCalculator
    {
        public double Calculate(double first)
        {
            return Math.Pow(first, 1.0/3);
        }
    }
}