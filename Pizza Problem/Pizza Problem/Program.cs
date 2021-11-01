using System;
using System.Collections.Generic;
using System.Linq;

class pizza
{
    public static void Main()
    {

        List<long> x = new List<long>();
        string X = Console.ReadLine();
        long number;

        if (Int64.TryParse(X, out number) && number >=1)
        {
            x.Add(number);
            List<long> xList = x.Distinct().ToList();
            List<long> list = new List<long>();

            for (int i = 0; i < x.Count; i++)
            {
                long value = x[i];
                long Z = (value * value + value + 2) / 2;

                list.Add(Z); 

            }

            foreach (int item in list)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
