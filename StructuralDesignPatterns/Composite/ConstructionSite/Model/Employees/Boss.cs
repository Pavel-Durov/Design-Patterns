
using System;
using System.Collections.Generic;

namespace StructuralDesignPatterns.Composite.ConstructionSite.Model
{
    //TODO: Explain why boss class is derived from employee?

    class Boss : Employee
    {
        public Boss(string firstName, string lastName) : base(firstName, lastName)
        {
            _subordinates = new List<Employee>();
        }

        List<Employee> _subordinates;

        public override void Break()
        {
            Console.WriteLine("I don't need it, but I'll notify my suborinates");

            foreach (var worker in _subordinates)
            {
                worker.Break();
            }
        }

        public void AddSubordinate(Employee employee)
        {
            //TODO: What do we need to check here?
            _subordinates.Add(employee);
        }

        public override void Work()
        {
            Console.WriteLine($"I don't work! But I'll notify my suborinates {Description}");

            foreach (var worker in _subordinates)
            {
                worker.Work();
            }
        }


    }
}
