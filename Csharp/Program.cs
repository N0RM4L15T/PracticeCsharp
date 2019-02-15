using System;
using static Park.Sort<int>;
using static Park.Sort<double>;
using sortingDirection = Park.Sort<int>.sortingDirection;

namespace Park
{
    public static class Sort<T> where T : IComparable
    {
        public delegate bool sortingDirection(T a, T b);

        public static bool Ascending(T a, T b)
        {
            if (a.CompareTo(b) < 0)
                return true;
            else
                return false;
        }

        public static bool Descending(T a, T b)
        {
            if (a.CompareTo(b)>0)
                return true;
            else
                return false;
        }

        public static void Swap(ref T a,ref T b, sortingDirection compare)
        {
            if (compare(a, b))
            {
                T temp = a;
                a = b;
                b = temp;
            }
        }

        public static void BubbleSort(T[] target, sortingDirection compare)
        {
            int len = target.Length;

            try
            {
                for (int n1 = 0; n1 < len; n1++)
                {
                    for (int n2 = 0; n2 < len - 1; n2++)
                    {
                        Swap(ref target[n1], ref target[n2], compare);
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Out of bounds in arrays");
            }
        }

        public static void CocktailSort(T[] target, sortingDirection compare)
        {
            int len = target.Length;
            int half = len / 2;

            try
            {
                for (int n1 = 0; n1 < half; n1++)
                {
                    int n2 = n1 + 1;
                    while(n2 < (len - n1 - 1))
                    {
                        Swap(ref target[n1], ref target[n2], compare);
                        n2++;
                    }
                    while (n2 > n1)
                    {
                        Swap(ref target[n2], ref target[n1], compare);
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
            int[] a = { 2, 4, 6, 8, 10, 3, 7, 5, 1, 9 };
            double[] b = { 1.3, 1.5, 3.14, 2, 1, 100.54, 4.9, 8.7, 2.5, 67.36, 1579.2468, 25.4, 42, 11.11,};

            PrintArray(a);
            PrintArray(b);

            BubbleSort(a, new sortingDirection(Ascending));
            PrintArray(a);

            BubbleSort(a, new sortingDirection(Descending));
            PrintArray(a);

            CocktailSort(a, new sortingDirection(Ascending));
            PrintArray(a);

            CocktailSort(a, new sortingDirection(Descending));
            PrintArray(a);

            CocktailSort(b, new Sort<double>.sortingDirection(Ascending));
            PrintArray(b);

            CocktailSort(b, new Sort<double>.sortingDirection(Descending));
            PrintArray(b);
        }

        static void PrintArray<T>(T[] array)
        {
            int len = array.Length;
            Console.Write("Elements : ");
            try
            {
                for (int n = 0; n < len; n++)
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