using System;

namespace EvenOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter the number: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine(n + "is Even Number");
            }               
            else
            {
                Console.WriteLine(n + "is Odd Number");
            }               
        }
    }
}
