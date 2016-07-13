namespace kalkul.Sorting
{
    public class SelectSort : ISort
    {
        public double[] Sort(double[] a)
        {
            long i, j, k;
            double x;

            for (i = 0; i < a.Length; i++)
            {
                // i - номер текущего шага
                k = i;
                x = a[i];

                for (j = i + 1; j < a.Length; j++) // цикл выбора наименьшего элемента
                    if (a[j] < x)
                    {
                        k = j;
                        x = a[j]; // k - индекс наименьшего элемента
                    }

                a[k] = a[i];
                a[i] = x; // меняем местами наименьший с a[i]
            }

            return a;
        }

    }
}