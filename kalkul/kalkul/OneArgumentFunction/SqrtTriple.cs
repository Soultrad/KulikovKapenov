using System;

namespace kalkul.OneArgumentFunction
{
    public class SqrtTriple:IOneArgCalculator
    {
        public double Calculate(double first)
        {
            if (first < 0)
            {
                throw new Exception("Отрицательное число в корне");
            }
            return Math.Pow(first, 1.0/3);
        }
    }
}