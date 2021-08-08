using System;

namespace Fibonacci_Series
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number of which you want fibonacci series: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int number1 = 0;
            int number2 = 1;
            int sumofnumbers = 0;
            
            Console.WriteLine("Fibonacci Series: ");
            Console.WriteLine("1 : {0}",number1);
            Console.WriteLine("2 : {0}",number2);
            for(int i = 0; i <= N-3; i++)
            {
                sumofnumbers = number1 + number2;
                number1 = number2;
                number2 = sumofnumbers;

                Console.WriteLine((i+3) + " : "+sumofnumbers);
            }
        }
    }
}
