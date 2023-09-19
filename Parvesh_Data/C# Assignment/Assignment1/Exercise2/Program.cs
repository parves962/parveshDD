using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the FirstName : ");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Enter the LastName : ");
            string LastName = Console.ReadLine();

            Console.WriteLine("Comparing firstName and LastName using ==");
            if(FirstName == LastName)
            {
                Console.WriteLine("FirstName and lastName is same");
            }
            else
            {
                Console.WriteLine("Alright!");
            }

            Console.WriteLine("Comparing firstName and LastName using .equals");
            if (FirstName.Equals(LastName)) 
            {
                Console.WriteLine("FirstName and LastName is same");
            }
            else
            {
                Console.WriteLine("Alright!");
            }

            Console.WriteLine("Comparing firstName and LastName using .ReferenceEqualsMethods");
            if(object.ReferenceEquals(FirstName,LastName))
            {
                Console.WriteLine("FirstName and LastName is same");
            }
            else
            {
                Console.WriteLine("Alright!");
            }

                Console.ReadKey();
        }
    }
}
