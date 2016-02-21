using StructuralDesignPatterns.Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Decorator.Model
{
    class PlainCupcake : ICupcake
    {
        private const double COST = 4.2;

        public double Cost
        {
            get { return COST; }
        }

        public string Description
        {
            get { return "Plain Cupcake"; }
        }
    }
}
