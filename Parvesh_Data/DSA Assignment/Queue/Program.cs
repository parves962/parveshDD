using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        int[] queue;
        int front;
        int rear;
        int capacity;
        int size;

        public Program(int maxsize)
        {
            this.capacity = maxsize;
            queue = new int[maxsize];
            this.front = 0;
            this.rear = 0;
        }

        public void push(int data)
        {
            if (this.rear == this.capacity)
            {
                throw new Exception("Queue is full");
            }
            else
            {
                //this.queue[this.rear] = data;
                this.queue[this.rear] = data;
                this.rear += 1;
                this.size += 1;
            }
        }

        public void pop()
        {
            if (this.size == 0)
            {
                throw new Exception("queue is empty");
            }
            else
            {
                this.front += 1;
                this.size -= 1;
            }
        }

        public void print()
        {
            for (int i = this.front; i < this.rear; i++)
            {
                Console.Write(this.queue[i] + " ");

            }
        }

        public void reverse()
        {
            while (this.rear != this.front)
            {
                Console.Write(this.queue[this.rear - 1] + " ");
                this.rear -= 1;
            }
        }

        public void sort()
        {
            for (int i = this.front; i < this.rear - 1; i++)
            {
                for (int j = i + 1; j < this.rear; j++)
                {
                    if (this.queue[i] > this.queue[j])
                    {
                        int temp = this.queue[i];
                        this.queue[i] = this.queue[j];
                        this.queue[j] = temp;
                    }
                }
            }
        }

        public void Contains()
        {
            for (int j = this.queue[this.front]; j < this.size; j++)
            {
                Console.WriteLine(this.queue[j]);
            }
        }

        public void center()
        {
            int gap = this.size / 2;
            Console.WriteLine("Center of queue : " + this.queue[this.front + gap - 1]);
        }

        public void peek()
        {
            if (this.size == 0)
            {
                throw new Exception("queue is empty");
            }
            else
            {
                Console.Write("Peek Element : ");
                Console.WriteLine(this.queue[front]);
            }
        }

        public void Contains(int data)
        {
            Console.Write("If " + data + " is present in queue : ");
            bool found = false;
            for (int i = this.front; i <= this.rear; i++)
            {
                if (this.queue[i] == data)
                {
                    found = true;
                }
            }
            if (found)
            {
                Console.Write(found);
            }
            else
            {
                Console.Write(found);
            }
        }

        public IEnumerable<int> GetIterator()
        {
            for (int j = this.queue[this.front]; j <= this.size; j++)
            {
                yield return queue[j];
            }
        }

        public void Iterate()
        {
            IEnumerable<int> enum2 = GetIterator();

            foreach(var item in enum2)
            {
                Console.Write(item + " ");

            }
        }
        static void Main(string[] args)
        {
            Program p1 = new Program(5);
            try
            {
                

                p1.push(5);
                p1.push(3);
                p1.push(2);
                p1.push(4);
                p1.push(1);
                p1.print();

                Console.WriteLine("\n");
                Console.WriteLine("after a single pop");
                p1.pop();
                p1.print();

                Console.WriteLine("\n");
                Console.WriteLine("Size : " + p1.size);
                Console.WriteLine();

                Console.WriteLine("After sorting");
                p1.sort();
                p1.print();

                Console.WriteLine("\n");
                Console.WriteLine("After reverse");
                p1.reverse();
                Console.WriteLine("\n");

                p1.center();
                Console.WriteLine();

                p1.peek();
                Console.WriteLine();

                p1.Contains(1);
                Console.WriteLine("\n");

                Console.WriteLine("Iterating elements : ");
                p1.Iterate();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}