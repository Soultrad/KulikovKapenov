using System;

namespace kalkul
{
    public static class TwoArgumentFactory
    {
        public static ITwoArgCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "plus":
                    return new Plus();
                case "minus":
                 return new Minus();
                case "ymno":
                    return new Multiplication();
                case "delenie":
                    return new Divide();
                   
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}