using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string wpis = Console.ReadLine();
            string[] n = wpis.Split(" ");
            double x = Convert.ToDouble(n[0]);
            double y = Convert.ToDouble(n[1]);
            double z = Math.Pow(x, y);
            double a = z % 10;
            Console.WriteLine(a);

        }
    }   
}
