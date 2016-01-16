using StructuralDesignPatterns.Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Decorator.Decorators
{
    class CreamCupcakeDecorator : CupcakeDecorator
    {
        public CreamCupcakeDecorator(ICupcake newCupcake) : base(newCupcake)
        {
            Console.WriteLine("Adding cream");
        }

        private const double TOPPONG_COST = 4.4;

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
                return $"{_tempCupcake.Description} + CREAM toping";
            }
        }
    }
}
