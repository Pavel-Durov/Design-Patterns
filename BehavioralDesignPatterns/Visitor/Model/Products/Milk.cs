using BehavioralDesignPatterns.Visitor.Model.Products.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BehavioralDesignPatterns.Visitor.Interfaces;

namespace BehavioralDesignPatterns.Visitor.Model.Products
{
    class Milk : Product
    {
        public Milk(double price) : base(price, "Milk")
        {
        }
    }
}
