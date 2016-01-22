using StructuralDesignPatterns.Flyweight.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Flyweight
{
    class Test
    {
        public static void Run()
        {
            ForestSimulator forestSimulator = new ForestSimulator(new TreesFlyweight());
            forestSimulator.Render();
        }
    }
}
