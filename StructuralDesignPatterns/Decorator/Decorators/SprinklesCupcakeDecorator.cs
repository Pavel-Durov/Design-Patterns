using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructuralDesignPatterns.Decorator.Interfaces;

namespace StructuralDesignPatterns.Decorator.Decorators
{
    class SprinklesCupcakeDecorator : CupcakeDecorator
    {
        public SprinklesCupcakeDecorator(ICupcake newCupcake) : base(newCupcake)
        {
            Console.WriteLine("Adding sprinkles");
        }

        private const double TOPPONG_COST = 0.4;

        public override double Cost
        {
            get
            {
                return _tempCupcake.Cost + TOPPONG_COST;
            }
        }

        public override string Description
        {
            get
            {
                return $"{_tempCupcake.Description} + SPRINKLES topping";
            }
        }
    }
}
