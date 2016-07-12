using System;

namespace kalkul.OneArgumentFunction
{
    public class Tg : IOneArgCalculator
    {
        public double Calculate(double first)
        {
            return Math.Tan(first);
        }
    }
}