using BehavioralDesignPatterns.Visitor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BehavioralDesignPatterns.Visitor.Model.Products.Base;

namespace BehavioralDesignPatterns.Visitor.Model.Visitors
{
    class ProductNameVisitor : IProductVisitor
    {

        public ProductNameVisitor(string prefix)
        {
            this.PREFX = prefix;
        }

        private readonly string PREFX;

        public void Visit(Product product)
        {
            product.Name = $"{PREFX}.{product.Name }";
        }
    }
}
