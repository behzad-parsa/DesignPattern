using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Exercise
{
    internal class ProductCollection
    {
        private List<Product> products = new List<Product>();

        public void Push(Product product)
        {
            products.Add(product);
        }
        public Product Pop()
        {
            var lastElement = products[products.Count - 1];
            products.Remove(lastElement);
            return lastElement;
        }


        public IIterator<Product> CreateIteratorInstance()
        {
            return new ListIterator(this);
        }


        public class ListIterator : IIterator<Product>
        {
            private ProductCollection productCollection;
            private int index;
            public ListIterator(ProductCollection productCollection)
            {
                this.productCollection = productCollection;
            }

            public bool HasNext()
            {
                return index < productCollection.products.Count;
            }

            public void Next()
            {
                index++;
            }

            public Product Current()
            {
                return productCollection.products[index];
            }
        }
    }
}
