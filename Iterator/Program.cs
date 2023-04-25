using Iterator.Exercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var history = new BrowseHistory();
            history.Push("a");
            history.Push("b");
            history.Push("c");

            //if one day ,the internal structure of the class changed , this code would not affected
            var iterator = history.CreateIterator();
            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.Current());
                iterator.Next();
            }

            Console.WriteLine("\n -- Exercise --\n");
            //------- Exercise ---------------
            var productCollection = new ProductCollection();
            productCollection.Push(new Product(1, "Phone"));
            productCollection.Push(new Product(2, "Computer"));
            productCollection.Push(new Product(3, "AirPods"));


            var productIterator = productCollection.CreateIteratorInstance();

            while (productIterator.HasNext())
            {
                Console.WriteLine(productIterator.Current());
                productIterator.Next();
            }


            Console.ReadLine();
        }
    }
}
