using System;

namespace kalkul.TwoArgumentFunction
{
    public static class TwoArgumentFactory
    {
        /// <summary>
        /// Factory for two argument fuctions.
        /// </summary>
        /// <param name="calculatorName"></param>
        /// <returns></returns>
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