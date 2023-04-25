using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Exercise
{
    internal class Product
    {
        public int Id { private get; set; }
        public string Name { private get; set; }
        public Product(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public override string ToString()
        {
            return $"Product-{this.Id} : {this.Name}";
        }
    }
}
