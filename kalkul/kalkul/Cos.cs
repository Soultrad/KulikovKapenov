using System;

namespace kalkul
{
    public class Cos:IOneArgCalculator
    {
        public double Calculate(double first)
        {
            return Math.Cos(first);
        }
    }
}