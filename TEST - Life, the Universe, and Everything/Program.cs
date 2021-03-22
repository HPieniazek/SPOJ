using System;

namespace TEST___Life__the_Universe__and_Everything
{
    class Program
    {
        static void Main(string[] args)
        {
            string n1 = Console.ReadLine();
            
            int n = Convert.ToInt32(n1);
            if (n != 42) 
            {
                Console.WriteLine(n1);
                string n2 = Console.ReadLine();
            }
            if (n == 41)
            {
                return;
            }   
            
        }
    }
}
