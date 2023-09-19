using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a number");

            string input = Console.ReadLine();
            int num = int.Parse(input);
            int num1 = Convert.ToInt32(input);
            int num2;
            bool success = int.TryParse(input, out num2);

            Console.WriteLine();
            Console.WriteLine("Changing input into integer by : ");
            Console.WriteLine("using int.parse : " + num);
            Console.WriteLine("using Convert.ToInt32 : " + num1);
            if (success == true)
            {
                Console.WriteLine("using int.tryParse : " + num2);
            }

            Console.WriteLine("using float.parse : " + float.Parse(input));

            Console.WriteLine();
            Console.WriteLine("enter a bool value as string : ");
            string input1 = Console.ReadLine();
            bool bvalue = Convert.ToBoolean(input1);
            Console.WriteLine("Convert string into boolean value ");
            Console.WriteLine("using Convert.ToBoolean : " + bvalue);


            Console.ReadKey();
        }
    }
}
