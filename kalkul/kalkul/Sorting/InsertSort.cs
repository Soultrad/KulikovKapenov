namespace kalkul.Sorting
{
    public class InsertSort : ISort
    {
        public double[] Sort(double[] a)
        {
            double x;
            long i, j;

            for (i = 0; i < a.Length; i++)
            {  // цикл проходов, i - номер прохода
                x = a[i];

                // поиск места элемента в готовой последовательности 
                for (j = i - 1; j >= 0 && a[j] > x; j--)
                    a[j + 1] = a[j];  	// сдвигаем элемент направо, пока не дошли

                // место найдено, вставить элемент
                a[j + 1] = x;
            }

            return a;
        }
    }
}