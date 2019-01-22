using System;

namespace Csharp
{
    class Program
    {
        public static void Main(string[] args) {
            string firstName;
            string lastName;

            System.Console.WriteLine("Hey you!");

            System.Console.Write("First Name : ");
            firstName = System.Console.ReadLine();

            System.Console.Write("Last Name : ");
            lastName = System.Console.ReadLine();

            System.Console.WriteLine($"Your full name is {firstName} {lastName}");
        }
    }
}
