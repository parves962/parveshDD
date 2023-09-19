using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment15
{
    public class Collection
    {
        public delegate void collectionEventHandler(object source, EventArgs e);
        public event collectionEventHandler collectionModifyEvent;
        public event collectionEventHandler collectionChangeEvents;

        public void CollectionEvents(List<string> Itemlist)
        {
            Console.WriteLine("Elements in list are ");
            foreach(var item in Itemlist)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Itemlist.Add("X");
            Console.WriteLine();

            if(collectionModifyEvent != null)
            {
                collectionModifyEvent(this, EventArgs.Empty);
            }

            foreach(var item in Itemlist)
            {
                Console.Write(item +" ");
            }
            Console.WriteLine();
            if(collectionChangeEvents != null)
            {
                collectionChangeEvents(this, EventArgs.Empty);
            }
            Itemlist.Remove("X");
            foreach (var item in Itemlist)
            {
                Console.WriteLine(item + " ");
            }
        }
    }

    public class AddingElement
    {
        public void OnAddingElement(object source,EventArgs e)
        {
            Console.WriteLine("Element x is added to the collection");
        }
    }

    public class RemovingElement
    {
        public void OnRemovingElement(object source, EventArgs e)
        {
            Console.WriteLine("Element x is removed from the collection");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var ItemList = new List<string>();
            ItemList.Add("A");
            ItemList.Add("B");
            ItemList.Add("C");

            var NewCollection = new Collection();
            var AddElement = new AddingElement();
            var Remelement = new RemovingElement();

            NewCollection.collectionModifyEvent += AddElement.OnAddingElement;
            NewCollection.collectionChangeEvents += Remelement.OnRemovingElement;
            NewCollection.CollectionEvents(ItemList);
            Console.ReadKey();
        }
    }
}
