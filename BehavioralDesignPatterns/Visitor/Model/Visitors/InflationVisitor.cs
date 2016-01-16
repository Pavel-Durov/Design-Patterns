using BehavioralDesignPatterns.Visitor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BehavioralDesignPatterns.Visitor.Model.Products;
using BehavioralDesignPatterns.Visitor.Model.Products.Base;

namespace BehavioralDesignPatterns.Visitor.Model.Visitors
{
    class InflationVisitor : IProductVisitor
    {
        public InflationVisitor(double infaltionPercent)
        {
            InflationAmount = infaltionPercent;
        }

        public double InflationAmount { get; set; }

        public void Visit(Product prod)
        {
            prod.Price *= InflationAmount;
        }
        
    }
}
