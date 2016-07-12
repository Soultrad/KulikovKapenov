using System;

namespace kalkul.OneArgumentFunction
{
    public class LogTen:IOneArgCalculator
    {
        public double Calculate(double first)
        {
            return Math.Log10(first);
        }
    }
}