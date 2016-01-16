using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreationalDesignPatterns.Factory.AbstractrFactory.Cars;

namespace CreationalDesignPatterns.Factory.AbstractrFactory
{
    class MazdaFactory : AbstractCarFactory
    {
        public override PrivateCar CreatePrivateCar()
        {
            return new PrivateCar("Honda");
        }

        public override SportCar CreateSportCar()
        {
            return new SportCar("Mazda");
        }
    }
}
