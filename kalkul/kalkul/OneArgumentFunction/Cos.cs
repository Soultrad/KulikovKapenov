using System;

namespace kalkul.OneArgumentFunction
{
    public class Cos:IOneArgCalculator
    {
        public double Calculate(double first)
        {
            return Math.Cos(first);
        }
    }
}