using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1 = 0 ;
            int Num2 = 0;
            Console.WriteLine("Enter the number between 2 AND 1000");
            while(Num1 <= 2)
            {
            Console.WriteLine("Enter the first number :");
                Num1 = Convert.ToInt32(Console.ReadLine());
                if(Num1 <=2 )
                {
                    Console.WriteLine("Please enter a valid input");
                }
            }

            while(Num1 == Num2 || Num1 > Num2)
            {
                Console.WriteLine("enter the second number :");
                Num2 = Convert.ToInt32(Console.ReadLine());
                if(Num1 == Num2 || Num1 > Num2)
                {
                    Console.WriteLine("Please Enter a valid Input");
                }
            }
 
            bool PrimeFlag = true;
            Console.WriteLine("Prime numbers between " + Num1 + " and " +Num2 );
            Num1 += 1;
            Num2 -= 1;
            int PrimeCount = 0;
            while (Num1   < Num2)
            {
                for(int i =2; i < Num1; i++)
                {
                    if(Num1 % i == 0)
                    {
                        PrimeFlag = false;
                        break;
                    }
                }
                if(PrimeFlag)
                {
                    Console.WriteLine(Num1);
                    PrimeCount += 1;
                }
                PrimeFlag = true;
                Num1 += 1;
            }
            if(PrimeCount == 0)
            {
                Console.WriteLine("No prime number between the given inputs");
            }
            Console.ReadKey();
        }
    }
}
