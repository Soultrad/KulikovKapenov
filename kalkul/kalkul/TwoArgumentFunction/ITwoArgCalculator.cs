namespace kalkul.TwoArgumentFunction
{
    public interface ITwoArgCalculator
    {
        /// <summary>
        /// Interface for two argument functions.
        /// </summary>
        /// <param name="first">First variable.</param>
        /// <param name="second">Second variable.</param>
        /// <returns></returns>
        double Calculate(double first, double second);
    }
}