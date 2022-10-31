using System;

namespace Sade_ve_murekkeb_ededler
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("number=");
            n = int.Parse(Console.ReadLine());
            int divisors = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    divisors++;
                }
            }
            if (divisors == 2)
            {
                Console.WriteLine("Verilmis eded sade ededdir");
            }
            else
            {
                Console.WriteLine("Verilmis eded murekkeb ededdir");
            }
            Console.ReadLine();
        }
    }
}
