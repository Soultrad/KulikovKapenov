namespace kalkul.OneArgumentFunction
{
    public interface IOneArgCalculator
    {
        /// <summary>
        /// Interface for one argument functions.
        /// </summary>
        /// <param name="first">Variable for one argument function.</param>
        /// <returns></returns>
        double Calculate(double first);
    }
}