using System;

namespace kalkul.Sorting
{
    public static class SortFactory
    {
        public static ISort CreateSort(string sortName)
        {
            switch (sortName)
            {
                case "SelectSort":
                    return new SelectSort();
                case "InsertSort":
                    return new InsertSort();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}