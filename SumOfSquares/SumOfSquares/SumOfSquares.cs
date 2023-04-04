namespace SumOfSquares
{
    internal class SumOfSquares
    {
        static void Main(string[] args)
        {
            int i, n, sum = 0;
            Console.WriteLine("Enter the value of n :");

            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                sum += i*i;
            }

            Console.WriteLine("Total sum of squares : " + sum);
        }
    }
}
    