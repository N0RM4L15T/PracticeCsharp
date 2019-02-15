using System;

namespace Park
{
    public static class Sort
    {
        public delegate bool sortingDirection<T>(T a, T b) where T : IComparable;

        public static bool Ascending<T>(T a, T b) where T : IComparable
        {
            if (a.CompareTo(b) < 0)
                return true;
            else
                return false;
        }

        public static bool Descending<T>(T a, T b) where T : IComparable
        {
            if (a.CompareTo(b)>0)
                return true;
            else
                return false;
        }
     
        public static void BubbleSort<T>(T[] target, sortingDirection<T> sort) where T : IComparable
        {
            T temp;

            try
            {
                for (int n1 = 0; n1 < target.Length; n1++)
                {
                    for (int n2 = 0; n2 < target.Length - 1; n2++)
                    {

                        if (sort(target[n1], target[n2]))
                        {
                            temp = target[n1];
                            target[n1] = target[n2];
                            target[n2] = temp;
                        }
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Out of bounds in arrays");
            }
        }

        public static void CocktailSort<T>(T[] target, sortingDirection <T> sort) where T : IComparable
        {
            T temp;
            int half = target.Length / 2;

            try
            {
                for (int n1 = 0; n1 < half; n1++)
                {
                    int n2 = n1 + 1;
                    while(n2 < target.Length - n1 - 1)
                    {
                        if (sort(target[n1], target[n2]))
                        {
                            temp = target[n1];
                            target[n1] = target[n2];
                            target[n2] = temp;
                        }
                        n2++;
                    }
                    while (n2 > n1)
                    {
                        if (sort(target[n2], target[n1]))
                        {
                            temp = target[n1];
                            target[n1] = target[n2];
                            target[n2] = temp;
                        }
                        n2--;
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Out of bounds in arrays");
            }
        }
    }

    public class MainApp
    {
        static void Main(string[] args)
        {
            int[] a = new int[10] { 2, 4, 6, 8, 10, 3, 7, 5, 1, 9 };
            double[] b = new double[15] { 1.3, 1.5, 3.14, 2, 1, 100.54, 4.9, 8.7, 2.5, 67.36, 1579.2468, 25.4, 32.11, 11.11, 42 };

            PrintArray(a);
            PrintArray(b);

            Sort.CocktailSort(a, new Sort.sortingDirection<int>(Sort.Ascending));
            PrintArray(a);

            Sort.CocktailSort(a, new Sort.sortingDirection<int>(Sort.Descending));
            PrintArray(a);
                       
            Sort.BubbleSort(a, new Sort.sortingDirection<int>(Sort.Ascending));
            PrintArray(a);

            Sort.BubbleSort(a, new Sort.sortingDirection<int>(Sort.Descending));
            PrintArray(a);

            Sort.BubbleSort(b, new Sort.sortingDirection<double>(Sort.Ascending));
            PrintArray(b);

            Sort.BubbleSort(b, new Sort.sortingDirection<double>(Sort.Descending));
            PrintArray(b);
        }

        static void PrintArray<T>(T[] array)
        {
            Console.Write("Elements : ");
            try
            {
                for (int n = 0; n < array.Length; n++)
                {
                    Console.Write($"{array[n]} ");
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Out of bounds in arrays");
            }
            Console.WriteLine();
        }
    }
}