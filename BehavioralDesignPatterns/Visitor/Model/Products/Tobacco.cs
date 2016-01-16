using BehavioralDesignPatterns.Visitor.Model.Products.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Visitor.Model.Products
{
    class Tobacco : Product
    {
        public Tobacco(double price) : base(price, "Tobacco")
        {
        }
    }
}
