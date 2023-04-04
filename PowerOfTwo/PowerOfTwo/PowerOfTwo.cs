namespace PowerOfTwo
{
    internal class PowerOfTwo
    {
        public static int highestPowerof2(int n)
        {
            int res = 0;
            for (int i = n; i >= 1; i--)
            {
                // If i is a power of 2
                if ((i & (i - 1)) == 0)
                {
                    res = i;
                    break;
                }
            }
            return res;
        }

        // Driver Code
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(highestPowerof2(n));
        }
    }
}