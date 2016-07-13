using System;

namespace kalkul.OneArgumentFunction
{
    public class Sqrt : IOneArgCalculator
    {
        public double Calculate(double first)
        {
            if (first < 0)
            {
                throw new Exception("Отрицательное число в корне");
            }
            return Math.Sqrt(first);
        }
    }
}