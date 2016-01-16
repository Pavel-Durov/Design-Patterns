using BehavioralDesignPatterns.Visitor.Model.Products;
using BehavioralDesignPatterns.Visitor.Model.Products.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Visitor.Interfaces
{
    interface IProductVisitor
    {
        void Visit(Product product);
    }
}
