using System;

namespace Coupon_Numbers
{
    class Program
    {
        static void CouponNumber(int num)
        {
            Random rand = new Random();
            int Count = 0;
            
            while (true)
            {
                int RandomNumber = rand.Next(0, 101);
                if (RandomNumber == num)
                {
                    Console.WriteLine("The Count is " + Count);
                    break;
                }
                else
                {
                    Count++;
                }
            }
           
                
            }
           
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter A Number: ");
            num = Convert.ToInt32(Console.ReadLine()); 
            CouponNumber(num);
        }
    }
}
