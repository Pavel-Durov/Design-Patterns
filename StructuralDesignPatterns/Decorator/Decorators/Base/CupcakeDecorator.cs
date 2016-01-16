using StructuralDesignPatterns.Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Decorator.Decorators
{
    public class CupcakeDecorator : ICupcake
    {
        public CupcakeDecorator(ICupcake newCupcake)
        {
            Console.WriteLine("Adding dough");
            this._tempCupcake = newCupcake;
        }
        protected ICupcake _tempCupcake;

        public virtual double Cost
        {
            get
            {
                return _tempCupcake.Cost;
            }
        }

        public virtual string Description
        {
            get
            {
                return _tempCupcake.Description;
            }
        }
    }
}
