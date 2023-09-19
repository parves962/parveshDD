using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    class PriorityQueue<T> where T : IEquatable<T>
    {
        private IDictionary<int, IList<T>> elements;

        public PriorityQueue()
        {
            elements = new SortedDictionary<int, IList<T>>();
        }

        public PriorityQueue(IDictionary<int, IList<T>> elements) : this() { }

        public int Count()
        {
            return elements.Count;
        }

        public bool Contains(T item)
        {
            bool ans = false;
            foreach (KeyValuePair<int, IList<T>> pair in elements)
            {
                if (pair.Value[0].Equals(item))
                {
                    Console.WriteLine($"{item} Found --> {pair.Key} {pair.Value[0]}");
                    ans = true;
                }
                if (ans == true) { return ans; }
            }
            return ans;
        }

        public T Dequeue()
        {
            IList<T> list = elements[elements.Keys.First()];
            int priority = elements.Keys.First();
            T highestPriority = list.First();

            list.Remove(highestPriority);
            if (list.Count == 0)
            {
                elements.Remove(priority);
            }
            return highestPriority;
        }

        public void Enqueue(int priority, T item)
        {
            IList<T> items;
            if (!elements.ContainsKey(priority))
            {
                elements.Add(priority, new List<T>());
            }
            items = elements[priority];
            items.Add(item);
        }

        public T Peek()
        {
            IList<T> priorityList = elements[elements.Keys.First()];
            return priorityList[0];
        }

        public int Gethighestpriority()
        {
            int firstKey = elements.Take(1).Select(d => d.Key).First();
            return firstKey;
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue<string> priorityQueue = new PriorityQueue<string>();

            priorityQueue.Enqueue(3, "Parvesh");
            priorityQueue.Enqueue(4, "Parul");
            priorityQueue.Enqueue(1, "Tushar");
            priorityQueue.Enqueue(2, "Pankaj");

            string str = "Aijaz";

            Console.WriteLine($" Top Item --> {priorityQueue.Peek()}");
            Console.WriteLine($" Removed Item --> {priorityQueue.Dequeue()}");
            Console.WriteLine($" Top Item --> {priorityQueue.Peek()}");
            Console.WriteLine($" Item present in this queue --> {priorityQueue.Count()}");
            Console.WriteLine($" Contain {str}  ---> {priorityQueue.Contains(str)}");
            Console.WriteLine($" Highest Priority Present --> {priorityQueue.Gethighestpriority()}");

            Console.ReadKey();
        }
    }
}
