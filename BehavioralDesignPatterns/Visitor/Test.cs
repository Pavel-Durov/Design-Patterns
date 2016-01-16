using BehavioralDesignPatterns.Visitor.Interfaces;
using BehavioralDesignPatterns.Visitor.Model;
using BehavioralDesignPatterns.Visitor.Model.Products;
using BehavioralDesignPatterns.Visitor.Model.Products.Base;
using BehavioralDesignPatterns.Visitor.Model.Visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Visitor
{
    class Test
    {
        public static void Run()
        {
            GroceryStore store = new GroceryStore();

            //IProductVisitor visitor = new InflationVisitor(1.3);
            IProductVisitor visitor = new ProductNameVisitor("BEST-STORE-EVER");
            for (int i = 0; i < 1; i++)
            {
                store.Add(new Tobacco(30));
            }

            for (int i = 0; i < 1; i++)
            {
                store.Add(new Bread(30));
            }

            for (int i = 0; i < 1; i++)
            {
                store.Add(new Milk(30));
            }

            store.PrintPrices();

            Console.WriteLine(" @@ INFALTION @@ ");

            store.Inflation(visitor);
            store.PrintPrices();
        }
    }
}
