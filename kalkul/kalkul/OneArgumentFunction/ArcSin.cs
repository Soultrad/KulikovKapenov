using System;

namespace kalkul.OneArgumentFunction
{
    public class ArcSin:IOneArgCalculator
    {
        public double Calculate(double first)
        {
            return Math.Asin(first);
        }
    }
}