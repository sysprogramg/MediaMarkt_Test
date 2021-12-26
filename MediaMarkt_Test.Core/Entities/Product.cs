using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaMarkt_Test.Core.Entities
{
    public class Product
    {
        public int id { get; private set; }
        public string Name { get; private set; }
        public string Desciption { get; private set; }
        public double Price { get; private set; }
        public string Family { get; private set; }

        /// <summary>
        /// Mapping empty constructor
        /// </summary>
        public Product() { }
        public Product(int id, string name, string description, double price, string family)
        {
            this.id = id;
            this.Name = name;
            this.Desciption = description;
            this.Price = price;
            this.Family = family;
        }
    }
}
