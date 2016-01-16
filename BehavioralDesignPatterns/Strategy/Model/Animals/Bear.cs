using BehavioralDesignPatterns.Strategy.Model.Animals.Base;
using BehavioralDesignPatterns.Strategy.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Strategy.Model.Animals
{
    class Bear : Animal
    {
        public Bear(double wight) : base(wight, "Honney", "Arrrhhhh", new CannotFly())
        {
        }

        public override void Sleep()
        {
            Sound = "ZZZZZZ";
            Console.WriteLine($"Bear, {Sound}");
        }

        public override void WakeUp()
        {
            Sound = "Arrrhhhh";
            Console.WriteLine("Bear is waked up");

        }
    }
}
