using System;

namespace dodawanieLiczbCalkowitych
{
    class Program
    {
        static void Main(string[] args)
        {
            string a1 = Console.ReadLine();
            string b1 = Console.ReadLine();
            string c1= Console.ReadLine();

            int a = Convert.ToInt32(a1);
            int b = Convert.ToInt32(b1);
            int c = Convert.ToInt32(c1);
            Console.WriteLine(a + b + c);
        }
    }
}
