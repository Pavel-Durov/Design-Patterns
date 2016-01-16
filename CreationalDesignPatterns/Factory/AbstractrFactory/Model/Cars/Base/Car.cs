using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Factory.AbstractrFactory.Cars
{
    class Car
    {
        public Car(string factoryName)
        {
            FactoryName = factoryName;
        }
        public string FactoryName { get; set; }
    }
}
