using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priority_Queue
{
    class PriorityQueue
    {
        public int key;
        public string value;
        public int[] PQ = new int[100];
        public string[] Value = new string[100];
        public int Size;

        public PriorityQueue()
        {
            this.Size = 0;
        }

        
        public void insert(int key, string value)
        {
            Size += 1;
            int index = Size;
            PQ[index] = key;
            Value[index] = value;
            

            while (index > 1)
            {
                int parent = index / 2;

                if (PQ[parent] < PQ[index])
                {
                    int temp = PQ[parent];
                    PQ[parent] = PQ[index];
                    PQ[index] = temp;

                    string temp1 = Value[parent];
                    Value[parent] = Value[index];
                    Value[index] = temp1;
                }
                else
                {
                    return;
                }
            }
        }

        public void delete()
        {
            if (Size == 0)
            {
                throw new Exception("queue is empty");
               
            }

            //put last element in heap
            PQ[0] = PQ[Size];
            Value[0] = Value[Size];

            //remove last element
            Size -= 1;

            //putting it at its correct position
            int i = 0;
            while (i < Size)
            {
                int leftIndex = 2 * i;
                int rightIndex = 2 * i + 1;

                if (leftIndex < Size && PQ[i] < PQ[leftIndex])
                {
                    int temp = PQ[i];
                    PQ[i] = PQ[leftIndex];
                    PQ[leftIndex] = temp;

                    string temp1 = Value[i];
                    Value[i] = Value[leftIndex];
                    Value[leftIndex] = temp1;

                    i = leftIndex;
                }

                else if (rightIndex < Size && PQ[i] < PQ[rightIndex])
                {
                    int temp = PQ[i];
                    PQ[i] = PQ[rightIndex];
                    PQ[rightIndex] = temp;

                    string temp1 = Value[i];
                    Value[i] = Value[rightIndex];
                    Value[rightIndex] = temp1;

                    i = rightIndex;
                }
                else
                {
                    return;
                }
            }
        }

        public void print()
        {
            if(Size == 0)
            {
                throw new Exception("queue is empty");
            }
            for (int i = 1; i <=Size; i++)
            {
                Console.Write(this.PQ[i] + " : ");
                Console.WriteLine(this.Value[i]);
            }
        }

        public void size()
        {
            Console.WriteLine("Size : " + Size);
        }

        public void contains(int key, string value)
        {
            bool found = false;
            Console.Write("If Queue has contains this value : ");
            for (int i = 0; i < Size; i++)
            {
                if (PQ[i] == key && Value[i] == value)
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                Console.Write("True");
            }
            else
            {
                Console.Write("false");
            }
        }

        public void peek()
        {
            if (Size > 0)
            {
                Console.Write(PQ[1] + " : ");
                Console.WriteLine(Value[1]);
            }
            else
            {
                throw new Exception("queue is empty");
            }

        }

        public void reverse()
        {
            Console.WriteLine("Reverse of queue");
            for (int i = Size - 1; i >= 0; i--)
            {
                Console.Write(this.PQ[i] + " : ");
                Console.WriteLine(this.Value[i]);
            }
        }

        public void center()
        {
            Console.Write("center element : ");
            Console.Write(PQ[Size / 2] + " : ");
            Console.WriteLine(Value[Size / 2]);
        }

        public IEnumerable<int> GetIterable1()
        {
            
            for (int i = 0; i < Size; i++)
            {
                yield return PQ[i];
            }
        }

        public IEnumerable<string> GetIterable2()
        {
            for (int i = 0; i < Size; i++)
            {
                yield return Value[i];
            }

        }

        public void iterable()
        {
            if(Size == 0)
            {
               Console.WriteLine("nothing to iterate ");
                return;
            }

            IEnumerable<int> enum1;
            IEnumerable<string> enum2;

            enum1 = GetIterable1();
            enum2 = GetIterable2();

            int i = 0;
            foreach (var item in enum1)
            {
                Console.Write(item + " : ");
                int j = 0;
                foreach (var item1 in enum2)
                {
                   if(i == j)
                   {
                        Console.WriteLine(item1); ;
                   }
                    j += 1;
                }
                i += 1;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue p1 = new PriorityQueue();
            try
            {
                p1.insert(50, "car");
                p1.insert(55, "jeep");
                p1.insert(53, "bus");
                p1.insert(52, "truck");
                p1.insert(54, "tarctor");

                p1.print();

                Console.WriteLine();
                Console.WriteLine("After deleting a element");
                p1.delete();
                p1.print();

                Console.WriteLine();
                Console.Write("Peek element : ");
                Console.WriteLine();

                p1.peek();
                Console.WriteLine();

                p1.reverse();
                Console.WriteLine();

                p1.center();
                Console.WriteLine();

                p1.contains(52, "tr");
                Console.WriteLine("\n");
                Console.WriteLine("size : " + p1.Size);

                Console.WriteLine();
                p1.iterable();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
