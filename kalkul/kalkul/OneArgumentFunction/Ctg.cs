using System;

namespace kalkul.OneArgumentFunction
{
    public class Ctg : IOneArgCalculator
    {
        public double Calculate(double first)
        {
            return 1/Math.Tan(first);
        }
    }
}