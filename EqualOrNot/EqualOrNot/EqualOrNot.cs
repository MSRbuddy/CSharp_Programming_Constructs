namespace EqualOrNot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int int1, int2;
            Console.WriteLine("Check whether two integers are equal or not:");
            Console.WriteLine("Enter 1st number: ");
            int1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd number: ");
            int2 = Convert.ToInt32(Console.ReadLine());

            if (int1 == int2)
            {
                Console.WriteLine("{0} and {1} are equal", int1, int2);
            }              
            else
            {
                Console.WriteLine("{0} and {1} are not equal", int1, int2);
            }    
        }
    }
}