using System;

namespace Csharp
{
    class Program
    {
        public static void Main(string[] args) {
            int num1 = 10;
            int num2 = 20;
            string num3 = "10.1234567890123456789";
            double num4 = 10.1234567890123;
            string userInput;
            int[] fib;
            fib = new int[]{ 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };

            System.Console.WriteLine($"Sum is {num1 + num2}");
            System.Console.WriteLine($"It also can be said as 0x{(num1 + num2):X}");

            System.Console.WriteLine($"{double.Parse(num3)}");
            System.Console.WriteLine(num3);
            System.Console.WriteLine(num4 == double.Parse(num3));

            for(int n = 0; n < 10; n++)
            {
                System.Console.Write($"{fib[n]} ");
            }
            System.Console.WriteLine();

            System.Console.Write("Write freely : ");
            userInput = System.Console.ReadLine();
            System.Console.WriteLine($"Number of character : {userInput.Length}");
            System.Console.WriteLine($"To uppercase : {userInput.ToUpper()}");

            char[] reverse = userInput.ToCharArray();
            System.Array.Reverse(reverse);

            if (userInput == new string(reverse))
            {
                System.Console.WriteLine("This is palindrome.");
            }

        }
    }
}
