using StructuralDesignPatterns.Composite.ConstructionSite.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Composite.ConstructionSite
{
    class Test
    {
        public static void Run()
        {
            var tomTheWorker = new Employee("Joni","Polak");
            var borisTheWorker = new Employee("Boris", "Cohen");

            var bill = new Boss("Bill", "Hill");
            var mary = new Boss("Mary", "Gery");
            var anna = new Boss("Anna","Karrenina");

            //Set up the relationships

            //Tom works for Mary
            bill.AddSubordinate(tomTheWorker);
            bill.AddSubordinate(borisTheWorker);

            //Bill works for anna
            anna.AddSubordinate(bill);


            //Anna works for Mary
            anna.AddSubordinate(mary);

            //TODO: What will happe if we assign Anna as it's subordinate
            //anna.AddSubordinate(anna);

            anna.Work();
        }
    }
}
