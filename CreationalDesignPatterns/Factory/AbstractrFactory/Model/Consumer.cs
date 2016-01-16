using CreationalDesignPatterns.Factory.AbstractrFactory.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Factory.AbstractrFactory.Model
{
    class Consumer
    {
        public Consumer(AbstractCarFactory factory)
        {
            MyCar = factory.CreatePrivateCar();
        }

        public Car MyCar { get; set; }
    }
}
