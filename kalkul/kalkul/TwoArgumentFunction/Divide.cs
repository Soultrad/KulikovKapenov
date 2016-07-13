using System;

namespace kalkul.TwoArgumentFunction
{
    public class Divide: ITwoArgCalculator
    {
        public double Calculate(double value1, double value2)
        {
            if (value2 == 0)
            {
                throw new Exception("Деление на 0");
            }
            return (value1 / value2);
        }
    }
}