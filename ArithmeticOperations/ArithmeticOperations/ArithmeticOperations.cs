namespace ArithmeticOperations
{
    internal class ArithmeticOperations
    {
        static void Main(string[] args)
        {
            //Reading First Number  
            Console.Write("Enter No1: ");
            int a = Convert.ToInt32(Console.ReadLine());
            //Reading Second Number  
            Console.Write("Enter No2: ");
            int b = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Subtraction");
            Console.WriteLine("3.Divsion");
            Console.WriteLine("4.Multiplication");
            
            //Reading a Choice  
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Addition Of Two Numbers is : " + (a + b));
                    break;
                case 2:
                    Console.WriteLine("Subtraction Of Two Numbers is : " + (a - b));
                    break;
                case 3:
                    Console.WriteLine("Division Of Two Numbers is : " + (a / b));
                    break;
                case 4:
                    Console.WriteLine("Multiplicaion Of Two Numbers is : " + (a * b));
                    break;
                default:
                    Console.WriteLine("Invali Entry: Choose 1-4");
                    break;
            }
        }
    }
}