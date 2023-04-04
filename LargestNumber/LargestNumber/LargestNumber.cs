using System;

namespace LargestNumber
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.Write("Find the largest among three numbers");
            Console.Write("\n\n");
            Console.Write("Enter the 1st number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 2nd number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 3rd number: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("The 1st number is the greatest among three.");
                }
                else
                {
                    Console.WriteLine("The 3rd number is the greatest among three.");
                }
            }
            else if (num2 > num3)
                Console.WriteLine("The 2nd number is the greatest among three.");
            else
                    Console.WriteLine("The 3rd number is the greatest among three.");
        }
    }
}
