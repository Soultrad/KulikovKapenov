using System;

namespace kalkul
{
    public class Sin:IOneArgCalculator
    {
        public double Calculate(double first)
        {
            return Math.Sin(first);
        }
    }
}