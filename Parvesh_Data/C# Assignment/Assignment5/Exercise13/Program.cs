using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment13
{
    
    public static class CustomClass               
    {
        public delegate bool Mydelegate<T>(T n);
        public static bool CustomAll<T>(this IEnumerable<T> enum1, Func<T,bool> mydelegate )
        {
            return enum1.All(mydelegate);
        }

        public static bool CustomAny<T>(this IEnumerable<T> enum2, Func<T, bool> condition)
        {
            return enum2.Any(condition);
        }

        public static TResult CustomMax<T, TResult>(this IEnumerable<T> list, Func<T, TResult> MaxDelegate)
        {
            return list.Max(MaxDelegate);
        }

        public static TResult CustomMin<T, TResult>(this IEnumerable<T> list, Func<T, TResult> MinDelegate)
        {
            return list.Min(MinDelegate);
        }

        public static IEnumerable<T> CustomWhere<T>(this IEnumerable<T> list, Func<T, bool> WhereDelegate)
        {
            return list.Where(WhereDelegate);
        }

        public static IEnumerable<TResult> CustomSelect<T, TResult>(this IEnumerable<T> list, Func<T, TResult> SelectDelegate)
        {
            return list.Select(SelectDelegate);
        }
    }

    class Program
    {
        public static void Print<T>(IEnumerable<T> list)
        {
            foreach (T el in list)
                Console.Write(el + "  ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            IEnumerable<int> list = new List<int>() { 3, 2, 1, 2, 3, 4, 5, 4, 3 };


            Console.WriteLine(list.CustomAll(n => n > 0));
            Console.WriteLine(list.CustomAny(n => n == 2));
            Console.WriteLine(list.CustomMax(n => 2 * n));
            Console.WriteLine(list.CustomMin(n => 2 * n));

            IEnumerable<int> whereEnum = list.CustomWhere(n => n % 2 == 1);
            Print(whereEnum);
            IEnumerable<double> selectEnum = list.CustomSelect(n => 0.5 * n);
            Print(selectEnum);

            Console.ReadKey();
        }
    }
}
