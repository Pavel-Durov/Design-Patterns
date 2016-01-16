using StructuralDesignPatterns.Decorator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Decorator
{
    public class Test
    {
        public static void Run()
        {
            CupcakeSmartOven oven = new CupcakeSmartOven();

            oven.GenerateCupcakes();
        }
    }
}
