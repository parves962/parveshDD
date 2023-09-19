using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_12
{
    class Program
    {
        public delegate bool MyDelegate(int ele);

        public static void Print(string message, IEnumerable<int> list)
        {
            Console.Write(message + " :   ");
            foreach (int num in list)
                Console.Write(num + "  ");
            Console.WriteLine();
            Console.WriteLine();
        }
        public static bool GreaterThanFive(int ele)
        {
            return ele > 5;
        }

        public static bool LessThanFive(int ele)
        {
            return ele < 5;
        }

        public static bool AnythingMethod(int ele)
        {
            return ele != 0;
        }
        static void Main(string[] args)
        {
            var IntegerList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            IEnumerable<int> OddNumber = IntegerList.Where(x => x % 2 != 0);
            Print("OddNumbers", OddNumber);


            IEnumerable<int> EvenNumber = IntegerList.Where(x => { return x % 2 == 0; });
            Print("EvenNumbers", EvenNumber);

            IEnumerable<int> PrimeNumber = IntegerList.Where(delegate (int x)
            {
                if (x <= 1)
                {
                    return false;
                }

                for (int i = 2; i < x / 2; i++)
                {
                    if (x % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            });
            Print("Prime Number", PrimeNumber);

            IEnumerable<int> PrimeAnother = IntegerList.Where(x =>
            {
                if (x <= 1)
                {
                    return false;
                }

                for (int i = 2; i < x / 2; i++)
                {
                    if (x % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            );
            Print("Prime Another", PrimeAnother);

            Func<int, bool> GreaterThan = GreaterThanFive;
            IEnumerable<int> greaterThanFive = IntegerList.Where(GreaterThan);
            Print("Greater Than Five", greaterThanFive);


            Func<int, bool> LessThan = new Func<int,bool>(LessThanFive);
            IEnumerable<int> lessThanFive = IntegerList.Where(GreaterThan);
            Print("Less Than Five", lessThanFive);

            Func<int, bool> Integers3k = new Func<int, bool>(x => x % 3 == 0);
            IEnumerable<int> List3k = IntegerList.Where(Integers3k);
            Print("3k", List3k);

            Func<int, bool> Integers3kplus1 = new Func<int, bool>(x => x % 3 == 1);
            IEnumerable<int> List3kplus1 = IntegerList.Where(Integers3kplus1);
            Print("3k + 1", List3kplus1);

            Func<int, bool> Integers3kplus2 = new Func<int, bool>(x => x % 3 == 2);
            IEnumerable<int> List3kplus2 = IntegerList.Where(Integers3kplus2);
            Print("3k + 2", List3kplus2);

            Func<int, bool> IntegersAnything = delegate (int x)
            {
                return x != 0;
            };
            IEnumerable<int> integersAnything = IntegerList.Where(IntegersAnything);
            Print("Anything", integersAnything);

            Func<int, bool> Anything = AnythingMethod;
           
            IEnumerable<int> AnythingList = IntegerList.Where(Anything);
            Print("Anything", AnythingList);

            Console.ReadKey();
        }
    }
}
