using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    interface iDuck
    {
        void ShowDetails();
    }

    class Rubber: iDuck
    {
        int Weight;
        int Wings;

        public Rubber(int weight,int wings)
        {
            this.Weight = weight;
            this.Wings = wings;
        }

        public void ShowDetails()
        {
            Console.WriteLine("This is Rubber Duck");
            Console.WriteLine("It has "+this.Wings+" wings and has "+this.Weight+" kg weight");
            Console.WriteLine("Rubber ducks don’t fly and squeak.");
        }
    }

    class Mallard : iDuck
    {
        int Weight;
        int Wings;

        public Mallard(int weight, int wings)
        {
            this.Weight = weight;
            this.Wings = wings;
        }

        public void ShowDetails()
        {
            Console.WriteLine("This is Mallard Duck");
            Console.WriteLine("It has " + this.Wings + " wings and has " + this.Weight + " kg weight");
            Console.WriteLine("Mallard ducks fly fast and quack loud.");

        }
    }

    class ReadHead : iDuck
    {
        int Weight;
        int Wings;

        public ReadHead(int weight, int wings)
        {
            this.Weight = weight;
            this.Wings = wings;
        }

        public void ShowDetails()
        {
            Console.WriteLine("This is ReadHead Duck");
            Console.WriteLine("It has " + this.Wings + " wings and has " + this.Weight + " kg weight");
            Console.WriteLine("Redhead ducks fly slow and quack mild.");

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Rubber r1 = new Rubber(1, 4);
            Console.WriteLine("Duck created");
            Console.WriteLine();
            Console.WriteLine("Duck details =>");
            r1.ShowDetails();
            Console.WriteLine();

            Mallard m1 = new Mallard(2, 3);
            Console.WriteLine("2nd duck created");
            m1.ShowDetails();
            Console.WriteLine();


            ReadHead R1 = new ReadHead(3, 5);
            Console.WriteLine("3rd duck created");
            R1.ShowDetails();

            Console.ReadKey();
        }
    }
}
