using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box();
            box.AddProduct(new Product("Monopoly", 80));
            box.AddProduct(new Product("Player's Unknown Battlegrounds", 200));
            box.AddProduct(new Product("Coffee mug", 20));

            IAbstractIterator iterator = box.GetIterator();

            for (Product product= iterator.First(); iterator.IsDone == false; product= iterator.Next())
            {
                Console.WriteLine(product.ToString());
            }

        }
    }
}
