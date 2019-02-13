using System;

namespace Park
{
    public static class Sort
    {
        public delegate bool sortingDirection(int a, int b);

        public static bool IsBigger(int a, int b)
        {
            if (a > b)
                return true;
            else
                return false;
        }

        public static bool IsSmaller(int a, int b)
        {
            if (a < b)
                return true;
            else
                return false;
        }

       

        public static void BubbleSort(int[] target, sortingDirection sort)
        {
            int temp;

            for(int n1 = 0; n1 < target.Length ; n1 ++)
            {
                for (int n2 = 0; n2 < target.Length-1 ; n2 ++)
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
        
    }

    public class MainApp
    {
        static void Main(string[] args)
        {
            int[] a = new int[10] { 2, 4, 6, 8, 10, 3, 7, 5, 1, 9 };
            PrintArray(a);


            Sort.BubbleSort(a, new Sort.sortingDirection(Sort.IsSmaller));
            PrintArray(a);

            Sort.BubbleSort(a, new Sort.sortingDirection(Sort.IsBigger));
            PrintArray(a);

        }

        static void HandlesortingDirection(int a, int b)
        {
        }


        static void PrintArray(int[] array)
        {
            Console.Write("Elements : ");
            foreach (int n in array)
            {
                Console.Write($"{n} ");
            }
            Console.WriteLine();
        }
    }
}