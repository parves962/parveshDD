using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    class Duck
    {
        public string Name { get; set; }
        public string Quack { get; set; }

        public string Fly { get; set; }
        public int Weight { get; set; }
        public int Wings { get; set; }

        public Duck(string name,string quack,string fly,int weight, int wings)
        {
            this.Name = name;
            this.Quack = quack;
            this.Fly = fly;
            this.Weight = weight;
            this.Wings = wings;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var DuckList = new List<Duck>();

            //Adding Ducks to the List
            DuckList.Add(new Duck("Rubber", "Sqeak","Dont fly", 3 ,4));
            DuckList.Add( new Duck("Mallard", "Quacl loud","fly fast", 2, 2));
            DuckList.Add( new Duck("Readhead", "Quack mild", "fly slow",1, 1));
            DuckList.Add(new Duck("Readhead1", "mild", "fly very slow", 4, 3));

            Console.WriteLine("DuckList =>");
            foreach(var duck in DuckList)
            {
                Console.WriteLine(duck.Name + " " + duck.Quack + " and " + duck.Fly + " and it has " + duck.Wings + " wings and has " + duck.Weight + "kg weight");
            }
            Console.WriteLine();

            //Removing Ducks
            DuckList = DuckList.Where(x => x.Name != "Readhead1").ToList();

            Console.WriteLine(" After removing a element DuckList =>");
            foreach (var duck in DuckList)
            {
                Console.WriteLine(duck.Name + " " + duck.Quack + " and " + duck.Fly + " and it has " + duck.Wings + " wings and has " + duck.Weight + "kg weight");
            }
            Console.WriteLine();

            var enum1 = from ducklist in DuckList
                        orderby ducklist.Weight
                        select ducklist;

            Console.WriteLine("traversing duck list by wings order");
            foreach(var duck in enum1)
            {
                Console.WriteLine(duck.Name+ " "+duck.Quack+" and "+duck.Fly+" and it has "+duck.Wings+" wings and has " + duck.Weight +"kg weight");
            }
            Console.WriteLine();

            var enum2 = from ducklist in DuckList
                        orderby ducklist.Wings
                        select ducklist;

            Console.WriteLine("Traversing duck list by weight order");
            foreach (var duck in enum2)
            {
                Console.WriteLine(duck.Name + " " + duck.Quack + " and " + duck.Fly + " and it has " + duck.Wings + " wings and has " + duck.Weight + "kg weight");
            }

            var DuckList1 = DuckList;

            //Removing all ducks
            DuckList1.Clear();

            Console.ReadKey();
        }
    }
}
