using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{

    class Program
    {
        int[] stack;
        int top;
        int size;
        int Capacity;
        public Program(int capacity)
        {
            Capacity = capacity;
            stack = new int[capacity];
            top = -1;
            size = 0;
        }
        public void push(int data)
        {
            if (top == Capacity)
            {
                throw new Exception("stack is full");
            }
            else
            {
                top++;
                this.stack[top] = data;
                size++;
            }

        }

        public void pop()
        {
            if (top == -1)
            {
                throw new Exception("Stack is empty");
            }
            else
            {
                int value = this.stack[top];
                this.top--;
                this.size--;
                Console.WriteLine("Poped element :" + value);
            }

        }
        public void print()
        {
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(this.stack[i]);
            }
        }

        public void Contains(int key)
        {
            bool find = false;
            for (int i = 0; i <= top; i++)
            {
                if (stack[i] == key)
                {
                    find = true;
                }
            }
            if (find)
            {
                Console.WriteLine(" Element is present");
            }
            else
            {
                Console.WriteLine("Element is not present");
            }
        }

        public void peek()
        {
            Console.WriteLine(this.stack[top]);
        }

        public void Size()
        {
            Console.WriteLine("Size : " + this.size);
        }

        public void Center()
        {
            int center = (this.size) / 2;
            Console.WriteLine("center element : " + stack[center - 1]);
        }

        public void sort()
        {
            for (int i = 0; i < this.size - 1; i++)
            {
                for (int j = i + 1; j < this.size; j++)
                {
                    if (this.stack[i] > this.stack[j])
                    {
                        int temp = this.stack[i];
                        this.stack[i] = this.stack[j];
                        this.stack[j] = temp;
                    }
                }
            }
        }

        public void Reverse()
        {
            for (int i = 0; i <= top; i++)
            {
                Console.WriteLine(this.stack[i]);
            }
        }

        public IEnumerable<int> GetIterator()
        {
            for (int i = top; i >= 0; i--)
            {
                yield return stack[i];
            }
        }

        public void iterate()
        {
            IEnumerable<int> enum1 = GetIterator();
            foreach (var item in enum1)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            Program p1 = new Program(5);
            try
            {

                p1.push(5);
                p1.push(2);
                p1.push(1);
                p1.push(7);
                p1.push(6);

                p1.print();

                Console.WriteLine();
                Console.WriteLine("After a single pop");
                p1.pop();
                p1.print();

                Console.WriteLine();
                Console.WriteLine("Peek element");
                p1.peek();

                Console.WriteLine();
                Console.WriteLine("Checking if element 2 contains in stack");
                p1.Contains(2);

                Console.WriteLine();
                p1.Size();
                Console.WriteLine();

                p1.Center();

                Console.WriteLine();
                Console.WriteLine("Sorted stack elements ");
                p1.sort();
                p1.print();

                Console.WriteLine();

                Console.WriteLine("Reverse of stack");
                p1.Reverse();
                Console.WriteLine();


                Console.WriteLine("Iterating elements");
                p1.iterate();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
