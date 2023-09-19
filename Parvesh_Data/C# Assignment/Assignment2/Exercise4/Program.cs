using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment4
{
    public abstract class Equipment
    {
        protected string Name;
        protected string Description;
        protected int DistanceMoved = 0;
        
        enum TypeOfEquipment
        {
            MobileEquip,
            ImmobileEquip
        }

        public Equipment(string name,string description)
        {
            this.Name = name;
            this.Description = description;
            //this.DistanceMoved = distanceMoved;
        }
        public abstract void MoveAround(int distanceMoved);

        public abstract void ShowDetails();
    }

    class Mobile : Equipment
    {
        int Wheels;
        int MaintainenceCost;

        public Mobile(string name, string description,  int wheels):base(name, description)
        {
            this.Wheels = wheels;
        }

        public override void MoveAround(int distanceMoved)
        {
            this.DistanceMoved += distanceMoved;
            this.MaintainenceCost += this.Wheels * distanceMoved;
        }

        public override void  ShowDetails()
        {
            Console.WriteLine("Equipment Name :" + this.Name);
            Console.WriteLine("Description : " + this.Description);
            Console.WriteLine("Distance Moved :" + this.DistanceMoved);
            Console.WriteLine("MaintaineneceCost : " + this.MaintainenceCost);
            Console.WriteLine("Wheels : " + this.Wheels);
            // Console.WriteLine("EquipMentTYpe : "+this.T);
        }
    }

    class Immobile : Equipment
    {

        int MaintainenceCost;
        int Weight;


        public Immobile(string name, string description,  int weight) : base(name, description)
        {
            this.Weight = weight;
        }

        public override void  MoveAround(int distanceMoved)
        {
            this.DistanceMoved += distanceMoved;
            this.MaintainenceCost += this.Weight * distanceMoved;
        }

        public override void ShowDetails()
        {
            Console.WriteLine("Equipment Name :" + this.Name);
            Console.WriteLine("Description : " + this.Description);
            Console.WriteLine("Distance Moved :" + this.DistanceMoved);
            Console.WriteLine("MaintaineneceCost : " + this.MaintainenceCost);
            Console.WriteLine("Weight : " + this.Weight);
            // Console.WriteLine("EquipMentTYpe : "+this.T);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Equipment details =>");
            Equipment E1 = new Mobile("Tractor","Mobile Device",4);
            Equipment E2 = new Immobile("Roller","Immobile Device",100);
            E1.ShowDetails();
            Console.WriteLine();
            E2.ShowDetails();
            Console.WriteLine();

            E1.MoveAround(20);
            E2.MoveAround(100);

            Console.WriteLine("After moving the equipments");
            E1.ShowDetails();
            Console.WriteLine();
            E2.ShowDetails();
            Console.WriteLine();

            Console.WriteLine("After moving again");
            E1.MoveAround(10);
            E2.MoveAround(500);

            E1.ShowDetails();
            Console.WriteLine();
            E2.ShowDetails();

            Console.ReadKey();
        }
    }
}
