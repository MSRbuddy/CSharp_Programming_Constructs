namespace CastingVote
{
    internal class CastingVote
    {
        static void Main(string[] args)
        {
            int vote_age;
            Console.WriteLine("Enter the age of the candidate : ");
            vote_age = Convert.ToInt32(Console.ReadLine());
            if (vote_age >= 18)
            {
                Console.WriteLine("You are eligible for casting your vote");
            }
            else
                Console.WriteLine("You are not eligible to caste your vote");           
        }
    }
}