using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_2
{
    class Box : IAbstractCollection
    {
        private List<Product> products;

        public Box()
        {
            this.products = new List<Product>();
        }

        public Box(List<Product> products)
        {
            this.products = new List<Product>(products.ToArray());
        }

        public Product this[int index]
        {
            get
            {
                return this.products[index];
            }
        }

        public void AddProduct(Product product)
        {
            this.products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            this.products.Remove(product);
        }

        public int Count
        {
            get
            {
                return this.products.Count;
            }
        }

        public IAbstractIterator GetIterator()
        {
            return new Iterator(this); 
        }

    }
}
