using BehavioralDesignPatterns.Visitor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Visitor.Model.Products.Base
{
    abstract class Product : IVisitable
    {
        public Product(double price, string name)
        {
            Price = price;
            Name = name;
        }

        public double Price { get; set; }
        public string Name { get; set; }

        public virtual void Accept(IProductVisitor visitor)
        {
            visitor.Visit(this);
        }

    }
}
