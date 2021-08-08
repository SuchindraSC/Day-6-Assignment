using System;

namespace Perfect_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num, i, sum = 0;
            Console.Write("Enter The Number To Check Whether The Number Is Perfect Number Or Not: ");
            Num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= Num/2; i++)
            {
                if (Num % i == 0)
                {
                    sum = sum + i;
                    Console.WriteLine("\nThe Divisors Are {0}", i);
                }
            }
            if (sum == Num)
            {
                Console.WriteLine("\n{0} Is A Perfect Number ", Num);
            }
            else
            {
                Console.WriteLine("\n{0} Is Not A Perfect Number ", Num);
            }
        }
    }
}
