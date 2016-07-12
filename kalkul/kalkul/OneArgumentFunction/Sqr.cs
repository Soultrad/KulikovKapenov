using System;

namespace kalkul.OneArgumentFunction
{
    public class Sqr:IOneArgCalculator
    {
        public double Calculate(double first)
        {
            return Math.Pow(first,2);
        }
    }
}