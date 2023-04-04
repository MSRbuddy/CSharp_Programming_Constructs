namespace FactorialOfNum
{
    internal class Factorial
    {
        static void Main(string[] args)
        {
            int i, factorial = 1, num;

            Console.WriteLine("Calculate the factorial of a given number:");

            Console.WriteLine("Input the number : ");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
                factorial = factorial * i;

            Console.WriteLine("The Factorial of {0} is: {1}", num, factorial);
        }
    }
}