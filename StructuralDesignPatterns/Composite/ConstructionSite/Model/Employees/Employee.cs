using StructuralDesignPatterns.Composite.ConstructionSite.Interfaces;
using System;

namespace StructuralDesignPatterns.Composite.ConstructionSite.Model
{
    class Employee : IEmployee
    {
        private string _firstName;
        private string _lastName;

        public virtual string Description
        {
            get { return $"-- {_firstName} {_lastName}"; }
        }

        public Employee(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }


        public virtual void Break()
        {
            Console.WriteLine($"Finnaly... {Description}");
        }

        public virtual void Work()
        {
            Console.WriteLine($"I am working alright? {Description}");
        }

    }
}
