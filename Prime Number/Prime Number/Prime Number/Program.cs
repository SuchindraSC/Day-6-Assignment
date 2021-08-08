using System;

namespace Prime_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter the Number to check whether Number is Prime or Not: ");
            number = int.Parse(Console.ReadLine());
            bool IsPrime = true;
            for (int i = 2; i < number/2; i++)
            {
                if (number%i == 0)
                {
                    IsPrime = false;
                    break;
                }
            }
            if (IsPrime)
            {
                Console.WriteLine("The number is Prime Number");
            }
            else 
            {
                Console.WriteLine("The Number is not a Prime Number");
            }
        }
    }
}
