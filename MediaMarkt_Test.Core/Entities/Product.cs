using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaMarkt_Test.Core.Entities
{
    public class Product
    {
        public int? id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string Family { get; set; }

        /// <summary>
        /// Mapping empty constructor
        /// </summary>
        public Product() { }
        public Product(int id, string name, string description, double price, string family)
        {
            this.id = id;
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.Family = family;
        }
    }
}
