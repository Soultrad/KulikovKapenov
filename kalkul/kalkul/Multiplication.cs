namespace kalkul
{
    public class Multiplication:ITwoArgCalculator
    {
        public double Calculate(double value1, double value2)
        {
            return (value1 * value2);
        }
    }
}