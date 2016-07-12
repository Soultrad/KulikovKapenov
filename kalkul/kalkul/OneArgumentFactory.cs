using System;

namespace kalkul
{
    public static class OneArgumentFactory
    {
        public static IOneArgCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "sin":
                    return new Sin();
                case "cos":
                    return new Cos();

                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}