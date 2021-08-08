using System;

namespace Reverse_A_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number to reverse: ");
            int number = int.Parse(Console.ReadLine());
            int remainder, reverse = 0;
            while (number > 0)
            {
                remainder = number % 10;
                reverse = (reverse * 10) + remainder;
                number = number / 10;
            }
            Console.WriteLine("The Reverse Order is " + reverse);
        }
    }
}
