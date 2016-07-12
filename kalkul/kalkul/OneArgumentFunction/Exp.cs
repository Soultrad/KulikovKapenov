using System;

namespace kalkul.OneArgumentFunction
{
    public class Exp:IOneArgCalculator
    {
        public double Calculate(double first)
        {
            return Math.Exp(first);
        }
    }
}