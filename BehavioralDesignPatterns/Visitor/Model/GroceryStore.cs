using BehavioralDesignPatterns.Visitor.Interfaces;
using BehavioralDesignPatterns.Visitor.Model.Products.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Visitor.Model
{
    class GroceryStore
    {
        public GroceryStore()
        {
            Products = new List<Product>();
        }

        public List<Product> Products { get; private set; }

        public void Add(Product product)
        {
            Products.Add(product);  
        }

        internal void AcceptVisitor(IProductVisitor visitor)
        {
            foreach (var item in Products)
            {
                item.Accept(visitor);
            }
        }

        internal void PrintPrices()
        {
            foreach (var item in Products)
            {
                Console.WriteLine($"{item.Name} , price : {item.Price}");
            }
        }
    }
}
