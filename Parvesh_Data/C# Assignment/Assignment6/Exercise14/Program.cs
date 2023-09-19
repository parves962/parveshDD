using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment14
{
    class Product
    {
        public delegate void ProductEventhandler(object source, EventArgs e);
        public event ProductEventhandler PriceChangeEvent;
        public event ProductEventhandler BecameDefectiveEvent;

        public int Id;
        public int Price;
        public bool Isdefective;
        public static IDictionary<int, int> Inventary = new Dictionary<int, int>();
        public static int TotalValue = 0;

        public Product(int id, int price, bool isDefective)
        {
            this.Id = id;
            this.Price = price;
            this.Isdefective = isDefective;
        }

        public void AddProduct(int quantity)
        {
            Inventary[this.Id] = quantity;
            TotalValue += this.Price * quantity;
        }

        public void RemoveProduct(int id)
        {
            TotalValue -= this.Price * Inventary[id];
            if (Inventary.ContainsKey(id))
            {
                Inventary.Remove(id);
            }

        }

        public void UpdateProductQuantity(int quantity)
        {
            Inventary[this.Id] += quantity;
            TotalValue += this.Price * quantity;
        }

        public void PriceChange(int price)
        {
            this.Price = price;
            this.PriceChangeEvent(this, EventArgs.Empty);
        }

        public void OnPriceChange(object source, EventArgs e)
        {
            TotalValue += this.Price * Inventary[this.Id];
            Console.WriteLine("On Changing of price, Total Value get updated");
        }


        public void BecameDefective()
        {
            this.Isdefective = false;
            this.BecameDefectiveEvent(this, EventArgs.Empty);
        }

        public void OnBecameDefective(object source, EventArgs e)
        {
            Inventary.Remove(this.Id);
            Console.WriteLine("On becomin defective, product get removed");
        }
        public void showItems()
        {
            foreach (var item in Inventary)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
            Console.WriteLine(TotalValue);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Product P1 = new Product(1, 10, false);
            Product P2 = new Product(2, 15, false);
            Product P3 = new Product(3, 20, true);

            P1.AddProduct(10);
            P2.AddProduct(8);
            P3.AddProduct(12);

            P1.UpdateProductQuantity(10);
            P1.showItems();

            Console.WriteLine();
            Console.WriteLine("After Removing 1st product");
            P1.RemoveProduct(1);
            P1.showItems();
            Console.WriteLine();

            P2.PriceChangeEvent += P2.OnPriceChange;
            P2.PriceChange(12);

            Console.WriteLine();
            P2.BecameDefectiveEvent += P2.OnBecameDefective;
            P2.BecameDefective();

            Console.WriteLine();
            P2.showItems();
            Console.ReadKey();
        }
    }
}
