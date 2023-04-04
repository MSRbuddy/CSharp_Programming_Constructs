namespace WeekDay
{
    internal class WeekDay
    {
        static void Main(string[] args)
        {
            int weekday;
  
            // Enter weekday number
            Console.WriteLine("Enter weekday number (1-7): ");
            weekday = Convert.ToInt32(Console.ReadLine());
  
            // Using switch case to validate
            switch (weekday)
            {
                case 1:
                    Console.WriteLine("It is SUNDAY");
                    break;
                case 2:
                    Console.WriteLine("It is MONDAY");
                    break;
                case 3:
                    Console.WriteLine("It is TUESDAY");
                    break;
                case 4:
                    Console.WriteLine("It is WEDNESDAY");
                    break;
                case 5:
                    Console.WriteLine("It is THURSDAY");
                    break;
                case 6:
                    Console.WriteLine("It is FRIDAY");
                    break;
                case 7:
                    Console.WriteLine("It is SATURDAY");
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    break;
            }
        }
    }
}