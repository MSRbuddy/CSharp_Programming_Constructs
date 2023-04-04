namespace AdmissionEligiblity
{
    internal class AdmsnEligibility
    {
        static void Main(string[] args)
        {
            int p, c, m;

            Console.WriteLine("Find eligibility for admission :");

            Console.WriteLine("Eligibility Criteria :");
            Console.WriteLine("Marks in Maths >=65");
            Console.WriteLine("Marks in Phy >=55");
            Console.WriteLine("Marks in Chem>=50");
            Console.WriteLine("Total in all three subject >=180");
            Console.WriteLine("Total in Maths and Physics >=140");


            Console.WriteLine("Enter the marks obtained in Physics :");
            p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the marks obtained in Chemistry :");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the marks obtained in Mathematics :");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Total marks of Maths, Physics and Chemistry : {0}", m + p + c);
            Console.WriteLine("Total marks of Maths and  Physics : {0}", m + p);

            if (m >= 65)
                if (p >= 55)
                    if (c >= 50)
                        if ((m + p + c) >= 180 || (m + p) >= 140)
                            Console.WriteLine("The  candidate is eligible for admission");
                        else
                            Console.WriteLine("The candidate is not eligible");
                    else
                        Console.WriteLine("The candidate is not eligible");
                else
                    Console.WriteLine("The candidate is not eligible");
            else
                Console.WriteLine("The candidate is not eligible");
        }
    }
}