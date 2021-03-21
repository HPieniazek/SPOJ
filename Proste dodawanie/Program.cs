using System;

namespace Proste_dodawanie
{
    class Program
    {
        static void Main(string[] args)
        {
            long suma = 0;         
            string wpis = Console.ReadLine();
            var s1 = wpis.Split(" ");
            for (int i = 0; i < s1.Length; i++)
            {
                long n = long.Parse(s1[i]);
                suma += n;
            }
            Console.WriteLine(suma);
            
        }
    }
}
