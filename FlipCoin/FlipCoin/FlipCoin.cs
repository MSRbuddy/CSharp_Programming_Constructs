using System;
using System.Collections.Generic;
using System.Text;


namespace FlipCoin
{

    class FlipCoin
    {
        static void Main(String[] args)
        {
            public FlipCoin()
            {
                flipCoin();
            }
            public void flipCoin()
            {
                Console.WriteLine("Enterthe no.of  times coin flipped: ");
                int number = int.Parse(Console.ReadLine());
                if (number <= 0)
                    Console.WriteLine("Coin is not fliped try again!");
                else
                {
                    double t = number;
                    double head = 0, tail = 0;
                    while (number > 0)
                    {
                        Random random = new Random();
                        float num = (float)random.NextDouble();
                        //Console.WriteLine(number);
                        if (number > 0.5)
                        { head++; }
                        else
                        { tail++; }
                        number--;
                    }
                    double h = (head / t);
                    double ta = (tail / t);

                    Console.WriteLine("Heads vs Tails is: " + h + " and " + ta);
                }
            }
        }
    }
}
