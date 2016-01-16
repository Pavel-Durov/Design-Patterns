using CreationalDesignPatterns.Factory.AbstractrFactory.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Factory.AbstractrFactory
{
    abstract class AbstractCarFactory
    {
        #region Question

        //TODO: There is a diffrance between Abstract Factory and Factory Method. What is the diffrance?
        //Links that may help: 
        // http://stackoverflow.com/questions/4209791/design-patterns-abstract-factory-vs-factory-method
        // http://www.codeproject.com/Articles/716413/Factory-Method-Pattern-vs-Abstract-Factory-Pattern
        

        #endregion


        public abstract PrivateCar CreatePrivateCar();
        public abstract SportCar CreateSportCar();
    }
}
