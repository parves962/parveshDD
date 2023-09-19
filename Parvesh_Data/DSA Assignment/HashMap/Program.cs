using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashMap
{
    public class HashTable<T>
    {

        public class Node
        {
            public Node Next { get; set; }
            public string Key { get; set; }
            public T Value { get; set; }
        }

        public int size;
        public int tableSize;
        public Node[] buckets;

        public HashTable(int size)
        {
            buckets = new Node[size];
            tableSize = size;
        }

        public (Node previous,Node current) GetNode(string key)
        {
            int position = GetBucketBykey(key);
            Node hashtable = buckets[position];
            Node previous = null;

            while(null != hashtable)
            {
                if(hashtable.Key == key)
                {
                    return (previous, hashtable);
                }
                previous = hashtable;
                hashtable = hashtable.Next;
            }
            return (null, null);
        }

        public int GetBucketBykey(string key)
        {
            return key[0] % buckets.Length;
        }

        public void Insert(string key, T value)
        {
            var (_, element) = GetNode(key);

            if(size == tableSize)
            {
                throw new Exception("\nHash Table is Full");
                
            }

            if(element != null)
            {
                throw new Exception("\nkey is already present in table");
                
            }

            Node newNode = new Node
            {
                Key = key,
                Value = value,
                Next = null
            };

            int position = GetBucketBykey(key);
            Node hashtable = buckets[position];

            if(hashtable == null)
            {
                buckets[position] = newNode;
                size++;
                OperationSuccess();
                return;
            }

            while(null != hashtable.Next)
            {
                hashtable = hashtable.Next;
            }
            hashtable.Next = newNode;
            size++;
            OperationSuccess();
        }

        public void Delete(string key)
        {
            int position = GetBucketBykey(key);
            var (previous, current) = GetNode(key);

            if(size == 0)
            {
                throw new Exception("/nHash Table is empty");
                
            }

            if(current == null)
            {
                throw new Exception("/n no such element is present in the hash table");
            }

            if(previous == null)
            {
                buckets[position] = null;
                size--;
                OperationSuccess();
                return;
            }

            previous.Next = current.Next;
            size--;
            OperationSuccess();
        }

        public bool Contains(string key)
        {
            var (_, element) = GetNode(key);
            return null != element;
        }

        public int Size()
        {
            return size;
        }

        public T GetValueByKey(string key)
        {
            // check the hash table if key is present
            var (_, element) = GetNode(key);

            // If key not found then throw an exception
            if (element == null)
            {
                throw new Exception("key is not present is hash");
            }
            return element.Value;
        }


        public void Print()
        {
            if(size == 0)
            {
                throw new Exception("\nHash Table is empty!");
                
            }

            Console.WriteLine("\nHash table : (key) --> (Value)");
            foreach(var i in buckets)
            {
                if(i != null)
                {
                    var temp = i;
                    while(temp.Next != null)
                    {
                        Console.WriteLine("{0} --> {1}",temp.Key,temp.Value);
                        temp = temp.Next;
                    }
                    Console.WriteLine("{0} --> {1}",temp.Key,temp.Value);
                }
            }
        }

        public void OperationSuccess()
        {
            Console.WriteLine("\nOperation Successful!");
        }

        public IEnumerable<Node> GetIteratedTable()
        {
            Node temp;
            foreach (var items in buckets)
            {
                temp = items;
                // Returning the element after every iteration
                if (items != null && items.Next == null)
                {
                    yield return items;
                }
                if (items != null && items.Next != null)
                {
                    while (temp.Next != null)
                    {
                        yield return temp;
                        temp = temp.Next;
                    }
                    yield return temp;
                }
            }
        }

        // Iterator of given hash table
        public void Iterator()
        {
            if (size == 0)
            {
                Console.WriteLine("\nHash Table is empty!");
                return;
            }


            IEnumerable<Node> hashTable = GetIteratedTable();
            Console.WriteLine("\nHash Table using Iterator : (Key) --> (Value)\n ");
            foreach (var i in hashTable)
            {
                Console.WriteLine("{0} -- > {1}", i.Key, i.Value);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            HashTable<int> hash = new HashTable<int>(5);
            try
            { 
                Console.WriteLine("inserting elements in hash ");
                hash.Insert("First", 1);
                hash.Insert("Second", 2);
                hash.Insert("Third", 3);
                hash.Insert("4th", 4);
                hash.Insert("5ifth", 5);

                hash.Print();

                hash.Delete("4th");

                hash.Print();
                Console.WriteLine();

                int value = hash.GetValueByKey("First");
                Console.Write("Get value of First : ");
                Console.WriteLine(value);
                Console.WriteLine();
                Console.Write("if hash ontains First : ");
                Console.WriteLine(hash.Contains("First"));
                Console.WriteLine();
                Console.Write("size of hash : ");
                Console.WriteLine(hash.Size());
                Console.WriteLine();
                Console.WriteLine("Iterator => ");
                hash.Iterator();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
