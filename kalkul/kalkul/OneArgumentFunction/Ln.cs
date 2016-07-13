using System;

namespace kalkul.OneArgumentFunction
{
    public class Ln:IOneArgCalculator
    {
        public double Calculate(double first)
        {
            if (first < 0)
            {
                throw new Exception("Логарифм из отрицательного числа");
            }
            return Math.Log(first,Math.E);
        }
    }
}