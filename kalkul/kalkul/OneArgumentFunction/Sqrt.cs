using System;

namespace kalkul.OneArgumentFunction
{
    public class Sqrt : IOneArgCalculator
    {
        public double Calculate(double first)
        {
            return Math.Sqrt(first);
        }
    }
}