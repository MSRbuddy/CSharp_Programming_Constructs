namespace SumOfNaturalNmbrs
{
    internal class SumOfNaturalNums
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of first 5 Natural Numbers: ");
            int i=1, sum = 0;
            while (i<=5)
            {
                sum = sum + i;
                i++;
            }
            Console.WriteLine(sum);
        }
    }
}