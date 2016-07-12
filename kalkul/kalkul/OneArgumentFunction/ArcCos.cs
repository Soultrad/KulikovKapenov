using System;

namespace kalkul.OneArgumentFunction
{
    public class ArcCos:IOneArgCalculator
    {
        public double Calculate(double first)
        {
            return Math.Acos(first);
        }
    }
}