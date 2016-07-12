using System;

namespace kalkul.OneArgumentFunction
{
    public class Sin:IOneArgCalculator
    {
        public double Calculate(double first)
        {
            return Math.Sin(first);
        }
    }
}