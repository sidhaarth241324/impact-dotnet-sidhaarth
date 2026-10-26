using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    public class ProductCatalogue
    {
        public string Name { get; set; }
        public double Price  { get; set; }
        public Category Category { get; set; }

        public ProductCatalogue(string name,double price, Category category)
        {
            Name = name;
            Price = price;
            Category = category;
        }
    }
}
