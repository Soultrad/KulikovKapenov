using System;

namespace kalkul.OneArgumentFunction
{
    public static class OneArgumentFactory
    {
        /// <summary>
        /// Factory for one argument fuctions.
        /// </summary>
        /// <param name="calculatorName"></param>
        /// <returns></returns>
        public static IOneArgCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "Sin":
                    return new Sin();
                case "Cos":
                    return new Cos();
                case "Tg":
                    return new Tg();
                case "Ctg":
                    return new Ctg();
                case "Sqr":
                    return new Sqr();
                case "Sqrt":
                    return new Sqrt();
                case "ArcSin":
                    return new ArcSin();
                case "ArcCos":
                    return new ArcCos();
                case "SqrtTriple":
                    return new SqrtTriple();
                case "SqrTriple":
                    return new SqrTriple();
                case "Ln":
                    return new Ln();
                case "LogTen":
                    return new LogTen();
                case "Exp":
                    return new Exp();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}