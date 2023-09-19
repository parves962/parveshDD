using System;
using Assignment4;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class  Equipment
    {
        public string Name;
        public string Description;
        public int DistanceMoved;
        public int Wheels;
        public int Weight;
        public int MaintainenceCost;

        public Equipment(string name,string description,int wheels,int weight,int distanceMoved)
        {
            if (description == "Mobile")
            {
                this.Name = name;
                this.Description = description;
                this.Wheels = wheels;
                this.DistanceMoved = distanceMoved;
            }
            else
            {
                this.Name = name;
                this.Description = description;
                this.Weight= weight;
                this.DistanceMoved = distanceMoved;
            }
        }

        public  void MoveAround(int distanceMoved)
        {
            if(this.Description == "Mobile")
            {
                this.DistanceMoved += distanceMoved;
                this.MaintainenceCost += this.Wheels * distanceMoved;
            }
            else
            {
                this.DistanceMoved += distanceMoved;
                this.MaintainenceCost += this.Weight * distanceMoved;
            }
            
        }

        public  void ShowDetails()
        {
            if (this.Description == "Mobile")
            {
                Console.WriteLine("Equipment Name :" + this.Name);
                Console.WriteLine("Description : " + this.Description);
                Console.WriteLine("Distance Moved :" + this.DistanceMoved);
                Console.WriteLine("MaintaineneceCost : " + this.MaintainenceCost);
                Console.WriteLine("Weight : " + this.Wheels);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Equipment Name :" + this.Name);
                Console.WriteLine("Description : " + this.Description);
                Console.WriteLine("Distance Moved :" + this.DistanceMoved);
                Console.WriteLine("MaintaineneceCost : " + this.MaintainenceCost);
                Console.WriteLine("Weight : " + this.Weight);
                Console.WriteLine();
                // Console.WriteLine("EquipMentTYpe : "+this.T);
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            var EquipList = new List<Equipment>();

            var Equip1 = new Equipment("Car", "Mobile", 4, 0, 0);
            var Equip2 = new Equipment("Roller", "Immobile", 0, 100, 0);
            var Equip3 = new Equipment("Jeep", "Mobile", 4, 0, 0);

            EquipList.Add(Equip1);
            EquipList.Add(Equip2);
            EquipList.Add(Equip3);

            foreach(var equip in EquipList)
            {
                equip.ShowDetails();
            }

            var enum1 = from equip in EquipList
                        select equip;

            Console.WriteLine("Equipment name and description");
            foreach(var equip in enum1)
            {
                Console.WriteLine("Name : "+equip.Name);
                Console.WriteLine("Description : "+ equip.Description);
            }
            Console.WriteLine();

            Equip1.MoveAround(20);
            Equip2.MoveAround(20);

            Console.WriteLine("After moving the items");
            Equip1.ShowDetails();
            Equip2.ShowDetails();

            Console.WriteLine("Equipment that are moved 0 distance");
            var enum3 = EquipList.Where(x => x.DistanceMoved == 0).ToList();
            foreach (var equip in enum3)
            {
                equip.ShowDetails();
            }

            var enum2 = EquipList.Where(x => x.Description == "Mobile").ToList();
            Console.WriteLine("Listing mobile equipment using lambda ");
            foreach(var equip in enum2)
            {
                equip.ShowDetails();
            }

            //removing mobile equipment
            Console.WriteLine("After removing Mobile Equipments");
            EquipList = EquipList.Where(x => x.Description != "Mobile").ToList();
            foreach (var equip in EquipList)
            {
                equip.ShowDetails(); 
            }

            //deleting all equipments
            var enum4 = EquipList;
            enum4.Clear();

            //deleting immobile equipment
            Console.WriteLine("After removing Immobile Equipments");
            EquipList = EquipList.Where(x => x.Description != "Immobile").ToList();
            foreach (var equip in EquipList)
            {
                equip.ShowDetails();
            }


            Console.ReadKey();

        }
    }
}
