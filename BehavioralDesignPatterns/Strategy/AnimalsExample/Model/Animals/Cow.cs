using BehavioralDesignPatterns.Strategy.Model.Animals.Base;
using BehavioralDesignPatterns.Strategy.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Strategy.Model.Animals
{
    class Cow : Animal
    {
        public Cow(double wight) : base(wight, "Grass Hay", "Moo", new CannotFly())
        {
        }

        public override void Sleep()
        {
            Sound = "ZZZZZZ";
            Console.WriteLine($"Cow {Sound}");
        }

        public override void WakeUp()
        {
            Sound = "Moo";
            Console.WriteLine("Cow is waked up");
        }
    }
}
