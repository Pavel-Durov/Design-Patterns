using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Factory.AbstractrFactory.Cars
{
    class PrivateCar : Car
    {
        public PrivateCar(string factoryName) : base(factoryName)
        {
        }
    }
}
