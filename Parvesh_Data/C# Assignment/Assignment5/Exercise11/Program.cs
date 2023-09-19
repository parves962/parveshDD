using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    public static class ExtensionMethod
    {
        public static bool IsPrime(this int number)
        {
            for(int i =2; i < number; i++)
            {
                if(number %i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsEven(this int number)
        {
            if(number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsOdd(this int number)
        {
            if (number % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsDivisibleby(this int divisor,int divident)
        {
            if(divident%divisor == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a integer ");
            int number = Convert.ToInt32(Console.ReadLine());
            if(number.IsEven())
            {
                Console.WriteLine("Entered number is even");
            }
            else
            {
                Console.WriteLine("entered number is not even");
            }
            if(number.IsOdd())
            {
                Console.WriteLine("entered number is odd");
            }
            else
            {
                Console.WriteLine("entered number is not odd");
            }
            if(number.IsPrime())
            {
                Console.WriteLine("Enter number is prime");
            }
            else
            {
                Console.WriteLine("Entered number is not prime");
            }

            if (number.IsDivisibleby(100))
            {
                Console.WriteLine("Entered number is divisible by 100");
            }
            else
            {
                Console.WriteLine("entered number is not divisible by 100");
            }

            Console.ReadKey();
        }
    }
}
