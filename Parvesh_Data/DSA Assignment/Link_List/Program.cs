using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Link_List
{
    public class Node
    {
        public int Data;
        public Node Next;
        public Node(int data)
        {
            this.Data = data;

        }
    }

    class Program
    {
        public Node Insert(int data, Node Head)
        {
            Node new_node = new Node(data);
            if (Head == null)
            {
                Head = new_node;
                Head.Next = null;
            }
            else
            {
                new_node.Next = Head;
                Head = new_node;
            }
            return Head;
        }

        public void Print(Node Head)
        {
            if (Head == null)
            {
                throw new Exception("Link list is empty");

            }
            else
            {
                while (Head != null)
                {
                    Console.Write(Head.Data + "=>");
                    Head = Head.Next;
                }
            }
        }

        public Node InsertAt(int data, int key, Node Head)
        {
            Node head = Head;
            bool Found = true;
            while (Found)
            {
                if (head.Data == key)
                {
                    Node new_node = new Node(data);
                    new_node.Next = head.Next;
                    head.Next = new_node;
                    Found = false;
                }
                else
                {
                    head = head.Next;
                }
            }

            return Head;
        }

        public Node Delete(Node Head)
        {
            Head = Head.Next;
            return Head;
        }

        public Node DeleteAt(int key, Node Head)
        {
            Node head = Head;
            bool Found = true;
            Node prev = null;
            while (Found)
            {
                if(head == null)
                {
                    throw new Exception("Item not found");
                }
                if (head.Data == key)
                {
                    prev.Next = head.Next;
                    head.Next = null;
                    Found = false;
                }
                else
                {
                    prev = head;
                    head = head.Next;
                    prev.Next = head;
                }
            }

            

            return Head;
        }

        public void Center(Node Head)
        {
            Node fastptr = Head;
            Node slowptr = Head;

            while (fastptr.Next != null && fastptr.Next.Next != null)
            {
                fastptr = fastptr.Next.Next;
                slowptr = slowptr.Next;
            }

            Console.WriteLine("Middle element -> " + slowptr.Data);
        }

        public Node sort(Node Head)
        {
            Node head1 = Head;

            while (head1.Next != null)
            {
                Node head2 = head1.Next;
                while (head2 != null)
                {
                    if (head1.Data > head2.Data)
                    {
                        int temp = head1.Data;
                        head1.Data = head2.Data;
                        head2.Data = temp;
                    }

                    head2 = head2.Next;
                }
                head1 = head1.Next;
            }

            return Head;
        }

        public void Reverse(Node Head)
        {
            if (Head == null)
            {
                return;
            }

            Reverse(Head.Next);

            Console.Write(Head.Data + "->");
        }

        public void Size(Node Head)
        {
            int size = 0;
            while (Head != null)
            {
                size += 1;
                Head = Head.Next;
            }
            Console.WriteLine("Size : " + size);
        }

        public IEnumerable<Node> GetIterator(Node Head)
        {
            while (Head != null)
            {
                yield return Head;
                Head = Head.Next;
            }
        }

        public void Iterator(Node Head)
        {
            IEnumerable<Node> enum1 = GetIterator(Head);
            foreach (var node in enum1)
            {
                Console.Write(node.Data + "=>");
                Head = Head.Next;
            }
        }

        static void Main(string[] args)
        {
            Program p1 = new Program();
            try
            {

                Node Head = null;
                Head = p1.Insert(1, Head);
                Head = p1.Insert(2, Head);
                Head = p1.Insert(3, Head);
                Head = p1.Insert(4, Head);
                Head = p1.Insert(5, Head);

                Console.WriteLine("Printing of link list");
                p1.Print(Head);
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("Inserting 7 after 3 ");
                Head = p1.InsertAt(7, 3, Head);
                p1.Print(Head);
                Console.WriteLine();

                Console.WriteLine();
                Console.WriteLine("Deleting 1st element");
                Head = p1.Delete(Head);
                p1.Print(Head);
                Console.WriteLine();

                Console.WriteLine();
                Console.WriteLine("Deleting element from link list");
                Head = p1.DeleteAt(3, Head);
                p1.Print(Head);
                Console.WriteLine();

                Console.WriteLine("finding center of link list");
                Console.WriteLine();
                p1.Center(Head);
                Console.WriteLine();

                Console.WriteLine();
                Console.WriteLine("Sorted link list");
                Head = p1.sort(Head);
                p1.Print(Head);
                Console.WriteLine();

                Console.WriteLine();
                Console.WriteLine("Reverse of link list");
                p1.Reverse(Head);
                Console.WriteLine();

                Console.WriteLine();
                p1.Size(Head);

                Console.WriteLine();
                Console.WriteLine("Iterating element");
                p1.Iterator(Head);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}